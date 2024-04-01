using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YarikOOP18
{
    public partial class Form1 : Form
    {
        Task1 arr1 = new Task1();
        Task2 arr2 = new Task2(6, 6);

        public Form1()
        {
            InitializeComponent();
        }

        // додавання елемента в масив
        private void oneAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int value = int.Parse(txtValue.Text);

                arr1.PushBack(value);
                txtValue.Text = string.Empty;
            }
            catch (FormatException) { }
        }

        // максимальний за модулем елемент
        private void oneMax_Click(object sender, EventArgs e)
        {
            Console.WriteLine($"Максимальний елемент за модулем: {arr1.GetMaxValue()}");
        }

        // повернення суми між першим та другим додатніми елементами
        private void oneSum_Click(object sender, EventArgs e)
        {
            Console.WriteLine($"Cумa елементiв масиву: {arr1.SumPositive()}");
        }

        // закидування нулів в кінець
        private void oneZero_Click(object sender, EventArgs e)
        {
            arr1.Sort();
        }

        // вивід масиву
        private void onePrint_Click(object sender, EventArgs e)
        {
            arr1.Print();
        }


        // автоматичне заповнення двовимірного масиву (числа від 0 до 9)
        private void twoGenerateArray_Click(object sender, EventArgs e)
        {
            arr2.GenerateArray();
        }

        // сума двох елементів на другому рядку
        private void twoSum_Click(object sender, EventArgs e)
        {
            int result = arr2.SumTwoRandomValues(out int value1, out int value2);

            Console.WriteLine($"Сума елементiв {value1} та {value2} на другому рядку : {result}");
        }

        // добуток двох елементів на п'ятому стовпці
        private void twoMultiply_Click(object sender, EventArgs e)
        {
            int result = arr2.MulTwoRandomValues(out int value1, out int value2);

            Console.WriteLine($"Добуток елементiв {value1} та {value2} на п'ятому стовпцi : {result}");
        }

        // вивід масиву
        private void twoPrint_Click(object sender, EventArgs e)
        {
            arr2.Print();
        }
    }
}
