using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Choose the conversion type:");
        Console.WriteLine("1. Fahrenheit to Celsius");
        Console.WriteLine("2. Celsius to Fahrenheit");
        Console.Write("Enter 1 or 2: ");
        int choice = Convert.ToInt32(Console.ReadLine());

        double inputTemperature, convertedTemperature;

        if (choice == 1)
        {
            Console.Write("Enter temperature in Fahrenheit: ");
            inputTemperature = Convert.ToDouble(Console.ReadLine());

            convertedTemperature = (inputTemperature - 32) * 5 / 9;

            Console.WriteLine($"Temperature in Celsius: {convertedTemperature:F2}");
        }
        else if (choice == 2)
        {
            Console.Write("Enter temperature in Celsius: ");
            inputTemperature = Convert.ToDouble(Console.ReadLine());

            convertedTemperature = (inputTemperature * 9 / 5) + 32;

            Console.WriteLine($"Temperature in Fahrenheit: {convertedTemperature:F2}");
        }
        else
        {
            Console.WriteLine("Invalid choice. Please enter 1 or 2.");
        }
    }
}