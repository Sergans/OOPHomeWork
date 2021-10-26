using System;
using System.Collections.Generic;

namespace LessonOOP_2
{
    public enum AccauntType {Credit,Debit}
    public class BankAccount
    {
        private int Nomber;
        private decimal Balance;
        private AccauntType Type;
        
        public void Rec(int a,decimal b,AccauntType c)
        {
            this.Nomber = a;
            this.Balance = b;
            this.Type = c;
       }
        public void Read()
        {
            Console.WriteLine($"Номер счета - {Nomber}\r\nБаланс - {Balance}\r\nТип счета - {Type}");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
           
            BankAccount bank = new BankAccount();
            bank.Rec(11111, 6989,AccauntType.Credit);
            bank.Read();
            bank.Rec(22222, 88888, AccauntType.Debit);
            bank.Read();
            

        }
    }
}
