using System;
using System.Collections.Generic;
using System.Globalization;
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

namespace WpfHomeWork7
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : IMultiValueConverter
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private int months=31;
        private int days = 1;
        private int year = 12;
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if ((int)values[0] < days || (int)values[0] > months)
            {
                values[0] = 1;
            }
            else if((int) values[0]<days||(int)values[0] > year)
            {
                values[1] = 1;
            }
            return ((DateTime)value).ToString("MM-dd-yyyy");
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            
        }
    }
}
