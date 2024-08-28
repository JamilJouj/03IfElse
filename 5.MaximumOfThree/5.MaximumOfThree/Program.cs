using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the first number:");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the third number:");
        double num3 = Convert.ToDouble(Console.ReadLine());

        double max;

        if (num1 >= num2 && num1 >= num3)
        {
            max = num1;
        }
        else if (num2 >= num1 && num2 >= num3)
        {
            max = num2;
        }
        else
        {
            max = num3;
        }

        Console.WriteLine("The maximum number is: " + max);
    }
}