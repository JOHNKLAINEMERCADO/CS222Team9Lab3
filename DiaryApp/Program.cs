using System;

class Program
{
    static void Main()
    {
        IDiary diary = new Diary("NormalDiary.txt");

        while (true)
        {
            Console.WriteLine("Welcome to the Diary App!");
            Console.WriteLine("1. Add Diary Entry");
            Console.WriteLine("2. View All Diary Entries");
            Console.WriteLine("3. Search Diary Entry");
            Console.WriteLine("4. Exit");

            Console.Write("Enter your choice: ");
            string? input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    AddEntry(diary);
                    break;
                case "2":
                    ViewAllEntries(diary);
                    break;
                case "3":
                    SearchDate(diary);
                    break;
                case "4":
                    Console.WriteLine("Exiting the Diary App. Goodbye!");
                    return;
                default:
                    Console.Clear();
                    Console.WriteLine("Invalid option. Please try again.");
                    Pause();
                    break;
            }
        }
    }

    static void AddEntry(IDiary diary)
    {
        Console.Write("Enter your diary entry (leave empty to exit): ");
        string? entry = Console.ReadLine();

        if (entry == "" || entry == null) return;

        diary.WriteEntry(entry);

        Console.Clear();
        Console.WriteLine("Entry added!");
        Pause();

    }

    static void ViewAllEntries(IDiary diary)
    {
        Console.Clear();
        Console.WriteLine("All Diary Entries");
        Console.WriteLine("-----------------------------");
        diary.ViewAllEntries();

        Pause();
    }

    static void SearchDate(IDiary diary)
    {
        Console.Write("Enter the date in yyyy-mm-dd format (leave empty to exit): ");
        string? input = Console.ReadLine();

        if (input == "") return;

        if (DateTime.TryParse(input, out DateTime date))
        {
            Console.Clear();
            Console.WriteLine($"Entries on {date.ToString("yyyy-MM-dd")}: ");
            Console.WriteLine("-----------------------------");
            diary.SearchByDate(date.ToString("yyyy-MM-dd"));
            Pause();
        }

        else
        {
            Console.Clear();
            Console.WriteLine("Enter a valid date format!");
            Pause();
        }
    }

    static void Pause()
    {
        Console.Write("Press any key to continue...");
        Console.ReadKey();
        Console.Clear();
    }
}