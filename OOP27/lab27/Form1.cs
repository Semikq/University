using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Security.AccessControl;


namespace lab27
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drives)
            {
                listBox1.Items.Add(drive.Name);
                listBox1.Items.Add(" ");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DriveInfo selectedDrive = null;
            if (listBox1.SelectedItem != null)
            {
                string selectedItem = listBox1.SelectedItem.ToString();
                string selectedDriveName = selectedItem.Split(':')[0];
                foreach (DriveInfo drive in DriveInfo.GetDrives())
                {
                    if (drive.Name.StartsWith(selectedDriveName, StringComparison.OrdinalIgnoreCase))
                    {
                        selectedDrive = drive;
                        break;
                    }
                }
                if (selectedDrive != null)
                {
                    MessageBox.Show($"Диск: {selectedDrive.Name}\n" +
                                    $"Тип: {selectedDrive.DriveType}\n" +
                                    $"Ємність: {selectedDrive.TotalSize / (1024 * 1024 * 1024)} ГБ\n" +
                                    $"Вільно: {selectedDrive.TotalFreeSpace / (1024 * 1024 * 1024)} ГБ");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Виберіть файл для переміщенння";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string sourcePath = openFileDialog.FileName;
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Title = "Виберіть місце для переміщення файла";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string targetPath = saveFileDialog.FileName;
                    try
                    {
                        File.Move(sourcePath, targetPath);
                        MessageBox.Show("Файл переміщено");
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DirectoryInfo selectedDirectory = null;

            if (listBox1.SelectedItem != null)
            {
                string selectedItem = listBox1.SelectedItem.ToString();
                selectedDirectory = new DirectoryInfo(selectedItem);

                if (selectedDirectory.Exists)
                {
                    listBox2.Items.Clear();

                    string[] dirs = Directory.GetDirectories(selectedItem);
                    foreach (string s in dirs)
                    {
                        listBox2.Items.Add("Підкаталоги:");
                        listBox2.Items.Add(s);
                    }

                    string[] files = Directory.GetFiles(selectedItem);
                    foreach (string s in files)
                    {
                        listBox2.Items.Add("Файли:");
                        listBox2.Items.Add(s);
                    }
                }
                else
                {
                    listBox2.Items.Clear();
                    listBox2.Items.Add("Каталог не знайдено.");
                }
            }
            else
            {
                listBox2.Items.Clear();
                listBox2.Items.Add("Ви нічого не обрали.");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DirectoryInfo selectedDirectory = null;
            FileInfo selectedFile = null;

            if (listBox2.SelectedItem != null)
            {
                string selectedItem = listBox2.SelectedItem.ToString();
                selectedDirectory = new DirectoryInfo(selectedItem);

                if (selectedDirectory.Exists)
                {
                    MessageBox.Show($"Назва: {selectedDirectory.FullName}\n" +
                                    $"Дата створення: {selectedDirectory.CreationTime}\n" +
                                    $"Остання зміна: {selectedDirectory.LastWriteTime}\n" +
                                    $"Файли: {selectedDirectory.GetFiles().Length}\n" +
                                    $"Підкаталоги: {selectedDirectory.GetDirectories().Length}");
                }
                else
                {
                    selectedFile = new FileInfo(selectedItem);

                    if (selectedFile.Exists)
                    {
                        MessageBox.Show($"Назва: {selectedFile.Name}\n" +
                                       $"Розмір: {(selectedFile.Length / (1024)).ToString()} KB\n" +
                                       $"Дата створення: {selectedFile.CreationTime}\n" +
                                       $"Остання зміна: {selectedFile.LastWriteTime}");
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string selectedDrive = listBox1.SelectedItem.ToString();
                string rootPath = Path.GetPathRoot(selectedDrive);
                string[] allDirs = Directory.GetDirectories(rootPath);
                var filteredDirs = allDirs.Where(dir => dir.Contains(textBox1.Text));
                listBox3.Items.Clear();
                foreach (string dir in filteredDirs)
                {
                    listBox3.Items.Add(dir);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FileInfo selectedFile = null;
            listBox4.Items.Clear();
            if (listBox2.SelectedItem != null)
            {
                string path = listBox2.SelectedItem.ToString();
                try
                {
                    string readText = File.ReadAllText(path);
                    listBox4.Items.Add(readText);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DirectoryInfo selectedDirectory = null;
            FileInfo selectedFile = null;
            listBox5.Items.Clear();
            string selectedPath = listBox2.SelectedItem.ToString();
            try
            {
                FileSystemSecurity security = null;
                if (File.Exists(selectedPath))
                {
                    security = File.GetAccessControl(selectedPath);
                }
                else if (Directory.Exists(selectedPath))
                {
                    security = Directory.GetAccessControl(selectedPath);
                }
                else
                {
                    return;
                }
                AuthorizationRuleCollection rules = security.GetAccessRules(true, true, typeof(System.Security.Principal.NTAccount));
                foreach (FileSystemAccessRule rule in rules)
                {
                    listBox5.Items.Add($"Користувач: {rule.IdentityReference}");
                    listBox5.Items.Add($"Тип доступу: {rule.FileSystemRights}");
                    listBox5.Items.Add($"Дозвіл: {rule.AccessControlType}");
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
