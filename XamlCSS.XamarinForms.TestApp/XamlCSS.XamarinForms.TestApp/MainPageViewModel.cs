﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;
using XamlCSS.CssParsing;

namespace XamlCSS.XamarinForms.TestApp
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        private string test;
        public string Test
        {
            get => test;
            set
            {
                test = value;
                OnPropertyChange();
            }
        }

        private int testInt;
        public int TestInt
        {
            get => testInt;
            set
            {
                testInt = value;
                OnPropertyChange();
            }
        }
        private ObservableCollection<string> testList = new ObservableCollection<string>();
        public ObservableCollection<string> TestList
        {
            get => testList;
            set
            {
                testList = value;
                OnPropertyChange();
            }
        }
        private void OnPropertyChange([CallerMemberName] string property = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
