namespace lab29
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
            this.LoginButton = new System.Windows.Forms.Button();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.UserNameBox = new System.Windows.Forms.TextBox();
            this.SendButton = new System.Windows.Forms.Button();
            this.MessageTextBox = new System.Windows.Forms.RichTextBox();
            this.MessagesBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LoginButton
            // 
            this.LoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginButton.Location = new System.Drawing.Point(17, 266);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(84, 26);
            this.LoginButton.TabIndex = 0;
            this.LoginButton.Text = "Вхід";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // LogoutButton
            // 
            this.LogoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogoutButton.Location = new System.Drawing.Point(338, 266);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(84, 26);
            this.LogoutButton.TabIndex = 1;
            this.LogoutButton.Text = "Вихід";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // UserNameBox
            // 
            this.UserNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserNameBox.Location = new System.Drawing.Point(107, 266);
            this.UserNameBox.Name = "UserNameBox";
            this.UserNameBox.Size = new System.Drawing.Size(225, 26);
            this.UserNameBox.TabIndex = 3;
            // 
            // SendButton
            // 
            this.SendButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SendButton.Location = new System.Drawing.Point(301, 33);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(121, 26);
            this.SendButton.TabIndex = 4;
            this.SendButton.Text = "Відправити";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // MessageTextBox
            // 
            this.MessageTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MessageTextBox.Location = new System.Drawing.Point(17, 65);
            this.MessageTextBox.Name = "MessageTextBox";
            this.MessageTextBox.Size = new System.Drawing.Size(405, 195);
            this.MessageTextBox.TabIndex = 7;
            this.MessageTextBox.Text = "";
            // 
            // MessagesBox
            // 
            this.MessagesBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MessagesBox.Location = new System.Drawing.Point(17, 33);
            this.MessagesBox.Name = "MessagesBox";
            this.MessagesBox.Size = new System.Drawing.Size(273, 26);
            this.MessagesBox.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(450, 324);
            this.Controls.Add(this.MessagesBox);
            this.Controls.Add(this.MessageTextBox);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.UserNameBox);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.LoginButton);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Плаксюк Ярослав ООП29";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.TextBox UserNameBox;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.RichTextBox MessageTextBox;
        private System.Windows.Forms.TextBox MessagesBox;
    }
}

