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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Label.views.startRegion
{
    /// <summary>
    /// SettingRegion.xaml 的交互逻辑
    /// </summary>
    public partial class SettingRegion : UserControl
    {
        public SettingRegion()
        {
            InitializeComponent();
        }

        private void Click_Reset(object sender, RoutedEventArgs e)
        {
            Button b= (Button)sender;
            Console.WriteLine(b.ToString());
        }

        private void Click_Save(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            Console.WriteLine(b.ToString());
        }
    }
}
