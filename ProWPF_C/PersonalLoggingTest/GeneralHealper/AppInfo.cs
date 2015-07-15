using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace GeneralHealper
{
    public static class AppInfo
    {
        
        public static string JobName { get { return GetAppName(); } }
        public static Assembly ParentAssembly { get { return GetAssembly(); } }
        public static string ExecutingFile { get { return Path.ChangeExtension(GetExecutingFile(), "exe"); } }
        public static string ExecutingDirectory { get { return GetExecutingDirectory(); } }
        public static string ExecutingDirectoryNoBin { get { return RemoveBinDownFromPath(GetExecutingFile()); } }
        public static bool IsConsoleApp { get { return SetIsConsoleApp(); } }




        public static bool SetIsConsoleApp()
        {
            try
            {
                if (Assembly.GetEntryAssembly().Location.Length > 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        private static Assembly GetAssembly()
        {
            var currentAssembly = Assembly.GetExecutingAssembly();
            var callerAssemblies = new StackTrace().GetFrames()
                        .Select(x => x.GetMethod().ReflectedType.Assembly).Distinct()
                        .Where(x => x.GetReferencedAssemblies().Any(y => y.FullName == currentAssembly.FullName));
            var initialAssembly = callerAssemblies.Last();

            string sJobName = initialAssembly.GetName().Name;
            return initialAssembly;
        }

        private static string GetAppName()
        {
            return ParentAssembly.GetName().Name;
        }

        private static string GetExecutingFile()
        {
            return PathUriToNormal(ParentAssembly.GetName().CodeBase);
        }

        public static string PathUriToNormal(string path){
            UriBuilder uri = new UriBuilder(path);
            path = Uri.UnescapeDataString(uri.Path);
            path = Path.GetFullPath(path);
            return path;
        }

        private static string GetExecutingDirectory()
        {
            string path = PathUriToNormal(ParentAssembly.GetName().CodeBase);
            path = Path.GetDirectoryName(path);
            return path;
        }

        private static string RemoveBinDownFromPath(string path)
        {
            // C:\folder\folder\bin\debug = C:\folder\folder\
            Regex regAddSlash = new Regex("\\$");
            Regex regRemoveFromBinToEnd = new Regex(@"(\bbin\b){1}.*$");
            if (regRemoveFromBinToEnd.IsMatch(path))
            {
                path = regRemoveFromBinToEnd.Replace(path, "");
                if (!regAddSlash.IsMatch(path))
                {
                    path += "\\";
                }

                return path;
            }
            else
            {
                return null;
            }
            
        }


    }
}
