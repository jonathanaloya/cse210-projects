using System;

class Program
{
    static void Main(string[] args)
    {
        // This is prep 2
        Console.WriteLine("Hello Prep2 World!");

        Console.Write("What is your grade percentage? ");
        string grades = Console.ReadLine();
        int X = int.Parse(grades);
        string grade = "";

        if (X > 93)
        {
            grade = "A";
        }
        else if (X >= 90 && X < 93)
        {
            grade = "A-";
        }
        else if (X >= 86 && X < 90)
        {
            grade = "B+";
        }
        else if ( X >= 80 && X < 86)
        {
            grade = "B-";
        }
        else if (X >= 76 && X < 80)
        {
            grade = "C+";
        }
        else if (X >= 70 && X < 76)
        {
            grade = "C-";
        }
        else if (X >= 66 && X < 70)
        {
            grade = "D+";
        }
        else if (X >= 60 && X < 66)
        {
            grade = "D-";
        }
        else if (X < 60)
        {
            grade = "F";
        }
        Console.WriteLine($"Your grade is: {grade}");
        if (X >= 70)
        {
            Console.WriteLine("Congratulation you have passed");
        }
        else
        {
            Console.WriteLine("We appreciate your effort but try better next time");
        }
    }
}