﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace ProWPF_C.WPFCookbook.Ch7CommandsAndMVVM.xClasses
{
    class ImageData : INotifyPropertyChanged
    {
        public string ImagePath { get; private set; }

        public ImageData(string path)
        {
            ImagePath = path;
        }

        double _zoom = 1.0;

        public double Zoom
        {
            get { return _zoom; }
            set
            {
                _zoom = value;
                OnPropertyChanged("Zoom");
            }
        }

        protected virtual void OnPropertyChanged(string name)
        {
            var pc = PropertyChanged;
            if (pc != null)
                pc(this, new PropertyChangedEventArgs(name));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
