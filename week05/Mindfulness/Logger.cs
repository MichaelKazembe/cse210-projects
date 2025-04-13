using System;
using System.IO;

public static class Logger
{
    private static readonly string LogFilePath = "mindfulness_log.txt";

    static Logger()
    {
        if (!File.Exists(LogFilePath))
        {
            File.Create(LogFilePath).Dispose();
        }
    }

    public static void LogActivityStart(string activityName, int duration)
    {
        string logEntry = $"{DateTime.Now}: Started {activityName} for {duration} seconds.";
        AppendLog(logEntry);
    }

    public static void LogActivityEnd(string activityName)
    {
        string logEntry = $"{DateTime.Now}: Completed {activityName}.";
        AppendLog(logEntry);
    }

    private static void AppendLog(string logEntry)
    {
        File.AppendAllText(LogFilePath, logEntry + Environment.NewLine);
    }
}
