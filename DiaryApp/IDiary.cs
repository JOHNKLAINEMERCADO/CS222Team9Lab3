using System;

public interface IDiary
{
    public void WriteEntry(string entry);
    public void SearchByDate(string date);
    public void ViewAllEntries();
}
