using System;
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
        public double count = 0;
        public double countAddition = 1;
        private void sykabla_Click(object sender, RoutedEventArgs e)
        {
            count += countAddition;
            bebra1.Text = Convert.ToString(count);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (count >= 5)
            {
                count -= 5;
                bebra1.Text = Convert.ToString(count);
                countAddition += 1.333;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (count >= 20)
            {
                count -= 20;
                bebra1.Text = Convert.ToString(count);
                countAddition += 5.133;
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (count >= 50)
            {
                count -= 50;
                bebra1.Text = Convert.ToString(count);
                countAddition += 10.753;
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (count >= 100)
            {
                count -= 100;
                bebra1.Text = Convert.ToString(count);
                countAddition += 22.313;
            }
        }

      
    }
}
