using System;

// CREATIVITY & EXCEEDING REQUIREMENTS COMMENT:
// To exceed the core requirements, this program adds:
// 1. Mood Tracking: Users record their emotional state/mood alongside the date and prompt.
// 2. Word Count Analytics: Each entry automatically calculates and displays its total word count upon viewing.
// These extra metadata points enhance self-reflection while fully complying with abstraction principles.

class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();
        PromptGenerator promptGen = new PromptGenerator();
        int choice = 0;

        while (choice != 5)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            string input = Console.ReadLine();
            if (int.TryParse(input, out choice))
            {
                switch (choice)
                {
                    case 1:
                        string prompt = promptGen.GetRandomPrompt();
                        Console.WriteLine($"\nPrompt: {prompt}");
                        Console.Write("> ");
                        string userText = Console.ReadLine();

                        Console.Write("How are you feeling today? (e.g., Grateful, Joyful, Reflective): ");
                        string userMood = Console.ReadLine();
                        
                        string currentDate = DateTime.Now.ToShortDateString();

                        Entry newEntry = new Entry();
                        newEntry._date = currentDate;
                        newEntry._promptText = prompt;
                        newEntry._entryText = userText;
                        newEntry._mood = userMood;

                        theJournal.AddEntry(newEntry);
                        Console.WriteLine("Entry added successfully!\n");
                        break;

                    case 2:
                        Console.WriteLine("\n--- Journal Entries ---");
                        theJournal.DisplayAll();
                        break;

                    case 3:
                        Console.Write("\nWhat is the filename? ");
                        string saveFile = Console.ReadLine();
                        theJournal.SaveToFile(saveFile);
                        break;

                    case 4:
                        Console.Write("\nWhat is the filename? ");
                        string loadFile = Console.ReadLine();
                        theJournal.LoadFromFile(loadFile);
                        break;

                    case 5:
                        Console.WriteLine("\nGoodbye!");
                        break;

                    default:
                        Console.WriteLine("\nInvalid choice. Please select between 1 and 5.\n");
                        break;
                }
            }
            else
            {
                Console.WriteLine("\nInvalid input. Please enter a number.\n");
            }
        }
    }
}