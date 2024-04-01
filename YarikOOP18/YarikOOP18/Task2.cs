using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YarikOOP18
{
    internal class Task2
    {
        private int[,] arr;
        
        public Task2(int i, int j)
        {
            arr = new int[i, j];
        }

        // сума двох елементів на другому рядку
        public int SumTwoRandomValues(out int value1, out int value2)
        {
            if (arr.GetLength(0) <= 2)
                throw new IndexOutOfRangeException();

            var rand = new Random();

            int index1 = rand.Next(0, arr.GetLength(1) - 1); // обираємо випадковий рядок
            int index2 = rand.Next(0, arr.GetLength(1) - 1); // обираємо випадковий рядок

            value1 = arr[2, index1]; // обираємо випадкове число із другого рядка та випадкового стовпця
            value2 = arr[2, index2]; // обираємо випадкове число із другого рядка та випадкового стовпця

            return value1 + value2;
        }

        // добуток двох елементів на п'ятому стовпці
        public int MulTwoRandomValues(out int value1, out int value2)
        {
            if (arr.GetLength(1) <= 5)
                throw new IndexOutOfRangeException();

            var rand = new Random();
            int index1 = rand.Next(0, arr.GetLength(0)); // обираємо випадковий рядок
            int index2 = rand.Next(0, arr.GetLength(0)); // обираємо випадковий рядок

            value1 = arr[index1, 5]; // обираємо випадкове число із п'ятого стовпця та випадкового рядка
            value2 = arr[index2, 5]; // обираємо випадкове число із п'ятого стовпця та випадкового рядка

            return value1 * value2;
        }

        // автоматичне заповнення двовимірного масиву (числа від 0 до 9)
        public void GenerateArray()
        {
            var rand = new Random();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = rand.Next(0, 10);
                }
            }
        }

        // вивід масиву
        public void Print()
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"{arr[i, j]}  ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
