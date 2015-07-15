using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.ComponentModel;
using System.Diagnostics;
using ProWPF_C.WPFCookbook.Ch6DataBinding.xClasses;

namespace ProWPF_C.WPFCookbook.Ch6DataBinding
{
    /// <summary>
    /// Interaction logic for GroupingData2.xaml
    /// </summary>
    public partial class GroupingData2 : Window
    {
        public GroupingData2()
        {
            InitializeComponent();

            var processes = Process.GetProcesses();
            var view = CollectionViewSource.GetDefaultView(processes);
            view.GroupDescriptions.Add(new PropertyGroupDescription("Threads.Count", new ThreadsToGroupConverter()));
            view.SortDescriptions.Add(new SortDescription("Threads.Count", ListSortDirection.Ascending));
            DataContext = processes;
        }
    }
}
