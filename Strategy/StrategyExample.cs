using DesignPatterns.Example;
using DesignPatterns.Exercise;
using System;

namespace DesignPatterns
{
    public partial class Program
    {
        static void Taxes()
        {
            ITax iss = new ISS();
            ITax icms = new ICMS();

            Budget budget = new Budget(500.0);

            TaxCalculator calculator = new TaxCalculator();

            calculator.Calculate(budget, iss);
            calculator.Calculate(budget, icms);
        }

        static void Taxes_Ex1()
        {
            ITax iccc = new ICCC();

            Budget budget1 = new Budget(100);
            Budget budget2 = new Budget(1000);
            Budget budget3 = new Budget(10000);

            TaxCalculator calculator = new TaxCalculator();

            calculator.Calculate(budget1, iccc);
            calculator.Calculate(budget2, iccc);
            calculator.Calculate(budget3, iccc);
        }

        static void Investment_Ex()
        {
            Account account = new Account();
            account.Deposit(1000);

            IInvestment conservative = new Conservative();
            Console.WriteLine(conservative.Calculate(account));

            IInvestment moderate = new Moderate();
            Console.WriteLine(moderate.Calculate(account));

            IInvestment bold = new Bold();
            Console.WriteLine(bold.Calculate(account));

            InvestmentManager manager = new InvestmentManager();
            manager.Invest(account, conservative);
            Console.WriteLine(account.Balance);
        }
    }
}
