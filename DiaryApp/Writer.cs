namespace DiaryApp;

public class Writer
{
    public void Write(string filePath, string content, DateTime dt)
    {
        using (StreamWriter sw = File.AppendText(filePath))
        {
            sw.WriteLine($"{dt.ToString("yyyy-MM-dd HH:mm:ss")},{content}");
        }
    }
    
}