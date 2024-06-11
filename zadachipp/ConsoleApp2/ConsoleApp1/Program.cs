using System;

class TimeConverter
{
    public static string Convert12To24HourFormat(string time)
    {
        return DateTime.Parse(time).ToString("HH:mm");
    }

    public static string Convert24To12HourFormat(string time)
    {
        return DateTime.Parse(time).ToString("h:mm tt");
    }

    static void Main()
    {
        string time12HourFormat = "3:30 PM";
        string time24HourFormat = Convert12To24HourFormat(time12HourFormat);
        Console.WriteLine($"Converted {time12HourFormat} to 24-hour format: {time24HourFormat}");

        string time24HourFormatInput = "15:30";
        string time12HourFormatConverted = Convert24To12HourFormat(time24HourFormatInput);
        Console.WriteLine($"Converted {time24HourFormatInput} to 12-hour format: {time12HourFormatConverted}");
    }
}

