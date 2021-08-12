namespace Patterns_Part_1
{
    class SalaryAccountCalculator : IAccountCalculator
    {
        public void CalculateInterest(Account account)
        {
            account.Interest = account.Balance * 0.5;
        }
    }
}
