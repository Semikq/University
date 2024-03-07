using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yaroslav_OOP16
{
    public partial class Form1 : Form
    {
        // динамічні структури даних (списки)
        List<Complex> ArrayA = new List<Complex>();
        List<double> ArrayC = new List<double>();


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int X = Convert.ToInt32(xBox.Text);
                int Y = Convert.ToInt32(yBox.Text);

                ArrayA.Add(new Complex(X, Y));

                labelRes1.Text = string.Empty;
                for (int i = 0; i < ArrayA.Count; i++)
                {
                    labelRes1.Text += $"{ArrayA[i]}; ";
                }
            }
            catch (FormatException)
            {
                labelInfo1.Text = "Невірний формат змінних! (масив А)";
            }
            catch (ArgumentException)
            {
                labelInfo1.Text = "Y не може дорівнювати нулю! (масив А)";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            labelRes2.Text = string.Empty;
            for (int i = 0; i < ArrayA.Count; i++)
            {
                double temp;
                // якщо перша ітерація
                if (i == 0)
                {
                    if (ArrayA.Count == 1)
                    {
                        temp = ArrayA[i].Abs();
                    }
                    else
                    {
                        temp = (ArrayA[i] + ArrayA[i + 1]).Abs();
                    }
                }
                // якщо остання ітерація
                else if (i + 1 == ArrayA.Count)
                {
                    temp = (ArrayA[i - 1] + ArrayA[i]).Abs();
                }
                else
                {
                    temp = (ArrayA[i - 1] + ArrayA[i] + ArrayA[i + 1]).Abs();
                }
                ArrayC.Add(temp);

                labelRes2.Text += $"{ArrayC[i]}; ";
            }
        }
    }
}
