using System;

namespace DesignPatterns.Exercise
{
    public class InvestmentManager
    {
        public void Invest(Account account, Investment investment)
        {
            var income = investment.Calculate(account);
            account.Deposit(income * 0.75);
            Console.WriteLine("New balance: ", account.Balance);
        }
    }
}
