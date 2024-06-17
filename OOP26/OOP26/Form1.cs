using Microsoft.Office.Interop.Word;
using System;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;


namespace OOP26
{
    public partial class Form1 : Form
    {
        string path = @"\myStr.docx";
        Word.Application word = new Word.Application();
        Word.Document doc = new Word.Document();

        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add(@"D:\VS PROJECTS\YARIK OOP PROJECTS\OOP26\OOP26\myStr1.docx");
            comboBox1.Items.Add(@"D:\VS PROJECTS\YARIK OOP PROJECTS\OOP26\OOP26\myStr2.docx");
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Object missingObj = System.Reflection.Missing.Value;
                Object templatePathObj = comboBox1.SelectedItem.ToString();

                doc = word.Documents.Add(ref templatePathObj, ref missingObj, ref missingObj, ref missingObj);
                doc.Activate();

                foreach (Word.FormField f in doc.FormFields)
                {
                    switch (f.Name)
                    {
                        case "ТекстовоеПоле1":
                            f.Range.Text = textBox1.Text;
                            break;
                        case "ТекстовоеПоле2":
                            f.Range.Text = textBox2.Text;
                            break;
                        case "ТекстовоеПоле3":
                            f.Range.Text = textBox3.Text;
                            break;
                        case "ТекстовоеПоле4":
                            f.Range.Text = textBox4.Text;
                            break;
                        case "ТекстовоеПоле5":
                            f.Range.Text = textBox5.Text;
                            break;
                        case "ТекстовоеПоле6":
                            f.Range.Text = textBox6.Text;
                            break;
                        case "ТекстовоеПоле7":
                            f.Range.Text = textBox7.Text;
                            break;
                        case "ТекстовоеПоле8":
                            f.Range.Text = textBox8.Text;
                            break;
                        case "ТекстовоеПоле9":
                            f.Range.Text = textBox9.Text;
                            break;
                        case "ТекстовоеПоле10":
                            f.Range.Text = textBox10.Text;
                            break;
                        case "ТекстовоеПоле11":
                            f.Range.Text = textBox11.Text;
                            break;
                        case "ТекстовоеПоле12":
                            f.Range.Text = textBox12.Text;
                            break;
                        case "ТекстовоеПоле13":
                            f.Range.Text = textBox13.Text;
                            break;
                        case "ТекстовоеПоле14":
                            f.Range.Text = textBox14.Text;
                            break;
                    }
                }

                Object savePath = @"D:\newDoc.docx";
                doc.SaveAs2(ref savePath);

                string findText = textBox15.Text;
                string replaceWith = textBox16.Text;
                bool found = false;

                foreach (Word.Range range in doc.StoryRanges)
                {
                    Word.Find find = range.Find;
                    find.Text = findText;
                    find.Replacement.Text = replaceWith;

                    if (find.Execute(Replace: WdReplace.wdReplaceAll))
                    {
                        found = true;
                    }
                }

                if (found)
                {
                    MessageBox.Show($"Текст '{findText}' було знайдено та змінено на '{replaceWith}'", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Текст '{findText}' не було знайдено", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                word.Visible = true;

            }
            catch (Exception) { }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (doc != null)
            {
                doc.Close(WdSaveOptions.wdDoNotSaveChanges);
                doc = null;
            }

            if (word != null)
            {
                word.Quit();
                word = null;
            }
        }
    }
}
