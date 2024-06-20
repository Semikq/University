using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;

namespace lab31
{
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private GridViewColumnHeader _lastHeaderClicked = null;
        private ListSortDirection _lastDirection = ListSortDirection.Ascending;

        private void UpdateProcesses()
        {
            var processes = Process.GetProcesses().OrderBy(p => p.ProcessName);
            ProcessList.ItemsSource = processes;
        }

        private void RefreshButton_Click(object sender, RoutedEventArgs e)
        {
            UpdateProcesses();
        }

        private void ProcessList_RightClick(object sender, MouseButtonEventArgs e)
        {
            ProcessList.ContextMenu.IsEnabled =
                ProcessList.SelectedItem == null ? false : true;
        }

        private void ShowDetails_Click(object sender, RoutedEventArgs e)
        {
            if (ProcessList.SelectedItem is Process selectedProcess)
            {
                MessageBox.Show($"Name: {selectedProcess.ProcessName}\nProcess ID: {selectedProcess.Id}\nMemoty: {selectedProcess.WorkingSet64}", "Detail of process", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void KillProcess_Click(object sender, RoutedEventArgs e)
        {
            if (ProcessList.SelectedItem is Process selectedProcess)
            {
                try
                {
                    selectedProcess.Kill();
                    MessageBox.Show("Process has been finished!", "Finish", MessageBoxButton.OK, MessageBoxImage.Information);
                    UpdateProcesses();
                }
                catch (Exception) { }
            }
        }

        private void ExportButton_Click(object sender, RoutedEventArgs e)
        {
            var processes = Process.GetProcesses().OrderBy(p => p.ProcessName);
            string filePath = "processes.txt";

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var process in processes)
                {
                    writer.WriteLine($"{process.ProcessName} - Process ID: {process.Id}");
                }
            }

            MessageBox.Show($"List of processes is exported", "Export finish", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void ShowThreadsAndModules_Click(object sender, RoutedEventArgs e)
        {
            if (ProcessList.SelectedItem is Process selectedProcess)
            {
                try
                {
                    var threads = selectedProcess.Threads;
                    var modules = selectedProcess.Modules;
                    StringBuilder info = new StringBuilder();

                    info.AppendLine("Threads:");
                    foreach (ProcessThread thread in threads)
                        info.AppendLine($"Process ID: {thread.Id}, State: {thread.ThreadState}");

                    info.AppendLine("\nModules:");
                    foreach (ProcessModule module in modules)
                        info.AppendLine($"Name: {module.ModuleName}, Path: {module.FileName}");

                    MessageBox.Show(info.ToString(), "Threads and modules");
                }
                catch (Exception) { }
            }
        }

        private void GridViewColumnHeader_Click(object sender, RoutedEventArgs e)
        {
            var headerClicked = e.OriginalSource as GridViewColumnHeader;
            ListSortDirection direction;

            if (headerClicked != null)
            {
                if (headerClicked != _lastHeaderClicked)
                {
                    direction = ListSortDirection.Ascending;
                }
                else
                {
                    if (_lastDirection == ListSortDirection.Ascending)
                    {
                        direction = ListSortDirection.Descending;
                    }
                    else
                    {
                        direction = ListSortDirection.Ascending;
                    }
                }
                var columnBinding = headerClicked.Column.DisplayMemberBinding as Binding;
                var sortBy = columnBinding?.Path.Path ?? headerClicked.Column.Header as string;
                Sort(sortBy, direction);
                _lastHeaderClicked = headerClicked;
                _lastDirection = direction;
            }
        }

        private void Sort(string sortBy, ListSortDirection direction)
        {
            ICollectionView dataView = CollectionViewSource.GetDefaultView(ProcessList.ItemsSource);
            dataView.SortDescriptions.Clear();
            SortDescription sd = new SortDescription(sortBy, direction);
            dataView.SortDescriptions.Add(sd);
            dataView.Refresh();
        }

        private void ProcessList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}