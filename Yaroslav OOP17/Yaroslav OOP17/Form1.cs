using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yaroslav_OOP17
{
    public partial class Form1 : Form
    {
        private Money firstMoney;
        private Money secondMoney;

        private Complex firstComplex;
        private Complex secondComplex;

        public Form1() { InitializeComponent(); }


        // == REALIIZATION ClASS MONEY == 
        // додає першу суму грошей в список
        private void AddFirst_Click(object sender, EventArgs e)
        {
            try
            {
                firstMoney = new Money(Convert.ToInt32(firstHrn.Text), Convert.ToInt32(firstKop.Text));

                one.ForeColor = Color.Green;
                one.Text = "+";
            }
            catch (FormatException)
            {
                one.ForeColor = Color.Red;
                result1.Text = "Format Exception (FIRST)";
            }
            catch (ArgumentException)
            {
                one.ForeColor = Color.Red;
                result1.Text = "Argument Exception (FIRST)";
            }
        }
        // додає другу суму грошей в список
        private void AddSecond_Click(object sender, EventArgs e)
        {
            try
            {
                secondMoney = new Money(Convert.ToInt32(secondHrn.Text), Convert.ToInt32(secondKop.Text));

                two.ForeColor = Color.Green;
                two.Text = "+";
            }
            catch (FormatException)
            {
                two.ForeColor = Color.Red;
                result1.Text = "Format Exception (SECOND)";
            }
            catch (ArgumentException)
            {
                two.ForeColor = Color.Red;
                result1.Text = "Argument Exception (SECOND)";
            }
        }
        // додавання двох сум грошей
        private void SumMoney_Click(object sender, EventArgs e)
        {
            try
            {
                var result = (Money)firstMoney.Add(secondMoney);
                result1.Text = result.ToString();
            }
            catch (NullReferenceException)
            {
                result1.Text = "Null Reference Exception (ADD)";
            }
        }
        // віднімання двох сум грошей
        private void SubMoney_Click(object sender, EventArgs e)
        {
            try
            {
                var result = (Money)firstMoney.Sub(secondMoney);
                result1.Text = result.ToString();
            }
            catch (NullReferenceException)
            {
                result1.Text = "Null Reference Exception (SUB)";
            }
            catch (ArgumentException)
            {
                result1.Text = "Argument Exception (RESULT)";
            }
        }


        // == REALIIZATION ClASS COMPLEX == 
        // Додає перше комплексне число у список
        private void AddFirstComplex_Click(object sender, EventArgs e)
        {
            try
            {
                firstComplex = new Complex(Convert.ToInt32(firstX.Text), Convert.ToInt32(firstY.Text));

                one2.ForeColor = Color.Green;
                one2.Text = "+";
            }
            catch (ArgumentException)
            {
                one2.ForeColor = Color.Red;
                result2.Text = "Argument Exception (FIRST)";
            }
            catch (FormatException)
            {
                one2.ForeColor = Color.Red;
                result2.Text = "Format Exception (FIRST)";
            }
        }
        // додає друге комплексне число у список
        private void AddSecondComplex_Click(object sender, EventArgs e)
        {
            try
            {
                secondComplex = new Complex(Convert.ToInt32(secondX.Text), Convert.ToInt32(secondY.Text));

                two2.ForeColor = Color.Green;
                two2.Text = "+";
            }
            catch (ArgumentException)
            {
                two2.ForeColor = Color.Red;
                result2.Text = "Argument Exception (FIRST)";
            }
            catch (FormatException)
            {
                two2.ForeColor = Color.Red;
                result2.Text = "Format Exception (FIRST)";
            }
        }
        // додавання двох комплексних чисел
        private void SumComplex_Click(object sender, EventArgs e)
        {
            try
            {
                var result = (Complex)firstComplex.Add(secondComplex);
                result2.Text = result.ToString();
            }
            catch (NullReferenceException)
            {
                result2.Text = "Null Reference Exception (ADD)";
            }
        }
        // віднімання двох комплексних числе
        private void SubComplex_Click(object sender, EventArgs e)
        {
            try
            {
                var result = (Complex)firstComplex.Sub(secondComplex);
                result2.Text = result.ToString();
            }
            catch (NullReferenceException)
            {
                result2.Text = "Null Reference Exception (ADD)";
            }
            catch (ArgumentException)
            {
                result2.Text = "Argument Exception (RESULT)";
            }
        }
    }
}
