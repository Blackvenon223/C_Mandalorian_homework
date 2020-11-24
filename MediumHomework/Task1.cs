using System;

namespace MediumHomework
{


    enum Accounts
    {
        Current,
        Credit,
        SocialPays,
        Deposit
    }




    class Task1
    {
        static void Main(string[] args)
        {
            Accounts account;
            account = Accounts.Credit;
            Console.WriteLine(account);
            
        }
    }
}
