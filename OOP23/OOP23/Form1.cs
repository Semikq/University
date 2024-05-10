using System;
using System.Drawing;
using System.Windows.Forms;

namespace OOP23
{
    public partial class Form1 : Form
    {
        private Graphics graphics;
        private int offsetX;
        private int offsetY;
        private int ScaleGraphics;


        public Form1()
        {
            InitializeComponent();

            graphics = pictureBox1.CreateGraphics();
            offsetX = pictureBox1.Width / 2;
            offsetY = pictureBox1.Height / 2;
            ScaleGraphics = 25;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            graphics.Clear(pictureBox1.BackColor);

            ShowAxis();
            ShowName();
            ShowValues();

            DrawX();
            DrawY();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.ShowDialog();
            pictureBox1.BackColor = colorDialog.Color;
        }


        private void ShowAxis()
        {
            Point firstX = new Point(0, offsetY);
            Point secondX = new Point(offsetX * 2, pictureBox1.Height / 2);

            Point firstY = new Point(offsetX, 0);
            Point secondY = new Point(offsetX, offsetY * 2);

            graphics.DrawLine(new Pen(Color.Black, 1f), firstX, secondX);
            graphics.DrawLine(new Pen(Color.Black, 1f), firstY, secondY);
        }

        private void ShowName()
        {
            Font font = new Font("Times new Roman", 14, FontStyle.Bold);
            SolidBrush brush = new SolidBrush(Color.Black);

            Point x = new Point(offsetX * 2 - ScaleGraphics, offsetY - ScaleGraphics);
            Point y = new Point(offsetX, 0);
            graphics.DrawString("x", font, brush, x);
            graphics.DrawString("y", font, brush, y);
        }

        private void ShowValues()
        {
            Font font = new Font("Arial", 10);
            SolidBrush brush = new SolidBrush(Color.Black);

            int xValue = -(offsetX) / ScaleGraphics;
            for (int pixel = 0; xValue < offsetX * 2 / ScaleGraphics; pixel += ScaleGraphics, xValue++)
            {
                Point point = new Point(pixel, offsetY);
                graphics.DrawString(xValue.ToString(), font, brush, point);
            }

            int yValue = -(offsetY) / ScaleGraphics;
            for (int pixel = 0; yValue < offsetY * 2 / ScaleGraphics; pixel += ScaleGraphics, yValue++)
            {
                Point point = new Point(offsetX, pixel);
                graphics.DrawString((-yValue).ToString(), font, brush, point);
            }
        }

        private void DrawX()
        {
            Point[] points = new Point[1000];

            for (int y = 0; y < points.Length; y++)
            {
                int x = (int)(y * y * Math.Sin((double)y / ScaleGraphics));
                points[y] = new Point(x + offsetX, y);
            }

            graphics.DrawLines(new Pen(Color.Red, 3f), points);
        }

        private void DrawY()
        {
            Point[] points = new Point[1000];

            for (int x = 0; x < points.Length; x++)
            {
                int y = (int)(x * Math.Pow(Math.Cos((double)x / ScaleGraphics), 2));
                points[x] = new Point(x, y + offsetY);
            }

            graphics.DrawLines(new Pen(Color.Blue, 3f), points);
        }
    }
}
