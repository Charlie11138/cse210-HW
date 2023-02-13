using System;

public class ConsoleReader
{
    public int ReadMenu()
    {
        string response = Console.ReadLine();
        int menuSelect = int.Parse(response);
        return menuSelect;
    }
}