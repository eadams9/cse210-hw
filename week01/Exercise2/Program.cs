using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        int percent = int.Parse(Console.ReadLine());

        string letter = "";

        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
       // Stretch 1: determine the sign from the last digit
        int lastDigit = percent % 10;
        string sign = "";

        if (lastDigit >= 7)
        {
            sign = "+";
        }
        else if (lastDigit < 3)
        {
            sign = "-";
        }

        // Stretch 2: there is no A+ (this also covers 100, see note below)
        if (letter == "A" && percent >= 93)
        {
            sign = "";
        }

        // Stretch 3: there is no F+ or F-
        if (letter == "F")
        {
            sign = "";
        }

        Console.WriteLine($"Your letter grade is: {letter}{sign}");

        if (percent >= 70)
        {
            Console.WriteLine("Congratulations, you passed the course!");
        }
        else
        {
            Console.WriteLine("Don't give up. You'll get it next time!");
        }
    }
}