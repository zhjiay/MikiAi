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
    /// WorkSpaceRegion.xaml 的交互逻辑
    /// </summary>
    public partial class WorkSpaceRegion : UserControl
    {
        public WorkSpaceRegion()
        {
            InitializeComponent();
        }

        private void xAddProject_Click(object sender, RoutedEventArgs e)
        {
            Button btn=(Button)sender;
            Console.WriteLine("test");
            Console.WriteLine(btn.Background.ToString());
        }

        private void xEditProject_Click(object sender, RoutedEventArgs e)
        {

        }

        private void xWorkProject_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
