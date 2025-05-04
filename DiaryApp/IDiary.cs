using System;

public interface IDiary
{
    void WriteEntry(string entry);
    void SearchByDate(string date);
    void ViewAllEntries();
}
