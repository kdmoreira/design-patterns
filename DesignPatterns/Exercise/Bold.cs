using System;

namespace DesignPatterns.Exercise
{
    public class Bold : IInvestment
    {
        private Random _random;
        public Bold()
        {
            _random = new Random();
        }

        public double Calculate(Account account)
        {
            int chosen = _random.Next(10);
            if (chosen < 5)
                return account.Balance * 0.6;
            else if (chosen >= 5 && chosen <= 8)
                return account.Balance * 0.3;
            else
                return account.Balance * 0.5;
        }
    }
}
