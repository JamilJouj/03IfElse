
using System.Runtime.InteropServices;
{
    int age;
    Console.WriteLine("Input ur age");

    age = Convert.ToInt32(Console.ReadLine());


    if (age < 13)
    {
        Console.WriteLine("you are a child");
    }
    else if (age >= 13 && age <= 19) // (age >= 13 && age <= 19) kontrollerar om åldern är inom intervallet 13 till 19
    {
        Console.WriteLine("you are a teenager");
    }
    else
    {
        Console.WriteLine("You are an adult");

    }
}