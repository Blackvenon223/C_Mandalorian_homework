using System;

namespace MediumHomework
{


    struct Account
    {
        public int number;
        public Accounts type;
        public decimal balance;

        public void ShowData()
        {
            Console.WriteLine($">>>>{number}");
            Console.WriteLine($">>>>{type} ");
            Console.WriteLine($">>>>{balance}");
        }
    }


    class Task2
    {
        static void Main(string[] args)
        {
            Account myaccount;
            myaccount.number = 1789531287;
            myaccount.type = Accounts.Credit;
            myaccount.balance = 1800000;

            myaccount.ShowData();

        }
    }
}
