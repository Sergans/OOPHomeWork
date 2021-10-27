using System;
using System.Collections.Generic;

namespace LessonOOP_2
{
    public enum AccauntType {Credit,Debit}
    public class BankAccount
    {
        private decimal Balance;
        private AccauntType Type;
        private static int UnicNomber;

        public BankAccount(decimal b, AccauntType c)
        {
            UnicNomber++;
            this.Balance=b;
            this.Type = c;
            
            Console.WriteLine($"Номер счета - {UnicNomber}\r\nБаланс - {Balance}\r\nТип счета - {Type}");
        }
     }
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount bank = new BankAccount(55555,AccauntType.Credit);
            BankAccount bank1 = new BankAccount(66666, AccauntType.Credit);
        }
    }
}
