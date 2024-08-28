{
    Console.Write("Input your test score (0-100):");

    // Läs in testpoängen och konvertera den från text till ett heltal
    int score = Convert.ToInt32(Console.ReadLine());

    // Kontrollera poängen och tilldela ett betyg baserat på villkoren
    if (score >= 90 && score <= 100)
    {
        Console.WriteLine("A");
    }
    else if (score >= 80 && score <= 89)
    {
        Console.WriteLine("B");
    }
    else if (score >= 70 && score <= 79)
    {
        Console.WriteLine("C");
    }
    else if (score >= 60 && score <= 69)
    {
        Console.WriteLine("D");
    }
    else if (score < 60)
    {
        Console.WriteLine("F");
    }
    else
    {
        // Hantera ogiltiga poäng (utanför intervallet 0-100)
        Console.WriteLine("youre testscore is between 0-100");
    }
}