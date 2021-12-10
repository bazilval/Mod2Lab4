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

namespace Mod2Lab4
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

        string Converter(string rate, string sum)
        {
            try
            {
                return Convert.ToString(Convert.ToDouble(rate) * Convert.ToDouble(sum));
            }
            catch
            {
                /*MessageBox.Show("Ошибка ввода!");*/
                return "Ошибка!";
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
                dollarResult.Text = Converter(dollarRate.Text, dollarSum.Text);            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            euroResult.Text = Converter(euroRate.Text, euroSum.Text);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            grivnaResult.Text = Converter(grivnaRate.Text, grivnaSum.Text);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            dramResult.Text = Converter(dramRate.Text, dramSum.Text);
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            inchesResult.Text = Converter("0,0254", inchesValue.Text);
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            footsResult.Text = Converter("0,3048", footsValue.Text);
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            milesResult.Text = Converter("1609,34", milesValue.Text);
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            verstsResult.Text = Converter("1066,8", verstsValue.Text);
        }
    }
}
