using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number between 1 and 7:");
        int dayNumber = Convert.ToInt32(Console.ReadLine());

        string dayOfWeek;

        switch (dayNumber)
        {
            case 1:
                dayOfWeek = "Monday";
                break;
            case 2:
                dayOfWeek = "Tuesday";
                break;
            case 3:
                dayOfWeek = "Wednesday";
                break;
            case 4:
                dayOfWeek = "Thursday";
                break;
            case 5:
                dayOfWeek = "Friday";
                break;
            case 6:
                dayOfWeek = "Saturday";
                break;
            case 7:
                dayOfWeek = "Sunday";
                break;
            default:
                dayOfWeek = "Error: Please enter a number between 1 and 7.";
                break;
        }

        Console.WriteLine(dayOfWeek);
    }
}
