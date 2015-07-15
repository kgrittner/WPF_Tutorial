using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
// using System.Linq;
using System.Threading.Tasks;
using System.Windows;

// Used from DataBinding
using System.Xml;
using ProWPF_C.Ch19_Databinding.Classes;

namespace ProWPF_C
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private static StoreDb storeDb = new StoreDb();
        public static StoreDb StoreDb
        {
            get { return storeDb; }
        }

        private static StoreDbDataSet storeDbDataSet = new StoreDbDataSet();
        public static StoreDbDataSet StoreDbDataSet
        {
            get { return storeDbDataSet; }
        }

        private List<Ch7_TheApplication.Document> documents = new List<Ch7_TheApplication.Document>();
        public List<Ch7_TheApplication.Document> Documents
        {
            get { return documents; }
            set { documents = value; }
        }
    } // End Class

    


}
