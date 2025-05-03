namespace DiaryApp;

public class Reader
{
    public List<string> Read(string filePath)
    {
        List<string> lines = new List<string>();
        if (!File.Exists(filePath))
        {
            throw new FileNotFoundException();
        }
        else
        {
            using (StreamReader sr = File.OpenText(filePath))
            {
                string? line;
                while ((line = sr.ReadLine()) != null)
                {
                    lines.Add(line);
                }
                return lines;
            }
        }
    }
}