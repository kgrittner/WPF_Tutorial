﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProWPF_C.WPFCookbook.Ch6DataBinding.xClasses.ValidatingData
{
    class Person : INotifyPropertyChanged
    {
        protected virtual void OnPropertyChanged(string propName)
        {
            var pc = PropertyChanged;
            if (pc != null)
                pc(this, new PropertyChangedEventArgs(propName));
        }

        string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Name cannot be empty");
                _name = value;
                OnPropertyChanged("Name");
            }
        }

        int _age;
        public int Age
        {
            get { return _age; }
            set
            {
                if (value < 1)
                    throw new ArgumentException("Age must be a positive integer");
                _age = value;
                OnPropertyChanged("Age");
            }

        }

        string _email;
        public string Email
        {
            get { return _email; }
            set
            {
                _email = value;
                OnPropertyChanged("Email");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}