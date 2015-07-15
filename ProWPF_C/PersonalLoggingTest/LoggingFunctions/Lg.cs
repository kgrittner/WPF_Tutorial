using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using System.Configuration;

namespace LoggingFunctions
{
    public static class Lg
    {
        private static string logLocation = "";
        private static bool firstRun = true;
        private static string nl = Environment.NewLine;

        //--------------------------------
        // Logging Preformatted Tools
        //--------------------------------

        public static void Info(string msg)
        {
            CheckIfFirstRun();
            write(msg = DateTime.Now.ToLongTimeString() + ": " + msg);
        }

        public static void InfoNoTime(string msg)
        {
            CheckIfFirstRun();
            write(msg);
        }

        public static void Error(string msg)
        {
            CheckIfFirstRun();
            write("@@@");
            write("@@@ ERROR @@@");
            write("@@@");
            write("@@@ " + msg);
        }

        public static void Warning(string msg)
        {
            CheckIfFirstRun();
            write("@@@");
            write("@@@ WARNING @@@");
            write("@@@");
            write("@@@ " + msg);
        }

        public static void FatalError(Exception ex, string title)
        {
            CheckIfFirstRun();

            write(Environment.NewLine + Environment.NewLine);
            write(DateTime.Now.ToLongTimeString());
            write(" ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            write(" @@@@@ FATAL ERROR @@@@@ " + Environment.NewLine + title);
            write(" ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            write(Environment.NewLine);

            write(DateTime.Now.ToLongTimeString() + ": " + " Source: " + ex.Source + nl + nl +
                            " TargetSite: " + ex.TargetSite.Name.ToString() + nl +
                            nl + " Message: " + ex.Message + nl + nl +
                            " Stack Trace: " + ex.StackTrace + nl + nl);
        }

        public static void Title(string msg)
        {
            CheckIfFirstRun();
            write(Environment.NewLine + Environment.NewLine);
            write("------------------------------------------------------------------");
            write("***");
            write("*** " + msg);
            write("***");
        }

        public static void StartingHeader(string jobName)
        {
            CheckIfFirstRun();
            string lineSpace = FormatMidLine(jobName + " Started ", "-");
            write(Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine);
            write(" ================================================================");
            write(" " + lineSpace + " " + jobName + " Started " + lineSpace);
            write(" ================================================================");
        }

        public static void SuccessfulFinish(string jobName)
        {
            CheckIfFirstRun();
            string lineSpace = FormatMidLine(jobName + " Finished Successfully ", "*");
            write(Environment.NewLine + Environment.NewLine);
            write(" **** SUCCESS ************************************** SUCCESS ****");
            write(" " + lineSpace + " " + jobName + " Finished Successfully " + lineSpace);
            write(" ****************************************************************");
            write(Environment.NewLine);
        }

        public static void FailedFinish(string jobName)
        {
            CheckIfFirstRun();
            string lineSpace = FormatMidLine(jobName + " HAS FAILED!!! ", "*");
            write(Environment.NewLine + Environment.NewLine);
            write(" **** FAILED! ************************************** FAILED! ****");
            write(" " + lineSpace + " " + jobName + " HAS FAILED!!! " + lineSpace);
            write(" ****************************************************************");
            write(Environment.NewLine);
        }

        public static void HeaderStars(string title)
        {
            CheckIfFirstRun();
            string lineSpace = FormatMidLine(title, "*");

            write(Environment.NewLine + Environment.NewLine);
            write(" ****************************************************************");
            write(" " + lineSpace + " " + title + " " + lineSpace);
            write(" ****************************************************************");
            write(Environment.NewLine);
        }

        public static void AssemblyReflection()
        {
            CheckIfFirstRun();
            HeaderStars("LoggingFunctions .dll Assembly Info");
            write("Assembly FullName: " + System.Reflection.Assembly.GetExecutingAssembly().FullName + nl);
            write("Assembly Location: " + System.Reflection.Assembly.GetExecutingAssembly().Location + nl);
            write("Running on Machine: " + System.Environment.MachineName + nl);
            write("------------------------------------------------------------------" + nl);
        }


        //--------------------------------
        // Functions
        //--------------------------------

        public static string FormatMidLine(string msg, string lineChar) {
            string myLine = "------------------------------------------------------------------";
            double myLineCount = myLine.Length;
            double msgCount = msg.Length;
            double some = myLineCount - msgCount;
            some = some / 2 - 2;

            string result = "";
            for (int i = 0; i < some; i++)
            {
                result += lineChar;
            }
            return result;
        }

        public static void CheckIfFirstRun()
        {
            if (firstRun)
            {
                logLocation = ConfigurationManager.AppSettings["LgLogPathInfo"];
                logLocation = GetFileNameWithDate(logLocation);
                firstRun = false;
            }
        }

        private static string GetFileNameWithDate(string fileName)
        {
            return fileName += "_" + DateTime.Now.ToString("yyyy-MM-dd") + ".txt";
        }

        private static void write(string msg)
        {
            using (StreamWriter sw = new StreamWriter(logLocation, true))
            {
                sw.WriteLine(msg);
            }
        }

        


    }
}
