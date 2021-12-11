using System;

namespace DesignPatterns.Exercise
{
    public class Moderate : IInvestment
    {
        private Random _random;
        public Moderate()
        {
            _random = new Random();
        }

        public double Calculate(Account account)
        {
            bool chosen = _random.Next(2) == 0;
            if (chosen)
                return account.Balance * 0.025;
            else
                return account.Balance * 0.007;
        }
    }
}
