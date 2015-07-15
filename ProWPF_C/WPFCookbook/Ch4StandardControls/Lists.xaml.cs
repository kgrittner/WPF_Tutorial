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
    /// Interaction logic for Lists.xaml
    /// </summary>
    public partial class Lists : Window
    {
        public Lists()
        {
            InitializeComponent();
        }


        void OnLanguageChanged(object sender, SelectionChangedEventArgs e)
        {
            _keywordList.Items.Clear();
            string[] keywords = null;
            switch (_langCombo.SelectedIndex)
            {
                case 0: // C++
                    keywords = new string[] {
						"for", "auto", "mutable", "explicit", "class", "volatile"
					};
                    break;

                case 1: // C#
                    keywords = new string[] {
						"while", "var", "implicit", "return", "where", "enum"
					};
                    break;

                case 2: // VB
                    keywords = new string[] {
						"Dim", "Select", "While", "Property", "Function", "If"
					};
                    break;

                case 3: // F#
                    keywords = new string[] {
						"let", "rec", "mutable", "module", "yield", "type"
					};
                    break;
            }
            if (keywords != null)
                Array.ForEach(keywords, keyword => _keywordList.Items.Add(keyword));
        }

        void OnChangeLanugage(object sender, RoutedEventArgs e)
        {
            var item = e.Source as MenuItem;
            _langCombo.SelectedIndex = Convert.ToInt32(item.Tag);
        }

    }
}
