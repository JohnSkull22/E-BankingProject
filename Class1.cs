using System;

public enum DaysOfWeek
{
    Sunday,
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday
}

class Program
{
    static void Main()
    {
        DaysOfWeek today = DaysOfWeek.Wednesday;
        Console.WriteLine($"Today is {today}");
    }
}
