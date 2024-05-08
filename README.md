# Loan Calculation Program

## Overview
This C# console application calculates the total amount to be paid on a loan over a specified period, taking into account monthly interest and a fixed fee. The user inputs the start and end dates of the loan, the initial amount borrowed, and the annual interest rate. The program then computes the total amount due by the end of the loan period, including monthly interest accruals and fees.

## Features
- **Date Input**: Users can specify the start and end dates for the loan period.
- **Loan and Interest Calculation**: Calculates the total amount due, including a 5% fee on the initial amount and monthly interest.
- **Detailed Breakdown**: Provides a monthly breakdown of the total amount due, including accrued interest and fees.

## How to Use
1. **Start the Program**: Run `Program.cs` in a C# compatible environment.
2. **Enter Loan Details**:
   - Input the starting date in `yyyy-mm-dd` format.
   - Input the ending date in `yyyy-mm-dd` format.
   - Enter the amount of money to be borrowed.
   - Enter the annual interest rate as a percentage.
3. **View Results**: The program will display the initial amount with the fee, followed by a monthly breakdown of the total amount due, and finally the total amount to be paid by the end date.

## Requirements
- .NET compatible environment to run C# programs.

## Example
Enter the starting date (yyyy-mm-dd): 2023-01-01
Enter the end date (yyyy-mm-dd): 2023-12-01
Enter the amount of money to be borrowed: 10000
Enter the annual interest rate (as a percentage): 5
Initial amount plus fee: $10,500.00
As of 2023-02-01, the total amount with interest and fees is: $11,037.50
...
Final amount to be paid by 2023-12-01: $XX,XXX.XX
This README provides a concise description of the program's functionality, usage, and requirements, suitable for a GitHub repository.
