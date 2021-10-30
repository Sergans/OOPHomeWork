using System;
using System.Collections.Generic;

namespace LessonOOP_2
{// задание 3-1
    public enum AccauntType {Credit,Debit}
    public class BankAccount
    {

        private decimal balance;
        public decimal Balance
        {
            get
            {
                return balance;
            }
           
        }
        public AccauntType Type { get; }
        private static int unicNomber;
        public int Nomber { get; }
        
        public BankAccount(decimal balance,AccauntType type)
        {
            this.balance = balance;
            this.Type = type;
            Nomber= unicNomber++;
        }
        public void GetBalance(BankAccount accaunt, decimal summ)
        {

            this.balance = this.balance + summ;
            accaunt.balance = accaunt.balance - summ;

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount bank = new BankAccount(4444, AccauntType.Credit);
            BankAccount bank1 = new BankAccount(3333, AccauntType.Debit);
            BankAccount bank2 = new BankAccount(2222, AccauntType.Credit);
            // проверка
            Console.WriteLine($"Номер счета - {bank.Nomber}\r\nБаланс - {bank.Balance}\r\nТип счета - {bank.Type}");
            Console.WriteLine($"Номер счета - {bank1.Nomber}\r\nБаланс - {bank1.Balance}\r\nТип счета - {bank1.Type}");
            Console.WriteLine($"Номер счета - {bank2.Nomber}\r\nБаланс - {bank2.Balance}\r\nТип счета - {bank2.Type}");
            bank.GetBalance(bank1, 1111);
            Console.WriteLine($"Номер счета - {bank.Nomber}\r\nБаланс - {bank.Balance}\r\nТип счета - {bank.Type}");
            Console.WriteLine($"Номер счета - {bank1.Nomber}\r\nБаланс - {bank1.Balance}\r\nТип счета - {bank1.Type}");
            bank2.GetBalance(bank1, 2222);
            Console.WriteLine($"Номер счета - {bank1.Nomber}\r\nБаланс - {bank1.Balance}\r\nТип счета - {bank1.Type}");
            Console.WriteLine($"Номер счета - {bank2.Nomber}\r\nБаланс - {bank2.Balance}\r\nТип счета - {bank2.Type}");
        }
    }
}
