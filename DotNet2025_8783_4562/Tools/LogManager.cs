using System;
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
