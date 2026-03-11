using System;
<<<<<<< HEAD
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using System.Xml.Linq;


namespace Tools;

public static class LogManager
  {
    private static string path = "Log";
    public static  string todayPathFile() {
        return DateTime.Now.Day.ToString();
    }
    public static string monthPathDirectory() {
        return DateTime.Now.Month.ToString();
    }
    public static void writeToLog(string projectName, string funcName, string message) {
        string monthDir=monthPathDirectory();
        string dayPath=todayPathFile();
        string dirMonthPath= Path.Combine(path.FullName, monthDir);
        if (!Directory.Exists(dirMonthPath))
        {
            Directory.createDirectory(dirMonthPath);
        }
        string fileDayPath = Path.Combine(dirMonthPath, $"{dayPath}.log");
        using (StreamWriter writer = new StreamWriter(fileDayPath, true))
        {

            writer.WriteLine($"{DateTime.Now}\t{projectName}.{funcName}:\t{message}");
        }
        }
    
    }
=======
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
>>>>>>> 262c371c2246fa228663baa2d8c829bafbb00717
