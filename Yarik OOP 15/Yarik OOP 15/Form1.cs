using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace Yarik_OOP_15
{
    public partial class Form1 : Form
    {
        private Point point1;
        private Point point2;

        private char[] days = new char[30];
        private int len = 0;

        public Form1()
        {
            InitializeComponent();
        }

        // TASK 1
        private void button1_Click(object sender, EventArgs e)
        {
            if (boxX.Text == "" || boxY.Text == "")
            {
                res1.ForeColor = Color.Red;
                res1.Text = "Не може бути пустого поля!";
                return;
            }

            try
            {
                double X = Convert.ToDouble(boxX.Text);
                double Y = Convert.ToDouble(boxY.Text);

                double result = Math.Pow(2, -X) - Math.Cos(X) + Math.Sin(2 * X * Y);

                res1.ForeColor = Color.Black;
                res1.Text = result.ToString();
            }
            catch (FormatException)
            {
                res1.ForeColor = Color.Red;
                res1.Text = "Невірно введена змінна!";
            }
        }

        // TASK 2
        private void button2_Click(object sender, EventArgs e)
        {
            if (A.Text == "" || B.Text == "" || C.Text == "" || rad.Text == "")
            {
                res2.ForeColor = Color.Red;
                res2.Text = "Не може бути пустого поля!";
                return;
            }

            try
            {
                double angleAConv = Convert.ToDouble(A.Text);
                double angleBConv = Convert.ToDouble(B.Text);
                double angleCConv = Convert.ToDouble(C.Text);
                double radius = Convert.ToDouble(rad.Text);

                double angleA = angleAConv * Math.PI / 180;
                double angleB = angleBConv * Math.PI / 180;
                double angleC = angleCConv * Math.PI / 180;

                double sideA = 2 * radius * Math.Sin(angleA);
                double sideB = 2 * radius * Math.Sin(angleB);
                double sideC = 2 * radius * Math.Sin(angleC);

                res2.ForeColor = Color.Black;
                res2.Text = $"A = {sideA}; \n" +
                    $"B = {sideB}; \n" +
                    $"C = {sideC};";
            }
            catch (FormatException)
            {
                res2.ForeColor = Color.Red;
                res2.Text = "Невірно введена змінна!";
            }
        }

        // TASK 3
        private void Task3AddPoint1_Click(object sender, EventArgs e)
        {
            if (pointX1.Text == "" || pointY1.Text == "")
            {
                labelPoint1.ForeColor = Color.Red;
                labelPoint1.Text = "Не може бути пустого поля!";
                return;
            }

            try
            {
                double X = Convert.ToDouble(pointX1.Text);
                double Y = Convert.ToDouble(pointY1.Text);
                point1 = new Point(X, Y);

                labelPoint1.ForeColor = Color.Black;
                labelPoint1.Text = $"Точка {point1} додана!";
            }
            catch (FormatException)
            {
                labelPoint1.ForeColor = Color.Red;
                labelPoint1.Text = "Невірно введена змінна!";
            }
        }
        private void Task3AddPoint2_Click(object sender, EventArgs e)
        {
            if (pointX2.Text == "" || pointY2.Text == "")
            {
                labelPoint2.ForeColor = Color.Red;
                labelPoint2.Text = "Не може бути пустого поля!";
                return;
            }

            try
            {
                double X = Convert.ToDouble(pointX2.Text);
                double Y = Convert.ToDouble(pointY2.Text);
                point2 = new Point(X, Y);

                labelPoint2.ForeColor = Color.Black;
                labelPoint2.Text = $"Точка {point2} додана!";
            }
            catch (FormatException)
            {
                labelPoint2.ForeColor = Color.Red;
                labelPoint2.Text = "Невірно введена змінна!";
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (pointMainX.Text == "" || pointMainY.Text == "")
            {
                labelMainPoint.ForeColor = Color.Red;
                labelMainPoint.Text = "Не може бути пустого поля!";
                return;
            }
            else if (point1 == null || point2 == null)
            {
                labelMainPoint.ForeColor = Color.Red;
                labelMainPoint.Text = "Додайте всі точки!";
                return;
            }

            try
            {
                double X = Convert.ToDouble(pointMainX.Text);
                double Y = Convert.ToDouble(pointMainY.Text);

                bool result = (X >= point1.X && X <= point2.X) && (Y <= point1.Y && Y >= point2.Y);

                labelMainPoint.ForeColor = Color.Black;
                labelMainPoint.Text = $"Точка A({X}, {Y}) перевірена!";
                res3.Text = $"{result}";
            }
            catch (FormatException)
            {
                labelMainPoint.ForeColor = Color.Red;
                labelMainPoint.Text = "Невірно введена змінна!";
            }
        }

        // TASK 4
        private void button4_Click(object sender, EventArgs e)
        {
            if (task4Box.Text == "")
            {
                res4.ForeColor = Color.Red;
                res4.Text = "Не може бути пустого поля!";
                return;
            }

            try
            {
                double X = Convert.ToDouble(task4Box.Text);

                double sinX = Math.Sin(X);
                double cosX = Math.Cos(X);
                double logX = Math.Log10(X);
                double[] sortedValues = { sinX, cosX, logX };
                Array.Sort(sortedValues);

                res4.ForeColor = Color.Black;
                res4.Text = string.Empty;
                foreach (var value in sortedValues)
                {
                    res4.Text += value.ToString() + "\n";
                }
            }
            catch (FormatException)
            {
                res4.ForeColor = Color.Red;
                res4.Text = "Невірно введена змінна!";
            }
        }

        // TASK 5
        private void button5_Click(object sender, EventArgs e)
        {
            if (Nbox.Text == "" || Kbox.Text == "")
            {
                res5.ForeColor = Color.Red;
                res5.Text = "Не може бути пустого поля!";
                return;
            }

            try
            {
                int n = Convert.ToInt32(Nbox.Text);
                int k = Convert.ToInt32(Kbox.Text);

                int temp = 0;
                for (int i = 0; i < Kbox.Text.Length; i++)
                {
                    temp += Convert.ToInt32(Kbox.Text[i].ToString());
                }

                res5.ForeColor = Color.Black;
                if (temp > n)
                    res5.Text = "n < summ";
                else if (temp == n)
                    res5.Text = "n == summ";
                else if (temp < n)
                    res5.Text = "n > summ";
            }
            catch (FormatException)
            {
                res5.ForeColor = Color.Red;
                res5.Text = "Невірно введена змінна!";
            }
        }

        // TASK 6
        // додати похмурий день в список
        private void pDaybutton_Click(object sender, EventArgs e)
        {
            if (len != 30)
            {
                days[len++] = 'p';
                PrintDays();
            }
        }
        // додати сонячний день в список
        private void sDayButton_Click(object sender, EventArgs e)
        {
            if (len != 30)
            {
                days[len++] = 's';
                PrintDays();
            }
        }
        // очистити останній день
        private void clearButton_Click(object sender, EventArgs e)
        {
            if (len != 0)
            {
                days[--len] = ' ';
                PrintDays();
            }
        }
        // рандомна генерація 30 днів
        private void genDayButton_Click(object sender, EventArgs e)
        {
            len = 0;

            var rand = new Random();
            char[] chars = { 's', 'p' };

            for (int i = 0; i < days.Length; i++)
            {
                int randomValue = rand.Next(chars.Length);
                char randomChar = chars[randomValue];

                days[len++] = randomChar;
            }
            PrintDays();
        }
        // вивід днів
        private void PrintDays()
        {
            daysLabel.Text = "";

            for (int i = 0; i < len; i++)
            {
                daysLabel.Text += $"{days[i]}, ";
            }
        }
        // вивід результатів
        private void button6_Click(object sender, EventArgs e)
        {
            int snailPosition = 100;

            if (len != 30)
            {
                res6.ForeColor = Color.Red;
                res6.Text = "Необхідно мати 30 днів!";
                return;
            }

            for (int i = 0; i < days.Length; i++)
            {
                if (days[i] == 's' && snailPosition < 199)
                {
                    snailPosition += 2;
                }
                else if (days[i] == 'p' && snailPosition != 0)
                {
                    snailPosition -= 1;
                }
            }

            res6.ForeColor = Color.Black;
            res6.Text = $"{snailPosition} см від землі";
        }

        // TASK 7
        private void button7_Click(object sender, EventArgs e)
        {
            const string numbers = "0123456789";

            if (stringBox.Text == "")
            {
                res7.ForeColor = Color.Red;
                res7.Text = "Необхідно ввести інформацію в поле!";
                return;
            }

            string temp = "";
            int count = 0;
            for (int i = 0; i < stringBox.Text.Length; i++)
            {
                if (numbers.Contains(stringBox.Text[i]))
                {
                    temp += stringBox.Text[i];

                    if (temp.Length > count)
                    {
                        count = temp.Length;
                    }
                    continue;
                }
                
                temp = "";
            }

            res7.ForeColor = Color.Black;
            res7.Text = $"Найбільша довжина: {count}";
        }
    }

    // КЛАС POINT ДЛЯ ЗАВДАННЯ 3
    public class Point
    {
        public readonly double X;
        public readonly double Y;

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }
}
