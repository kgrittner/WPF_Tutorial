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

namespace ProWPF_C.WPFCookbook.Ch4StandardControls
{
    /// <summary>
    /// Interaction logic for TextControls.xaml
    /// </summary>
    public partial class TextControls : Window
    {
        public TextControls()
        {
            InitializeComponent();
        }

        private void OnSubmit(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(string.Format("User: {0}, Comment:{1}{2}",
                _name.Text, Environment.NewLine, _comment.Text));
        }

    }
}
