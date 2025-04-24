using System;
using

class Program
{
    private bool isRunning;

    private Diary diary;
    Program()
    {
        isRunning = true;
        diary = new Diary();
    }
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Run();
    }

    public void Run()
    {
        string[] options = {
            "1. Add Diary Entry",
            "2. View All Diary Entries",
            "3. Search Diary Entry",
            "4. Exit"
        };
        // Main Loop
        while (true)
        {
            Console.WriteLine("Welcome to the Diary App!");
            foreach (string option in options)
            {
                Console.WriteLine(option);
            }
            char input = Console.ReadKey(true).KeyChar;

            switch (input)
            {
                case '1':
                    AddDiary();
                    break;
                case '2':
                    ViewAllDiaryEntries();
                    break;
                case '3':
                    SearchDiaryEntry();
                    break;
                case '4':
                    isRunning = false;
                    Console.WriteLine("Exiting the Diary App. Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    private void AddDiary()
    {
        Console.WriteLine("Enter your diary entry: ");
        string entry = Console.ReadLine();
        // Save the entry to a file or database (not implemented in this example)
        diary.WriteEntry(entry);
        Console.WriteLine("Diary entry saved.");
        Console.ReadKey(true);
    }

    private void ViewAllDiaryEntries()
    {
        DiaryEntry[] entries = diary.GetAllEntries();
        if (entries.Length == 0)
        {
            Console.WriteLine("No diary entries found.");
        }
        else
        {
            foreach (DiaryEntry entry in entries)
            {
                Console.WriteLine($"Date: {entry.Date}, Entry: {entry.Content}");
            }
        }
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey(true);

    }

    private void SearchDiaryEntry()
    {
        DiaryEntry searchedEntry = null;
        Console.WriteLine("Enter the date of the diary entry you want to search for (YYYY-MM-DD): ");
        string date = Console.ReadLine();
        searchedEntry = diary.SearchByDate(date);
        if (searchedEntry != null)
        {
            Console.WriteLine($"Date: {searchedEntry.Date}, Entry: {searchedEntry.Content}");
        }
        else
        {
            Console.WriteLine("No diary entry found for the specified date.");
        }
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey(true);
    }
}