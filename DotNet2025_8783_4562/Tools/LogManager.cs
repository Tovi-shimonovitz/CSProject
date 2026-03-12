using System;
using System.IO;

namespace Tools
{
    public static class LogManager
    {
        public static string logPath2 = "Log";

        private static string logPath = "Log";

        public static string getFolderPath()
        {
            return Path.Combine(logPath, DateTime.Now.Month.ToString());
        }

        public static string getFilePath()
        {
            return Path.Combine(getFolderPath(), DateTime.Now.Day.ToString() + ".txt");
        }

        public static void writeLog(string nameProject, string nameFunc, string message)
        {
            try
            {
                string folderPath = getFolderPath();
                string filePath = getFilePath();

                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                string logEntry = $"[{DateTime.Now:HH:mm:ss}] Project: {nameProject} | Function: {nameFunc} | Message: {message}{Environment.NewLine}";

                File.AppendAllText(filePath, logEntry);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
