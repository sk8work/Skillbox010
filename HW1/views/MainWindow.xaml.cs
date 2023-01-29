using System;
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

namespace HW1.views
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void seriesBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (seriesBox.Text == "Серия") 
            {
                seriesBox.Text = "";
            }
        }

        private void seriesBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (seriesBox.Text == "")
            {
                seriesBox.Text = "Серия";
            }
        }

        private void numberBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (numberBox.Text == "Номер")
            {
                numberBox.Text = "";
            }
        }

        private void numberBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (numberBox.Text == "")
            {
                numberBox.Text = "Номер";
            }
        }
    }
}
