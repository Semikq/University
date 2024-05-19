using Microsoft.Win32;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace OOP22
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            cmbFontFamily.ItemsSource = Fonts.SystemFontFamilies.OrderBy(f => f.Source);
            cmbFontSize.ItemsSource = new List<double>() { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };
        }


        // == ВКЛАДКА ФАЙЛ ==
        private void Open_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "rich text format (*.rtf)|*.rtf";

            if (openDialog.ShowDialog() == true)
            {
                FileStream fileStream = new FileStream(openDialog.FileName, FileMode.Open);
                TextRange textRange = new TextRange(richTextBox.Document.ContentStart, richTextBox.Document.ContentEnd);
                textRange.Load(fileStream, DataFormats.Rtf);
            }
        }
        private void Save_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "RTF (*.rtf)|*.rtf";

            if (saveDialog.ShowDialog() == true)
            {
                FileStream fileStream = new FileStream(saveDialog.FileName, FileMode.Create);
                TextRange textRange = new TextRange(richTextBox.Document.ContentStart, richTextBox.Document.ContentEnd);
                textRange.Save(fileStream, DataFormats.Rtf);
            }
        }
        private void CloseThis_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }


        // == ВКЛАДКА РЕДАГУВАННЯ == 
        private void Copy_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            richTextBox.Copy();
        }
        private void Paste_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            richTextBox.Paste();
        }
        private void Cut_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            richTextBox.Cut();
        }
        private void SelectAll_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            richTextBox.SelectAll();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Images (*.png;*.jpeg;*.jpg)|*.png;*.jpeg;*.jpg";

            if (openFileDialog.ShowDialog() == true)
            {
                string imagePath = openFileDialog.FileName;
                BitmapImage bitmapImage = new BitmapImage(new Uri(imagePath));
                Image currentImage = new Image();
                currentImage.Source = bitmapImage;
                InlineUIContainer uiContainer = new InlineUIContainer(currentImage);

                if (richTextBox.Selection.IsEmpty)
                {
                    Paragraph paragraph = new Paragraph(uiContainer);
                    richTextBox.Document.Blocks.Add(paragraph);
                }
            }
        }


        // == ВКЛАДКА ФОРМАТУВАННЯ ТЕКСТУ ==
        private void cmbFontFamily_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cmbFontFamily.SelectedItem != null)
                richTextBox.Selection.ApplyPropertyValue(TextElement.FontFamilyProperty, cmbFontFamily.SelectedItem);
        }
        private void cmbFontSize_TextChanged(object sender, TextChangedEventArgs e)
        {
            richTextBox.Selection.ApplyPropertyValue(TextElement.FontSizeProperty, cmbFontSize.Text);
        }
        private void btnLeft_Click(object sender, RoutedEventArgs e)
        {
            richTextBox.Selection.ApplyPropertyValue(Block.TextAlignmentProperty, TextAlignment.Left);
        }
        private void btnCenter_Click(object sender, RoutedEventArgs e)
        {
            richTextBox.Selection.ApplyPropertyValue(Block.TextAlignmentProperty, TextAlignment.Center);
        }
        private void btnRight_Click(object sender, RoutedEventArgs e)
        {
            richTextBox.Selection.ApplyPropertyValue(Block.TextAlignmentProperty, TextAlignment.Right);
        }
        private void rtbEditor_SelectionChanged(object sender, RoutedEventArgs e)
        {
            object temp = richTextBox.Selection.GetPropertyValue(TextElement.FontWeightProperty);
            btnBold.IsChecked = (temp != DependencyProperty.UnsetValue) && (temp.Equals(FontWeights.Bold));

            temp = richTextBox.Selection.GetPropertyValue(TextElement.FontStyleProperty);
            btnItalic.IsChecked = (temp != DependencyProperty.UnsetValue) && (temp.Equals(FontStyles.Italic));

            temp = richTextBox.Selection.GetPropertyValue(Inline.TextDecorationsProperty);
            btnUnderline.IsChecked = (temp != DependencyProperty.UnsetValue) && (temp.Equals(TextDecorations.Underline));

            temp = richTextBox.Selection.GetPropertyValue(FontFamilyProperty);
            cmbFontFamily.SelectedItem = temp;

            temp = richTextBox.Selection.GetPropertyValue(FontSizeProperty);
            cmbFontSize.Text = temp.ToString();
        }


        // == ВКЛАДКА ЗМІН МОВИ ==
        private void Ukrainian_Click(object sender, RoutedEventArgs e)
        {
            File.Header = "Файл";
            Open.Header = "Відкрити";
            SaveAs.Header = "Зберегти як...";
            CloseThis.Header = "Закрити";

            Edit.Header = "Редагування";
            Copy.Header = "Копіювати";
            SelectAll.Header = "Вибрати все";
            Paste.Header = "Вставити";
            Cut.Header = "Вирізати";
            PasteImage.Header = "Вставити зобраення";

            Language.Header = "Мова";
            Ukrainian.Header = "Українська";
            English.Header = "Англійська";
        }
        private void English_Click(object sender, RoutedEventArgs e)
        {
            File.Header = "File";
            Open.Header = "Open";
            SaveAs.Header = "Save as...";
            CloseThis.Header = "Close";

            Edit.Header = "Edit";
            Copy.Header = "Copy";
            SelectAll.Header = "Select All";
            Paste.Header = "Paste";
            Cut.Header = "Cut";
            PasteImage.Header = "Paste image";

            Language.Header = "Language";
            Ukrainian.Header = "Ukrainian";
            English.Header = "English";
        }
    }
}