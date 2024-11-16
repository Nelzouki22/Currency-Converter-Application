using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Currency Converter");
        Console.WriteLine("1. Dollar to Euro");
        Console.WriteLine("2. Euro to Dollar");
        Console.WriteLine("3. Dollar to Libyan Dinar");
        Console.Write("Choose an option: ");
        int choice = int.Parse(Console.ReadLine());

        Console.Write("Enter the amount: ");
        double amount = double.Parse(Console.ReadLine());

        double convertedAmount = 0;

        switch (choice)
        {
            case 1:
                convertedAmount = amount * 0.85; // Dollar to Euro
                break;
            case 2:
                convertedAmount = amount * 1.18; // Euro to Dollar
                break;
            case 3:
                convertedAmount = amount * 4.8; // Dollar to Libyan Dinar
                break;
            default:
                Console.WriteLine("Invalid option.");
                return;
        }

        Console.WriteLine($"Converted amount: {convertedAmount}");
    }
}
