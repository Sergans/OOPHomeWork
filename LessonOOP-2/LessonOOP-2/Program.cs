using System;
using System.Collections.Generic;

namespace LessonOOP_2
{
    public enum AccauntType {};
    public class BankAccount
    {
       private int Nomber;
       private decimal Balance;
       public AccauntType type;
        public void Rec(int a,decimal b)
        {
            this.Nomber = a;
            this.Balance = b;
           
       }
        public void Read()
        {
            Console.WriteLine($"Номер счета - {Nomber}\r\nБаланс - {Balance}");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
           
            BankAccount bank = new BankAccount();
            bank.Rec(11111, 6989);
            bank.Read();
            Console.WriteLine(bank.type);
            bank.type
            
        }
    }
}
