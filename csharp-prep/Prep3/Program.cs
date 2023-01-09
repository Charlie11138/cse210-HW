using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1,101);
        int finished = 0;
        while (finished == 0)
        {
            Console.Write("What is your guess? ");
            string answer2 = Console.ReadLine();
             int guess = int.Parse(answer2);

            if (guess > number)
            {
                Console.WriteLine("Higher");
            }

            else if (guess < number)
            {
                Console.WriteLine("Lower");
            }

            else
            {
                Console.WriteLine("You guessed it!");
                finished = 1;
            }
        }
    }
}