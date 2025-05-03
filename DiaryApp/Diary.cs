namespace DiaryApp;

class Diary
{
    private string _filepath;
    private Writer _writer;
    private Reader _reader;

    public Diary(string filepath)
    {
        _filepath = filepath;
        _writer = new Writer();
        _reader = new Reader();
    }

    public void ViewAllEntries()
    {
        List<string> lines = _reader.Read(_filepath);
        if (lines == null || lines.Count == 0)
        {
            Console.WriteLine("No entries found.");
            return;
        }

        foreach (string line in lines)
        {
            string[] parts = line.Split(',');
            DateTime dt = DateTime.Parse(parts[0]);
            string content = parts[1];
            Console.WriteLine($"{dt.ToString("yyyy-MM-dd HH:mm:ss")}: {content}");
        }
    }

    public void WriteEntry(string content)
    {
        DateTime dt = DateTime.Now;
        _writer.Write(_filepath, content, dt);
    }
    
    public void SearchByDate(string date)
    {
        List<string> lines = _reader.Read(_filepath);
        if (lines == null || lines.Count == 0)
        {
            Console.WriteLine("No entries found.");
            return;
        }

        foreach (string line in lines)
        {
            string[] parts = line.Split(',');
            DateTime dt = DateTime.Parse(parts[0]);
            string content = parts[1];
            if (dt.ToString("yyyy-MM-dd").Equals(date))
            {
                Console.WriteLine($"{dt.ToString("yyyy-MM-dd HH:mm:ss")}: {content}");
            }
        }
    }
}