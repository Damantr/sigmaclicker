﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace sigmaclicker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    ///penino 

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public int count = 0;
        private void sykabla_Click(object sender, RoutedEventArgs e)
        {
            count++;
            bebra1.Text = Convert.ToString(count);
        }
        
    }
}
