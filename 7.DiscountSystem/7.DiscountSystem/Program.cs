using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the total amount of the purchase:");
        double totalAmount = Convert.ToDouble(Console.ReadLine());

        double finalAmount = totalAmount;

        if (totalAmount > 1000)
        {
            double discount = totalAmount * 0.10;
            finalAmount = totalAmount - discount;
        }

        Console.WriteLine($"The final amount after discount is: ${finalAmount:F2}");
    }
}