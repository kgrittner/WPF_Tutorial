using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.Configuration;

namespace GeneralHelperTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void cmdTest_Click(object sender, RoutedEventArgs e)
        {
         //ToAppSettingsAppConfig("myTest", "asdfsdfjksjdf");
            string dr = GeneralHealper.AppInfo.JobName;
            string dr23 = GeneralHealper.AppInfo.ExecutingFile;
            string dr20 = GeneralHealper.AppInfo.ExecutingDirectory;
            string dr21 = GeneralHealper.AppInfo.ExecutingDirectoryNoBin;


            string dr3 = Assembly.GetExecutingAssembly().GetName().CodeBase;
            

            GeneralHealper.Write.AppSettings("myTest", "WasasdfUP");
            GeneralHealper.Write.ExecutionDirToAppSettings("dirMain");

            string adf = GeneralHealper.AppInfo.ExecutingDirectory;
            string sdfa = GeneralHealper.AppInfo.JobName;
        }


        private static void ToAppSettingsAppConfig(string key, string newValue)
        {
            // Console

            string sDirConfig = "C:\\Users\\KarlFast\\Documents\\Projects\\Run\\Classes\\PersonalLoggingTest\\GeneralHelperTest\\bin\\Debug\\GeneralHealper.exe";
            string sDirConfig2 = @"C:\Users\KarlFast\Documents\Projects\Run\Classes\PersonalLoggingTest\GeneralHelperTest\GeneralHelperTest.exe";
            string sDirConfig3 = @"C:\Users\KarlFast\Documents\Projects\Run\Classes\PersonalLoggingTest\GeneralHelperTest\bin\debug\GeneralHelperTest.exe";
            string sDirConfig4 = @"C:\Users\KarlFast\Documents\Projects\Run\Classes\PersonalLoggingTest\GeneralHelperTest\bin\debug\GeneralHelperTest.exe";
                                  //"C:\\Users\\KarlFast\\Documents\\Projects\\Run\\Classes\\PersonalLoggingTest\\GeneralHelperTest\\bin\\GeneralHelperTest.exe"

            try
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(sDirConfig);
                config.AppSettings.Settings[key].Value = newValue;
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
            }
            catch (Exception)
            {
            }

            try
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(sDirConfig2);
                config.AppSettings.Settings[key].Value = newValue;
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
            }
            catch (Exception)
            {
            }

            try
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(sDirConfig3);
                config.AppSettings.Settings[key].Value = newValue;
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
            }
            catch (Exception)
            {
            }

            try
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(sDirConfig4);
                config.AppSettings.Settings[key].Value = newValue;
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
            }
            catch (Exception)
            {
            }



            //Configuration config = ConfigurationManager.OpenExeConfiguration(sDirConfig);
            //config.AppSettings.Settings[key].Value = newValue;
            //config.Save(ConfigurationSaveMode.Modified);
            //ConfigurationManager.RefreshSection("appSettings");
        }






    }
}
//string tst = AppDomain.CurrentDomain.BaseDirectory;
//            string tst5 = AppDomain.CurrentDomain.RelativeSearchPath;
//            string tst6 = Assembly.GetExecutingAssembly().EscapedCodeBase;