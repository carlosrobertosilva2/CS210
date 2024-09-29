using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        string userInput;

        Console.WriteLine("Welcome to the Journal Program!");

        do
        {
            Console.Write("Enter your journal entry (or type 'exit' to finish): ");
            userInput = Console.ReadLine();

            if (userInput.ToLower() != "exit")
            {
                Entry newEntry = new Entry(userInput);
                journal.AddEntry(newEntry);
            }

        } while (userInput.ToLower() != "exit");

        Console.WriteLine("\nYour Journal Entries:");
        journal.DisplayEntries();
    }
}
