namespace DesignPatterns.Example
{
    public class ICCC : Tax
    {
        public double Calculate(Budget budget)
        {
            if (budget.Value < 1000)
                return budget.Value * 0.05;
            else if (budget.Value >= 1000 && budget.Value <= 3000)
                return budget.Value * 0.07;
            else
                return budget.Value * 0.08 + 30;
        }
    }
}
