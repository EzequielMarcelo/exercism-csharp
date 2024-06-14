using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

static class LogLine
{
    public static string Message(string logLine) => logLine.Split(':').LastOrDefault().Trim();

    public static string LogLevel(string logLine) => 
        logLine.Substring(logLine.IndexOf('[') + 1, logLine.IndexOf(']') - 1).ToLower();

    public static string Reformat(string logLine) => $"{Message(logLine)} ({LogLevel(logLine)})";
}
