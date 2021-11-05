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
        public override string ToString()
         {
            return ($"{this.Numerator}\r\n-\r\n{this.Denominator}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Fraction n1 = new Fraction(1, 2);
            Console.WriteLine(n1.ToString());
        }
    }
}
