
class Program
{ 
    static void Main()
    {
        Console.Write("input a year: ");

        int year = int.Parse(Console.ReadLine());

        // Kontrollera om året är ett skottår
        // Ett skottår är delbart med 4 men inte med 100, förutom när det också är delbart med 400
        if (year % 4 == 0) // Första kontrollen: Är året delbart med 4?
        {
            if (year % 100 == 0)
            {
                if (year % 400 == 0)
                {
                    Console.WriteLine($"{year} Is a leap year.");
                }
                else
                {
                    Console.WriteLine($"{year} is not a leap year.");
                }
            }
            else
            {
                Console.WriteLine($"{year} is a leap year.");
            }
        }
        else
        {
            Console.WriteLine($"{year} is not a leap year.");
        }
    }
}