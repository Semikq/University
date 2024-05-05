using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Yaroslav_OOP21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SaveProject_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Filter = "RTF format(*.rtf)|*.rtf";
            if (fileDialog.ShowDialog() == DialogResult.Cancel)
                return;

            string FileName = fileDialog.FileName;
            File.WriteAllText(FileName, richTextBox1.Text);
        }

        private void OpenProject_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            if (fileDialog.ShowDialog() == DialogResult.Cancel)
                return;

            string FileName = fileDialog.FileName;
            string fileText = File.ReadAllText(FileName);
            richTextBox1.Text = fileText;
        }
        private void CloseApplication_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AlignToLeft_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void AlignToRight_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void AlignToCenter_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void ApplyFonts_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            fontDialog.ShowDialog();
            richTextBox1.Font = fontDialog.Font;
        }

        private void CopyText_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void IncertText_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void SelectAllText_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void IncsertPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Images(*.jpg; *.jpeg; *.png; *.gif; *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;

                Image img = Image.FromFile(imagePath);
                Clipboard.SetImage(img);
                richTextBox1.Paste();
            }
        }

        private void CreateNewForm_Click(object sender, EventArgs e)
        {
            Form1 newForm = new Form1();
            newForm.Show();
        }
    }
}
