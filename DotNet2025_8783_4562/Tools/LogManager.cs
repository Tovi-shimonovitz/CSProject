using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Tools
{
    public static class LogManager
    {
        private static string logPath = "Log";

        public static string getFolderPath()
        {
            return logPath + "/" + DateTime.Now.Month.ToString();


        }

        public static string getFilePath()
        {
             return getFolderPath() + "/" + DateTime.Now.Day.ToString() + ".txt"; 

        }

        public static void writeLog(string nameProject, string nameFunc, string massege)
        {

        }
    }

  


}
