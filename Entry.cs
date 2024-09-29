using System;

public class Entry
{
    public DateTime Date { get; set; }
    public string Text { get; set; }

    public Entry(string text)
    {
        Date = DateTime.Now;
        Text = text;
    }

    public void Display()
    {
        Console.WriteLine($"{Date}: {Text}");
    }
}
