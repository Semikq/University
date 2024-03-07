using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Complex
{
    // formula: z = x + iy
    public double X { get; private set; }
    public double Y { get; private set; }

    // Конструктор з двома параметрами + за замовчуванням
    public Complex(double x = 0, double y = 1)
    {
        if (y == 0)
            throw new ArgumentException();

        this.X = x;
        this.Y = y;
    }

    // Сеттери
    public void SetX(int value)
    {
        this.X = value;
    }
    public void SetY(int value)
    {
        if (value == 0)
            throw new ArgumentException();

        this.Y = value;
    }

    // Перевантаження оператора '+'
    public static Complex operator +(Complex first, Complex second)
    {
        return new Complex(first.X + second.X, first.Y + second.Y);
    }

    // Перевантаження оператора '-'
    public static Complex operator -(Complex first, Complex second)
    {
        return new Complex(first.X - second.X, first.Y - second.Y);
    }

    // Перевантаження оператора '*'
    public static Complex operator *(Complex first, Complex second)
    {
        return new Complex(first.X * second.X - first.Y * second.Y, second.X * first.Y + first.X * second.Y);
    }

    // Перевантаження оператора '/'
    public static Complex operator /(Complex first, Complex second)
    {
        double denominator = second.X * second.X + second.Y * second.Y;
        double realPart = (first.X * second.X + first.Y * second.Y) / denominator;
        double imaginaryPart = (first.Y * second.X - first.X * second.Y) / denominator;
        return new Complex(realPart, imaginaryPart);
    }

    // Метод для знаходження модуля комплексного числа
    public double Abs()
    {
        return Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2));
    }

    // Перевантажений метод ToString() для класу Complex
    public override string ToString()
    {
        char cymbol = '+';
        if (Y < 0)
            cymbol = '-';

        if (X == 0)
        {
            if (cymbol == '+')
                return $"{Y}i";
            else
                return $"{cymbol}{Math.Abs(Y)}i";
        }

        return $"{X} {cymbol} {Math.Abs(Y)}i";
    }
}