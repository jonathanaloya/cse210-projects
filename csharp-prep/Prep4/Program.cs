using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        List<int> numbers = new List<int>();
        int inputNumber = -1;
        

        while (inputNumber != 0)
        {
            Console.Write("Enter number: ");
            string list = Console.ReadLine();
            inputNumber = int.Parse(list);
        
            if (inputNumber != 0)
            {
                numbers.Add(inputNumber);
            } 
            
        }
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        float average = ((float)sum) / numbers.Count;

        int maximum = numbers[0];
        int minimumPositive = int.MaxValue;
        foreach (int number in numbers)
        {
            if (number > maximum)
            {
                maximum = number;
            }
            if (number > 0 && number < minimumPositive)
            {
                minimumPositive = number;
            }
        }

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {maximum}");
        Console.WriteLine($"The smallest positive number is: {minimumPositive}");
        Console.WriteLine("The sorted list is:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
        
    }
}