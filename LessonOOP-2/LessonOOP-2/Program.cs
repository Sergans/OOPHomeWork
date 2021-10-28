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
        public void GetBalance(BankAccount unicnomber,decimal summ)
        {
           Balance = Balance + summ;
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {

            BankAccount bank = new BankAccount();
            bank.Balance = 4444;
            bank.Type = AccauntType.Credit;
            bank.UnicNomber = 0;
            Console.WriteLine($"Номер счета - {bank.UnicNomber}\r\nБаланс - {bank.Balance}\r\nТип счета - {bank.Type}");
            
            var a = bank;
           // var b = bank1;
            bank.GetBalance(a, 1111);
            Console.WriteLine($"Номер счета - {bank.UnicNomber}\r\nБаланс - {bank.Balance}\r\nТип счета - {bank.Type}");
            bank.GetBalance(a, 1111);
            Console.WriteLine($"Номер счета - {bank.UnicNomber}\r\nБаланс - {bank.Balance}\r\nТип счета - {bank.Type}");
            BankAccount bank1 = new BankAccount();
            bank1.Balance = 2222;
            bank1.Type = AccauntType.Debit;
            bank1.UnicNomber = 0;
            BankAccount bank2 = new BankAccount();
            bank2.Balance = 1111;
            bank2.Type = AccauntType.Debit;
            bank2.UnicNomber = 0;
            bank2.GetBalance(a, 2222);
            Console.WriteLine($"Номер счета - {bank2.UnicNomber}\r\nБаланс - {bank2.Balance}\r\nТип счета - {bank2.Type}");

        }
    }
}
