using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        List<int> numbers = new List<int>();
        int response = -1;
        while (response != 0)
        {
            Console.Write("Enter a number: ");
            string answer = Console.ReadLine();
            response = int.Parse(answer);

            if (response != 0)
            {
                numbers.Add(response);
            }
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int maximum = 0;

        foreach (int number in numbers)
        {
            if (number > maximum)
            {
                maximum = number;
            }
        }

        Console.WriteLine($"The biggest number is : {maximum}");
    }
}