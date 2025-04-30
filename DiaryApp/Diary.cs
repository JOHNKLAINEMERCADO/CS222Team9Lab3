using System;
using System.Collections.Generic;


public class Diary : IDiary
{
    private string filePath;

    public Diary(string filePath)
    {
        this.filePath = filePath;
    }


    private void EnsureFileExists()
    {
        if(!File.Exists(filePath))
        {
            using (File.Create(filePath));
        }
    }


    private List<string[]> GetAllEntries()
    {
        EnsureFileExists();
        List<string[]> entries = new List<string[]>();

        using(StreamReader sr = File.OpenText(filePath))
        {
            string? line;
            while((line = sr.ReadLine()) != null)
            {
                entries.Add(line.Split(" || "));
            }
        }

        return entries;
    }


    public void ViewAllEntries()
    {
        List<string[]> entries = GetAllEntries();
        if (entries.Count == 0)
        { 
            Console.WriteLine("No entries yet!");
            return; 
        }
        foreach(string[] entry in entries)
        {
            Console.WriteLine($"{entry[0]}: {entry[1]}");
        }
    }

    public void WriteEntry(string entry)
    {
        EnsureFileExists();

        if (entry == null) return;

        using(StreamWriter sw = File.AppendText(filePath))
        {
            sw.WriteLine($"{DateTime.Now.ToString("yyyy-MM-dd")} || {entry}");
        }
    }


    public void SearchByDate(string date)
    {
        List<string[]> entries = GetAllEntries();

        if (entries.Count == 0)
        {
            Console.WriteLine("No entries yet!");
            return;
        }

        List<string[]> results = new List<string[]>();
        foreach (string[] entry in entries)
        {
            if (entry[0] == date)
            {
                results.Add(entry);
            }
        }

        foreach(string[] entry in results)
        {
            Console.WriteLine($"{entry[0]}: {entry[1]}");
        }
    }

}