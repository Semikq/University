namespace YarikOOP18
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.onePrint = new System.Windows.Forms.Button();
            this.oneZero = new System.Windows.Forms.Button();
            this.oneSum = new System.Windows.Forms.Button();
            this.oneMax = new System.Windows.Forms.Button();
            this.oneAdd = new System.Windows.Forms.Button();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.twoGenerateArray = new System.Windows.Forms.Button();
            this.twoSum = new System.Windows.Forms.Button();
            this.twoMultiply = new System.Windows.Forms.Button();
            this.twoPrint = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(318, 349);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.onePrint);
            this.tabPage1.Controls.Add(this.oneZero);
            this.tabPage1.Controls.Add(this.oneSum);
            this.tabPage1.Controls.Add(this.oneMax);
            this.tabPage1.Controls.Add(this.oneAdd);
            this.tabPage1.Controls.Add(this.txtValue);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(310, 316);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Task 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.twoPrint);
            this.tabPage2.Controls.Add(this.twoMultiply);
            this.tabPage2.Controls.Add(this.twoSum);
            this.tabPage2.Controls.Add(this.twoGenerateArray);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(310, 316);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Task 2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // onePrint
            // 
            this.onePrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.onePrint.Location = new System.Drawing.Point(62, 234);
            this.onePrint.Name = "onePrint";
            this.onePrint.Size = new System.Drawing.Size(178, 26);
            this.onePrint.TabIndex = 11;
            this.onePrint.Text = "Вивід масиву";
            this.onePrint.UseVisualStyleBackColor = true;
            this.onePrint.Click += new System.EventHandler(this.onePrint_Click);
            // 
            // oneZero
            // 
            this.oneZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oneZero.Location = new System.Drawing.Point(62, 202);
            this.oneZero.Name = "oneZero";
            this.oneZero.Size = new System.Drawing.Size(178, 26);
            this.oneZero.TabIndex = 10;
            this.oneZero.Text = "Закидування нулів";
            this.oneZero.UseVisualStyleBackColor = true;
            this.oneZero.Click += new System.EventHandler(this.oneZero_Click);
            // 
            // oneSum
            // 
            this.oneSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oneSum.Location = new System.Drawing.Point(62, 170);
            this.oneSum.Name = "oneSum";
            this.oneSum.Size = new System.Drawing.Size(178, 26);
            this.oneSum.TabIndex = 9;
            this.oneSum.Text = "Сума елементів";
            this.oneSum.UseVisualStyleBackColor = true;
            this.oneSum.Click += new System.EventHandler(this.oneSum_Click);
            // 
            // oneMax
            // 
            this.oneMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oneMax.Location = new System.Drawing.Point(62, 138);
            this.oneMax.Name = "oneMax";
            this.oneMax.Size = new System.Drawing.Size(178, 26);
            this.oneMax.TabIndex = 8;
            this.oneMax.Text = "Макс елемент";
            this.oneMax.UseVisualStyleBackColor = true;
            this.oneMax.Click += new System.EventHandler(this.oneMax_Click);
            // 
            // oneAdd
            // 
            this.oneAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oneAdd.Location = new System.Drawing.Point(62, 80);
            this.oneAdd.Name = "oneAdd";
            this.oneAdd.Size = new System.Drawing.Size(178, 26);
            this.oneAdd.TabIndex = 7;
            this.oneAdd.Text = "Додати елемент";
            this.oneAdd.UseVisualStyleBackColor = true;
            this.oneAdd.Click += new System.EventHandler(this.oneAdd_Click);
            // 
            // txtValue
            // 
            this.txtValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtValue.Location = new System.Drawing.Point(62, 48);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(178, 26);
            this.txtValue.TabIndex = 6;
            // 
            // twoGenerateArray
            // 
            this.twoGenerateArray.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.twoGenerateArray.Location = new System.Drawing.Point(61, 88);
            this.twoGenerateArray.Name = "twoGenerateArray";
            this.twoGenerateArray.Size = new System.Drawing.Size(178, 26);
            this.twoGenerateArray.TabIndex = 8;
            this.twoGenerateArray.Text = "Створити масив";
            this.twoGenerateArray.UseVisualStyleBackColor = true;
            this.twoGenerateArray.Click += new System.EventHandler(this.twoGenerateArray_Click);
            // 
            // twoSum
            // 
            this.twoSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.twoSum.Location = new System.Drawing.Point(61, 143);
            this.twoSum.Name = "twoSum";
            this.twoSum.Size = new System.Drawing.Size(178, 26);
            this.twoSum.TabIndex = 9;
            this.twoSum.Text = "Сума на 2 рядку";
            this.twoSum.UseVisualStyleBackColor = true;
            this.twoSum.Click += new System.EventHandler(this.twoSum_Click);
            // 
            // twoMultiply
            // 
            this.twoMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.twoMultiply.Location = new System.Drawing.Point(61, 175);
            this.twoMultiply.Name = "twoMultiply";
            this.twoMultiply.Size = new System.Drawing.Size(178, 26);
            this.twoMultiply.TabIndex = 10;
            this.twoMultiply.Text = "Добуток на 5 рядку";
            this.twoMultiply.UseVisualStyleBackColor = true;
            this.twoMultiply.Click += new System.EventHandler(this.twoMultiply_Click);
            // 
            // twoPrint
            // 
            this.twoPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.twoPrint.Location = new System.Drawing.Point(61, 207);
            this.twoPrint.Name = "twoPrint";
            this.twoPrint.Size = new System.Drawing.Size(178, 26);
            this.twoPrint.TabIndex = 11;
            this.twoPrint.Text = "Вивід масиву";
            this.twoPrint.UseVisualStyleBackColor = true;
            this.twoPrint.Click += new System.EventHandler(this.twoPrint_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(342, 373);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Yaroslav oop18";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button onePrint;
        private System.Windows.Forms.Button oneZero;
        private System.Windows.Forms.Button oneSum;
        private System.Windows.Forms.Button oneMax;
        private System.Windows.Forms.Button oneAdd;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Button twoMultiply;
        private System.Windows.Forms.Button twoSum;
        private System.Windows.Forms.Button twoGenerateArray;
        private System.Windows.Forms.Button twoPrint;
    }
}

