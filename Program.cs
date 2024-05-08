using System.Globalization;

Console.WriteLine("Enter the starting date (yyyy-mm-dd):");
DateTime startDate = DateTime.ParseExact(Console.ReadLine(), "yyyy-MM-dd", CultureInfo.InvariantCulture);

Console.WriteLine("Enter the end date (yyyy-mm-dd):");
DateTime endDate = DateTime.ParseExact(Console.ReadLine(), "yyyy-MM-dd", CultureInfo.InvariantCulture);

Console.WriteLine("Enter the amount of money to be borrowed:");
decimal amount = decimal.Parse(Console.ReadLine());

Console.WriteLine("Enter the annual interest rate (as a percentage):");
decimal annualInterestRate = decimal.Parse(Console.ReadLine());

const decimal feePercentage = 0.05m; // 5% fee
decimal fee = amount * feePercentage;
decimal totalAmount = amount + fee;

Console.WriteLine("Initial amount plus fee: " + totalAmount.ToString("C2"));

DateTime nextMonthDate = startDate.AddMonths(1);

while (nextMonthDate <= endDate)
{
    decimal monthlyInterest = totalAmount * (annualInterestRate / 100 / 12);
    totalAmount += monthlyInterest;

    if (nextMonthDate < endDate)
    {
        fee = amount * feePercentage; // Fee based on the initial amount
        totalAmount += fee;
    }

    Console.WriteLine($"As of {nextMonthDate.ToString("yyyy-MM-dd")}, the total amount with interest and fees is: {totalAmount.ToString("C2")}");

    nextMonthDate = nextMonthDate.AddMonths(1);
}

Console.WriteLine("Final amount to be paid by " + endDate.ToString("yyyy-MM-dd") + ": " + totalAmount.ToString("C2"));
Console.ReadLine();