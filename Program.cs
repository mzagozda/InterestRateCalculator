using System;
using System.Globalization;
using System.IO; // Include this for file operations

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

// Create a StreamWriter to write to a CSV file
using (StreamWriter writer = new StreamWriter("loan_details.csv"))
{
    // Write CSV header
    writer.WriteLine("Date,Fee,Total");

    while (nextMonthDate <= endDate)
    {
        decimal monthlyInterest = totalAmount * (annualInterestRate / 100 / 12);
        totalAmount += monthlyInterest;

        if (nextMonthDate < endDate)
        {
            fee = amount * feePercentage; // Fee based on the initial amount
            totalAmount += fee;
        }

        // Write to console
        Console.WriteLine($"Date: {nextMonthDate:yyyy-MM-dd}, fee: {fee:C2}, total: {totalAmount:C2}");

        // Write the same details to the CSV file
        writer.WriteLine($"{nextMonthDate:yyyy-MM-dd},{fee:C2},{totalAmount:C2}");

        nextMonthDate = nextMonthDate.AddMonths(1);
    }
}

Console.WriteLine("Final amount to be paid by " + endDate.ToString("yyyy-MM-dd") + ": " + totalAmount.ToString("C2"));
Console.ReadLine();
Console.ReadLine();