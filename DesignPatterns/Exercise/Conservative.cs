namespace DesignPatterns.Exercise
{
    public class Conservative : Investment
    {
        public double Calculate(Account account)
        {
            return account.Balance * 0.008;
        }
    }
}
