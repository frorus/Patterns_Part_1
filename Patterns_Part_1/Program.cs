using System;

namespace Patterns_Part_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account1 = new() { Type = "Обычный", Balance = 500.0, Interest = 0.0 };
            Account account2 = new() { Type = "Обычный", Balance = 1500.0, Interest = 0.0 };
            Account account3 = new() { Type = "Зарплатный", Balance = 50000.0, Interest = 0.0 };

            Calculator baseAccountCalculator1 = new(account1);
            baseAccountCalculator1.Calculate(new BaseAccountCalculator());
            Console.WriteLine($"Процентная ставка для аккаунта №1: {account1.Interest}");
            Console.WriteLine();

            Calculator baseAccountCalculator2 = new(account2);
            baseAccountCalculator2.Calculate(new BaseAccountCalculator());
            Console.WriteLine($"Процентная ставка для аккаунта №2: {account2.Interest}");
            Console.WriteLine();

            Calculator salaryAccountCalculator = new(account3);
            salaryAccountCalculator.Calculate(new SalaryAccountCalculator());
            Console.WriteLine($"Процентная ставка для аккаунта №3: {account3.Interest}");
        }
    }
}
