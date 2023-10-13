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

namespace WeatherAppWPF.UserControls
{
    /// <summary>
    /// Interaction logic for ForecastCard.xaml
    /// </summary>
    public partial class ForecastCard : UserControl
    {
        public ForecastCard()
        {
            InitializeComponent();
        }


        public string Day
        {
            get { return (string)GetValue(DayProperty); }
            set { SetValue(DayProperty, value); }
        }

        public static readonly DependencyProperty DayProperty = DependencyProperty.Register("Day", typeof(string), typeof(ForecastCard));


        public ImageSource Source
        {
            get { return (ImageSource)GetValue(SourceProperty); }
            set { SetValue(SourceProperty, value); }
        }

        public static readonly DependencyProperty SourceProperty = DependencyProperty.Register("Source", typeof(ImageSource), typeof(ForecastCard));


        public string MaxNum
        {
            get { return (string)GetValue(MaxNumProperty); }
            set { SetValue(MaxNumProperty, value); }
        }

        public static readonly DependencyProperty MaxNumProperty = DependencyProperty.Register("MaxNum", typeof(string), typeof(ForecastCard));


        public string MinNum
        {
            get { return (string)GetValue(MinNumProperty); }
            set { SetValue(MinNumProperty, value); }
        }

        public static readonly DependencyProperty MinNumProperty = DependencyProperty.Register("MinNum", typeof(string), typeof(ForecastCard));


        public string SunRise
        {
            get { return (string)GetValue(SunRiseProperty); }
            set { SetValue(SunRiseProperty, value); }
        }

        public static readonly DependencyProperty SunRiseProperty = DependencyProperty.Register("SunRise", typeof(string), typeof(ForecastCard));


        public string SunSet
        {
            get { return (string)GetValue(SunSetProperty); }
            set { SetValue(SunSetProperty, value); }
        }

        public static readonly DependencyProperty SunSetProperty = DependencyProperty.Register("SunSet", typeof(string), typeof(ForecastCard));
    }
}
