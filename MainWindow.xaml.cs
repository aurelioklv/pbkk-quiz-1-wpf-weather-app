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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WeatherAppWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void textblockSearch_MouseDown(object sender, MouseButtonEventArgs e)
        {
            textblockSearch.Focus();
        }

        private void textSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(textblockSearch.Text) && textblockSearch.Text.Length > 0)
            {
                textblockSearch.Visibility = Visibility.Collapsed;
            }
            else
            {
                textblockSearch.Visibility = Visibility.Visible;
            }
        }

        private void PowerButton_Click(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
