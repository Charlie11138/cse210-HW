using System;

public class Menu
{
    public void Display()
    {
        int resume = 1;
        while (resume == 1)
            {
            ConsoleWriter displayw = new ConsoleWriter();
            displayw.DisplayMenu();
            int selection = 0;
            ConsoleReader displayr = new ConsoleReader();
            selection = displayr.ReadMenu();
            Console.WriteLine($"{selection}");

            if (selection == 1)
            {

            }

            else if (selection == 2)
            {

            }

            else if (selection == 3)
            {

            }

            else if (selection == 4)
            {

            }

            else if (selection == 5)
            {
                resume = 0;
            }

            else
            {
                Console.WriteLine("Please enter a valid option.");
            }
        }
    }
}