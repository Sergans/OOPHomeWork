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
           
            this.Balance=b;
            this.Type = c;
            UnicNomber = UnicNomber++;
        }
        
        //public void Rec(decimal b,AccauntType c)
        //{
        //    UnicNomber = GetUnicnomber();
        //    this.Balance = b;
        //    this.Type = c;
        //}
        //public void Read()
        //{
        //    Console.WriteLine($"Номер счета - {UnicNomber}\r\nБаланс - {Balance}\r\nТип счета - {Type}");
        //}
        //public int GetUnicnomber()
        //{
        //        UnicNomber++;
        //        return UnicNomber;
        //}

    }
    class Program
    {
        static void Main(string[] args)
        {

            //BankAccount bank = new BankAccount();
            //bank.Rec(565655, AccauntType.Credit);
            //bank.Read();
            //BankAccount bank1 = new BankAccount();
            //bank1.Rec(5555, AccauntType.Debit);
            //bank1.Read();
            //BankAccount bank2 = new BankAccount();
            //bank2.Rec(66666, AccauntType.Credit);
            //bank2.Read();
            decimal c = 56;
            BankAccount bank = new { 555, AccauntType.Credit };


        }
    }
}
