using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YarikOOP19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string result = ConvertString(textBox1.Text);
            resultLabel.Text = result;
        }

        private string ConvertString(string str)
        {
            string result = string.Empty;
            for (int i = 0; i < str.Length; i++)
            {
                if (i == 0)
                {
                    result += str[0];
                    continue;
                }
                if (str[i] == str[i - 1])
                    continue;

                result += str[i];
            }
            return result;
        }
    }
}
