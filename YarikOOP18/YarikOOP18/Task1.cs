using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YarikOOP18
{
    internal class Task1
    {
        private int[] arr;
        private int len;

        public Task1()
        {
            len = 0;
            arr = new int[0];
        }

        // максимальний за модулем елемент
        public int GetMaxValue()
        {
            int result = Math.Abs(arr[0]);
            for (int i = 0; i < len; i++)
            {
                int temp = Math.Abs(arr[i]);
                if (temp > result)
                    result = temp;
            }

            return result;
        }

        // повернення суми між першим та другим додатніми елементами
        public int SumPositive()
        {
            int result = 0;
            int count = 0;
            bool half = false;

            for (int i = 0; i < len; i++)
            {
                if (arr[i] > 0)
                {
                    half = !half;
                    count++;

                    if (count == 2)
                    {
                        result += arr[i];
                        break;
                    }
                }

                if (half)
                    result += arr[i];
            }
            return result;
        }

        // закидування нулів в кінець
        public void Sort()
        {
            int count = 0;
            for (int i = 0; i < len; i++)
            {
                if (arr[i] != 0)
                {
                    arr[count++] = arr[i];
                }
            }

            while (count < len)
            {
                arr[count++] = 0;
            }
        }

        // додавання елемента в масив
        public void PushBack(int value)
        {
            if (len == arr.Length)
                Array.Resize(ref arr, len + 1);

            arr[len++] = value;
        }

        // вивід масиву
        public void Print()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]}; ");
            }
            Console.WriteLine();
        }
    }
}
