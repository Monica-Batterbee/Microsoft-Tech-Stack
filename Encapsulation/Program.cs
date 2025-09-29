using System.Data;
using System.Diagnostics.CodeAnalysis;

public class Clock
{
    private int hour;
    private int minute;
    private int second;

    public void SetTime(int h,int m,int s)
    {
        hour = h;
        minute = m;
        second = s;
    }

    public void DisplayTime()
    {
        Console.WriteLine($"{hour:D2}:{minute:D2}:{second:D2}");
    }

    static void Main()
    {
        Clock myClock = new Clock();

        // Set the time
        myClock.SetTime(10, 45, 30);

        // Show the time
        myClock.DisplayTime();
    }
}