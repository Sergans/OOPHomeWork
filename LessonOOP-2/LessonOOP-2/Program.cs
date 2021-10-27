using System;
using System.Collections.Generic;

namespace LessonOOP_2
{
    public enum AccauntType {Credit,Debit}
    public class BankAccount
    {
        
        public decimal Balance { get; set; }
        public AccauntType Type { get; set; }
        private static int unicNomber;
        public int UnicNomber
        {
            get
            {
                return unicNomber;
            }
            set
            {

                unicNomber++;
            }
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {

            BankAccount bank = new BankAccount();
            bank.Balance = 5555;
            bank.Type = AccauntType.Credit;
            bank.UnicNomber = 0;
            Console.WriteLine($"Номер счета - {bank.UnicNomber}\r\nБаланс - {bank.Balance}\r\nТип счета - {bank.Type}");
            BankAccount bank1 = new BankAccount();
            bank1.Balance = 6666;
            bank1.Type = AccauntType.Debit;
            bank1.UnicNomber = 0;
            Console.WriteLine($"Номер счета - {bank1.UnicNomber}\r\nБаланс - {bank1.Balance}\r\nТип счета - {bank1.Type}");

        }
    }
}
