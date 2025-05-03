using System;

namespace DiaryApp;

class Program
{
    private bool _isRunning = true;
    
    Diary diary = new Diary("diary.txt");

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
        while (_isRunning)
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
                    _isRunning = false;
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
        string? entry = Console.ReadLine();
        
        diary.WriteEntry(entry);
        
        Console.WriteLine("Diary entry saved.");
        Pause();
    }

    private void ViewAllDiaryEntries()
    {
        Console.WriteLine("All Diary Entries:");
        diary.ViewAllEntries();
        Console.WriteLine();
        Pause();
    }

    private void SearchDiaryEntry()
    {
        Console.WriteLine("Enter the date of the diary entry you want to search for (YYYY-MM-DD): ");
        string? date = Console.ReadLine();
        diary.SearchByDate(date);
        Pause();
    }
    private void Pause()
    {
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey(true);
    }
}