namespace DesignPatterns.Example
{
    public class ISS : Tax
    {
        public double Calculate(Budget budget)
        {
            return budget.Value * 0.06;
        }
    }
}
