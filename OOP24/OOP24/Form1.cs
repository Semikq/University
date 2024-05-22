using System;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Ionic.Zip;

namespace OOP24
{
    public partial class Form1 : Form
    {
        private Thread thread1;
        private Thread thread2;
        private Thread thread3;


        public Form1()
        {
            InitializeComponent();

            thread1 = new Thread(new ThreadStart(Task1));
            thread2 = new Thread(new ThreadStart(Task2));
            thread3 = new Thread(new ThreadStart(Task3));
        }

        private void AsyncTime(Label label)
        {
            label.Text = "3";
            Thread.Sleep(1000);

            label.Text = "2";
            Thread.Sleep(1000);

            label.Text = "1";
            Thread.Sleep(1000);
        }


        private void Task1()
        {
            SKIPJACK ecryptedWord = new SKIPJACK(textBox1.Text);

            AsyncTime(time1);
            label1.Text = ecryptedWord.ToString();
        }

        private void Task2()
        {
            Snefru snefru = new Snefru(textBox2.Text);

            AsyncTime(time2);
            label2.Text = snefru.ToString();
        }

        private void Task3()
        {
            string directoryToZip = @"C:"; // шлях до своєї дерикторії
            string zipFilePath = @"C:\file.zip"; // шлях до зіп файлу

            string password = textBox3.Text; // Пароль

            using (ZipFile zip = new ZipFile())
            {
                zip.Password = password;
                zip.AddDirectory(directoryToZip);
                zip.Save(zipFilePath);
            }

            AsyncTime(time3);
            label3.Text = "Архівація завершена!";
        }


        private void button4_Click(object sender, EventArgs e)
        {
            thread1.Start();
            thread2.Start();
            thread3.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            thread1.Start();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            thread2.Start();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            thread3.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            thread1.Suspend();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            thread2.Suspend();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            thread3.Suspend();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            thread1.Suspend();
            thread2.Suspend();
            thread3.Suspend();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            thread1.Abort();
            thread2.Abort();
            thread3.Abort();
        }
    }
}
