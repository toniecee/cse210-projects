using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();
        int percent = int.Parse(grade);

        string letter = "";

        if (percent >= 90)
        {
            letter = "A";
        }

        else if (percent >= 80 && percent < 90)
        {
            letter = "B";
        }

        else if (percent >= 70 && percent < 80)
        {
            letter = "C";
        }

        else if (percent >= 60 && percent < 70)
        {
            letter = "D";
        }

        else
        {
            letter = "F";
        }

        string sign = "";
        int lastDigit = percent % 10;

        if (lastDigit >= 7)
        {
            sign = "+";
        }

        else if (lastDigit < 3)
        {
            sign = "-";
        }

        else
        {
            sign = "";
        }

        if (letter == "A" && sign == "+")
        {
            sign = "";
        }

        if (letter == "F")
        {
            sign = "";
        }

        Console.WriteLine($"Your grade is:{letter}{sign}.");

        
        if (percent >= 70)
        {
            Console.WriteLine("Congratulations, you have passed the course.");
        }

        else
        {
            Console.WriteLine("Try again next time.");
        }

    }
}

