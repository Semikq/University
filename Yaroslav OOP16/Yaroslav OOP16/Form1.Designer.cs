namespace Yaroslav_OOP16
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.xBox = new System.Windows.Forms.TextBox();
            this.yBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelInfo1 = new System.Windows.Forms.Label();
            this.labelInfo2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.labelRes1 = new System.Windows.Forms.Label();
            this.labelRes2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(244, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(617, 247);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // xBox
            // 
            this.xBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xBox.Location = new System.Drawing.Point(68, 321);
            this.xBox.Name = "xBox";
            this.xBox.Size = new System.Drawing.Size(96, 38);
            this.xBox.TabIndex = 3;
            // 
            // yBox
            // 
            this.yBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yBox.Location = new System.Drawing.Point(189, 321);
            this.yBox.Name = "yBox";
            this.yBox.Size = new System.Drawing.Size(96, 38);
            this.yBox.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(305, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 38);
            this.button1.TabIndex = 5;
            this.button1.Text = "Додати";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(104, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(224, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 31);
            this.label2.TabIndex = 7;
            this.label2.Text = "Y";
            // 
            // labelInfo1
            // 
            this.labelInfo1.AutoSize = true;
            this.labelInfo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfo1.Location = new System.Drawing.Point(26, 380);
            this.labelInfo1.Name = "labelInfo1";
            this.labelInfo1.Size = new System.Drawing.Size(485, 31);
            this.labelInfo1.TabIndex = 8;
            this.labelInfo1.Text = "Список комплексних чисел (масив А)";
            // 
            // labelInfo2
            // 
            this.labelInfo2.AutoSize = true;
            this.labelInfo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfo2.Location = new System.Drawing.Point(607, 380);
            this.labelInfo2.Name = "labelInfo2";
            this.labelInfo2.Size = new System.Drawing.Size(396, 31);
            this.labelInfo2.TabIndex = 9;
            this.labelInfo2.Text = "Список модулів сум (масив С)";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(685, 321);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(242, 38);
            this.button2.TabIndex = 10;
            this.button2.Text = "Обрахувати масив С";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelRes1
            // 
            this.labelRes1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.labelRes1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelRes1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRes1.Location = new System.Drawing.Point(12, 411);
            this.labelRes1.Name = "labelRes1";
            this.labelRes1.Size = new System.Drawing.Size(518, 271);
            this.labelRes1.TabIndex = 11;
            // 
            // labelRes2
            // 
            this.labelRes2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.labelRes2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelRes2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRes2.Location = new System.Drawing.Point(536, 411);
            this.labelRes2.Name = "labelRes2";
            this.labelRes2.Size = new System.Drawing.Size(517, 271);
            this.labelRes2.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1065, 691);
            this.Controls.Add(this.labelRes2);
            this.Controls.Add(this.labelRes1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.labelInfo2);
            this.Controls.Add(this.labelInfo1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.yBox);
            this.Controls.Add(this.xBox);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "oop16";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox xBox;
        private System.Windows.Forms.TextBox yBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelInfo1;
        private System.Windows.Forms.Label labelInfo2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelRes1;
        private System.Windows.Forms.Label labelRes2;
    }
}

