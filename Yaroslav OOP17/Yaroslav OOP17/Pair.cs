using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//  Абстрактний базовий клас Pair
public abstract class Pair
{
    public int X;
    public int Y;

    //  Конструктор
    public Pair(int x, int y)
    {
        this.X = x;
        this.Y = y;
    }

    // Bіртуальні методи додавання та віднімання
    public virtual Pair Add(Pair other) { return null; }
    public virtual Pair Sub(Pair other) { return null; }
}


// Похідний клас Money
public class Money : Pair
{
    public Money(int x = 0, int y = 0) : base(x, y)
    {
        if (x < 0 || y < 0)
            throw new ArgumentException();
    }

    public override Pair Add(Pair other)
    {
        int hrn = X + other.X;
        int kop = Y + other.Y;

        if (kop >= 100)
        {
            hrn += kop / 100;
            kop %= 100;
        }

        return new Money(hrn, kop);
    }

    public override Pair Sub(Pair other)
    {
        int hrn = this.X - other.X;
        int kop = this.Y - other.Y;

        if (kop < 0)
        {
            int count = Math.Abs(kop / 100);
            kop += 100 * (count + 1);
            hrn -= (count + 1);
        }

        if (hrn < 0)
            return new Money();

        return new Money(hrn, kop);
    }

    public override string ToString()
    {
        if (this == null)
            throw new NullReferenceException();

        return $"{X}грн, {Y}коп";
    }
}


// Похідний клас Complex
public class Complex : Pair
{
    public Complex(int x, int y) : base(x, y)
    {
        if (y == 0)
            throw new ArgumentException();
    }

    public override Pair Add(Pair other)
    {
        return new Complex(this.X + other.X, this.Y + other.Y);
    }
    public override Pair Sub(Pair other)
    {
        return new Complex(this.X - other.X, this.Y - other.Y);
    }

    public override string ToString()
    {
        if (Y < 0)
        {
            return $"{X} - {Math.Abs(Y)}i";
        }

        return $"{X} + {Y}i";
    }
}