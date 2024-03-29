using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YaroslavOOP20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            try
            {
                int year = int.Parse(txtYear.Text);
                int month = int.Parse(txtMonth.Text);
                int day = int.Parse(txtDay.Text);

                Date date = new Date(year, month, day);
                int dayOfWeek = Date.DayOfWeek(date);

                labelResult.Text = dayOfWeek.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Помилка в рядках набору!", "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
