using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Web.Configuration;
using System.IO;
using System.Reflection;

namespace GeneralHealper
{
    public static class Write
    {

        // Test if Console or Web
        public static void AppSettings(string key, string newValue)
        {
            if (AppInfo.IsConsoleApp)
            {
                ToAppSettingsAppConfig(key, newValue);
            }
            else
            {
                ToAppSettingsWebConfig(key, newValue);
            }
        }



        private static void ToAppSettingsWebConfig(string key, string newValue)
        {
            // Web
            Configuration config = WebConfigurationManager.OpenWebConfiguration("/");
            config.AppSettings.Settings[key].Value = newValue;
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }

        private static void ToAppSettingsAppConfig(string key, string newValue)
        {
            // Console
            string dir = AppInfo.ExecutingFile;
            Configuration config = ConfigurationManager.OpenExeConfiguration(dir);
            config.AppSettings.Settings[key].Value = newValue;
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }

        public static void ExecutionDirToAppSettings(string key)
        {
            string dir = AppInfo.ExecutingDirectoryNoBin;
            try
            {
                if (!Directory.Exists(dir))
                {
                    throw new DirectoryNotFoundException(dir);
                }

                if (ConfigurationManager.AppSettings[key] != dir)
                {
                    AppSettings(key, dir);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }



    }//END CLASS
}
