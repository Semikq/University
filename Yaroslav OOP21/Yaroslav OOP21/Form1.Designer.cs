namespace Yaroslav_OOP21
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveProject = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenProject = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.CloseApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.шрифтToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AlignToLeft = new System.Windows.Forms.ToolStripMenuItem();
            this.AlignToRight = new System.Windows.Forms.ToolStripMenuItem();
            this.AlignToCenter = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ApplyFonts = new System.Windows.Forms.ToolStripMenuItem();
            this.текстовеПолеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyText = new System.Windows.Forms.ToolStripMenuItem();
            this.IncertText = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectAllText = new System.Windows.Forms.ToolStripMenuItem();
            this.IncsertPicture = new System.Windows.Forms.ToolStripMenuItem();
            this.іншеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateNewForm = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(0, 29);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(563, 270);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.шрифтToolStripMenuItem,
            this.текстовеПолеToolStripMenuItem,
            this.іншеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(563, 29);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveProject,
            this.OpenProject,
            this.toolStripSeparator2,
            this.CloseApplication});
            this.файлToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 25);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // SaveProject
            // 
            this.SaveProject.Name = "SaveProject";
            this.SaveProject.Size = new System.Drawing.Size(180, 26);
            this.SaveProject.Text = "Зберегти";
            this.SaveProject.Click += new System.EventHandler(this.SaveProject_Click);
            // 
            // OpenProject
            // 
            this.OpenProject.Name = "OpenProject";
            this.OpenProject.Size = new System.Drawing.Size(180, 26);
            this.OpenProject.Text = "Відкрити";
            this.OpenProject.Click += new System.EventHandler(this.OpenProject_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // CloseApplication
            // 
            this.CloseApplication.Name = "CloseApplication";
            this.CloseApplication.Size = new System.Drawing.Size(180, 26);
            this.CloseApplication.Text = "Закрити";
            this.CloseApplication.Click += new System.EventHandler(this.CloseApplication_Click);
            // 
            // шрифтToolStripMenuItem
            // 
            this.шрифтToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AlignToLeft,
            this.AlignToRight,
            this.AlignToCenter,
            this.toolStripSeparator1,
            this.ApplyFonts});
            this.шрифтToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.шрифтToolStripMenuItem.Name = "шрифтToolStripMenuItem";
            this.шрифтToolStripMenuItem.Size = new System.Drawing.Size(73, 25);
            this.шрифтToolStripMenuItem.Text = "Шрифт";
            // 
            // AlignToLeft
            // 
            this.AlignToLeft.Name = "AlignToLeft";
            this.AlignToLeft.Size = new System.Drawing.Size(229, 26);
            this.AlignToLeft.Text = "Вирівняти зліва";
            this.AlignToLeft.Click += new System.EventHandler(this.AlignToLeft_Click);
            // 
            // AlignToRight
            // 
            this.AlignToRight.Name = "AlignToRight";
            this.AlignToRight.Size = new System.Drawing.Size(229, 26);
            this.AlignToRight.Text = "Вирівняти зправа";
            this.AlignToRight.Click += new System.EventHandler(this.AlignToRight_Click);
            // 
            // AlignToCenter
            // 
            this.AlignToCenter.Name = "AlignToCenter";
            this.AlignToCenter.Size = new System.Drawing.Size(229, 26);
            this.AlignToCenter.Text = "Вирівняти по центру";
            this.AlignToCenter.Click += new System.EventHandler(this.AlignToCenter_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(226, 6);
            // 
            // ApplyFonts
            // 
            this.ApplyFonts.Name = "ApplyFonts";
            this.ApplyFonts.Size = new System.Drawing.Size(229, 26);
            this.ApplyFonts.Text = "Шрифти";
            this.ApplyFonts.Click += new System.EventHandler(this.ApplyFonts_Click);
            // 
            // текстовеПолеToolStripMenuItem
            // 
            this.текстовеПолеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CopyText,
            this.IncertText,
            this.SelectAllText,
            this.IncsertPicture});
            this.текстовеПолеToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.текстовеПолеToolStripMenuItem.Name = "текстовеПолеToolStripMenuItem";
            this.текстовеПолеToolStripMenuItem.Size = new System.Drawing.Size(123, 25);
            this.текстовеПолеToolStripMenuItem.Text = "Текстове поле";
            // 
            // CopyText
            // 
            this.CopyText.Name = "CopyText";
            this.CopyText.Size = new System.Drawing.Size(220, 26);
            this.CopyText.Text = "Копіювати текст";
            this.CopyText.Click += new System.EventHandler(this.CopyText_Click);
            // 
            // IncertText
            // 
            this.IncertText.Name = "IncertText";
            this.IncertText.Size = new System.Drawing.Size(220, 26);
            this.IncertText.Text = "Вставити текст";
            this.IncertText.Click += new System.EventHandler(this.IncertText_Click);
            // 
            // SelectAllText
            // 
            this.SelectAllText.Name = "SelectAllText";
            this.SelectAllText.Size = new System.Drawing.Size(220, 26);
            this.SelectAllText.Text = "Виділити весь текст";
            this.SelectAllText.Click += new System.EventHandler(this.SelectAllText_Click);
            // 
            // IncsertPicture
            // 
            this.IncsertPicture.Name = "IncsertPicture";
            this.IncsertPicture.Size = new System.Drawing.Size(220, 26);
            this.IncsertPicture.Text = "Вставити картинку";
            this.IncsertPicture.Click += new System.EventHandler(this.IncsertPicture_Click);
            // 
            // іншеToolStripMenuItem
            // 
            this.іншеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateNewForm});
            this.іншеToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.іншеToolStripMenuItem.Name = "іншеToolStripMenuItem";
            this.іншеToolStripMenuItem.Size = new System.Drawing.Size(56, 25);
            this.іншеToolStripMenuItem.Text = "Інше";
            // 
            // CreateNewForm
            // 
            this.CreateNewForm.Name = "CreateNewForm";
            this.CreateNewForm.Size = new System.Drawing.Size(238, 26);
            this.CreateNewForm.Text = "Створити нову форму";
            this.CreateNewForm.Click += new System.EventHandler(this.CreateNewForm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 299);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "OOP21 Плаксюк Ярослав";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem шрифтToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveProject;
        private System.Windows.Forms.ToolStripMenuItem OpenProject;
        private System.Windows.Forms.ToolStripMenuItem AlignToLeft;
        private System.Windows.Forms.ToolStripMenuItem AlignToRight;
        private System.Windows.Forms.ToolStripMenuItem AlignToCenter;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ApplyFonts;
        private System.Windows.Forms.ToolStripMenuItem текстовеПолеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CopyText;
        private System.Windows.Forms.ToolStripMenuItem IncertText;
        private System.Windows.Forms.ToolStripMenuItem SelectAllText;
        private System.Windows.Forms.ToolStripMenuItem IncsertPicture;
        private System.Windows.Forms.ToolStripMenuItem іншеToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem CloseApplication;
        private System.Windows.Forms.ToolStripMenuItem CreateNewForm;
    }
}

