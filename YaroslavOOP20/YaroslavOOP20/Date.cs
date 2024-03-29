using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YaroslavOOP20
{
    internal struct Date
    {
        private int year;
        private int month;
        private int day;

        public Date(int year = 2024, int month = 1, int day = 1)
        {
            if (year <= 0)
                throw new ArgumentException("Рік не може бути менше нуля або нулем!");
            else if (month <= 0)
                throw new ArgumentException("Місяць не може бути менше нуля або нулем!");
            else if (day <= 0)
                throw new ArgumentException("День не може бути менше нуля або нулем!");

            this.year = year;
            this.month = month;
            this.day = day;
        }

        public static int DayOfWeek(Date date)
        {
            if (date.month < 3)
            {
                date.month += 3;
                date.year -= 1;
            }
            int k = date.year % 100;
            int j = date.year / 100;
            int dayOfWeek = (date.day + ((13 * (date.month + 1)) / 5) + k + (k / 4) + (j / 4) - (2 * j)) % 7;

            return (dayOfWeek + 6) % 7;
        }

        public override string ToString()
        {
            return $"{year} / {month} / {day}";
        }
    }
}
