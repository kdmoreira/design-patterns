namespace DesignPatterns.Example
{
    public class ICMS : Tax
    {
        public double Calculate(Budget budget)
        {
            return budget.Value * 0.05 + 50;
        }
    }
}
