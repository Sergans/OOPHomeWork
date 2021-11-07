using System;

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
            
            int numer1 = f1.Numerator * f2.Denominator;
            int denom1 = f1.Denominator * f2.Denominator;
            int numer2 = f2.Numerator * f1.Denominator;
            int denom2 = f2.Denominator * f1.Denominator;
            Fraction _f1 =new Fraction(numer1,denom1);
            Fraction _f2=new Fraction(numer2,denom2);
            return new Fraction(_f1.Numerator + _f2.Numerator, _f1.Denominator);
        }
        public static Fraction operator -(Fraction f1,Fraction f2)
        {
            if (f1.Denominator == f2.Denominator)
            {
                return new Fraction(f1.Numerator - f2.Numerator, f1.Denominator);
            }
            int numer1 = f1.Numerator * f2.Denominator;
            int denom1 = f1.Denominator * f2.Denominator;
            int numer2 = f2.Numerator * f1.Denominator;
            int denom2 = f2.Denominator * f1.Denominator;
            Fraction _f1 = new Fraction(numer1, denom1);
            Fraction _f2 = new Fraction(numer2, denom2);
            return new Fraction(_f1.Numerator - _f2.Numerator, _f1.Denominator);

        }
        public override string ToString()
        {
            return ($"{this.Numerator}\r\n-\r\n{this.Denominator}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Fraction n1 = new Fraction(1, 3);
            Fraction n2 = new Fraction(1, 2);
            var a = n1 + n2;
            var b = n1 - n2;
            Console.WriteLine(a.ToString());
            Console.WriteLine();
            Console.WriteLine(b.ToString());
        }
    }
}
