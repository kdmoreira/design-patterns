namespace DesignPatterns.Exercise
{
    public class Conservative : IInvestment
    {
        public double Calculate(Account account)
        {
            return account.Balance * 0.008;
        }
    }
}
