﻿using System;
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

namespace ProWPF_C.Ch17_ControlTemplates
{
    /// <summary>
    /// Interaction logic for SimpleCustomButtons.xaml
    /// </summary>
    public partial class SimpleCustomButtons : Window
    {
        public SimpleCustomButtons()
        {
            InitializeComponent();
        }


        private void Clicked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("You clicked " + ((Button)sender).Name);
        }



    }
}
