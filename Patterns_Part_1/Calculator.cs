namespace Patterns_Part_1
{
    public class Calculator
    {
        public Account Account { get; }

        public Calculator (Account account)
        {
            Account = account;
        }

        public void Calculate(IAccountCalculator accountCalculator)
        {
            accountCalculator.CalculateInterest(Account);
        }
    }
}
