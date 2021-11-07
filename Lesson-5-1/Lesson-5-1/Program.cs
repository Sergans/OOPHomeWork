﻿using System;

namespace Lesson_5_1
{
    public class Fraction
    {
        public int Numerator { get; set; }
        public int Denominator { get; set; }
        public Fraction(int _numerator,int _denomirator)
        {
            Numerator = _numerator;
            Denominator = _denomirator;
        }
        public static Fraction operator +(Fraction f1,Fraction f2)
        {
            if (f1.Denominator == f2.Denominator)
            {
                return new Fraction(f1.Numerator + f2.Numerator, f1.Denominator);
            }
            
            Fraction _f1 =new Fraction((f1.Numerator * f2.Denominator), (f1.Denominator * f2.Denominator));
            Fraction _f2=new Fraction(f2.Numerator * f1.Denominator, f2.Denominator * f1.Denominator);
            return new Fraction(_f1.Numerator + _f2.Numerator, _f1.Denominator);
        }
        public static Fraction operator ++(Fraction f1)
        { Fraction f2 = new Fraction(1, 1);

            return f1 + f2;
        }
        public static Fraction operator --(Fraction f1)
        {
            Fraction f2 = new Fraction(1, 1);

            return f1 - f2;
        }
        public static Fraction operator -(Fraction f1,Fraction f2)
        {
            if (f1.Denominator == f2.Denominator)
            {
                return new Fraction(f1.Numerator - f2.Numerator, f1.Denominator);
            }
            
            Fraction _f1 = new Fraction(f1.Numerator * f2.Denominator, f1.Denominator * f2.Denominator);
            Fraction _f2 = new Fraction(f2.Numerator * f1.Denominator, f2.Denominator * f1.Denominator);
            return new Fraction(_f1.Numerator - _f2.Numerator, _f1.Denominator);

        }
        public static Fraction operator *(Fraction f1, Fraction f2)
        {
            return new Fraction(f1.Numerator * f2.Numerator, f1.Denominator*f2.Denominator);
        }
        public static Fraction operator /(Fraction f1, Fraction f2)
        {
            return new Fraction(f1.Numerator * f2.Denominator, f1.Denominator * f2.Numerator);
        }
        public static float operator %(Fraction f1, Fraction f2)
        {
            

            return (f1.ToFloat()%f2.ToFloat());
        }
        public static bool operator ==(Fraction f1, Fraction f2)
        {
            if (f1.ToFloat() == f2.ToFloat())
            {
                return true;
            }
            else { return false; }

        }
        public static bool operator !=(Fraction f1, Fraction f2)
        {
            if (f1.ToFloat() == f2.ToFloat())
            {
                return false;
            }
            else { return true; }
        }
        public static bool operator>(Fraction f1, Fraction f2)
        {
            if (f1.ToFloat() > f2.ToFloat())
            {
                return true;
            }
            else { return false; }

        }

        public static bool operator <(Fraction f1, Fraction f2)
        {
            if (f1.ToFloat() < f2.ToFloat())
            {
                return true;
            }
            else { return false; }

        }
        public static bool operator >=(Fraction f1, Fraction f2)
        {
            if (f1.ToFloat() >= f2.ToFloat())
            {
                return true;
            }
            else { return false; }
        }
        public static bool operator <=(Fraction f1, Fraction f2)
        {
            if (f1.ToFloat() <= f2.ToFloat())
            {
                return true;
            }
            else { return false; }
        }
        public override string ToString()
        {
            return ($"{this.Numerator}\r\n-\r\n{this.Denominator}");
        }
        public float ToFloat()
        {
          return (float)this.Numerator / (float)this.Denominator;
        }
       
    }
    class Program
    {
        static void Main(string[] args)
        {
            Fraction n1 = new Fraction(1, 2);
            Fraction n2 = new Fraction(1, 3);
            if (n1 < n2)
            {
                var a = n1 + n2;
                var b = n1 - n2;
                Console.WriteLine(a.ToString());
                Console.WriteLine();
                Console.WriteLine(a.ToFloat());
                Console.WriteLine(b.ToString());
                Console.WriteLine();
                Console.WriteLine(b.ToFloat());
            }

        }
    }
}
