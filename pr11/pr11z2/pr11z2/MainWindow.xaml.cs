using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace pr11z2
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

        private void button1_Click(object sender, RoutedEventArgs e)
        {


            string pattern = @"38\d{10}";


            string str = textBox1.Text;

            if (Regex.IsMatch(str, pattern, RegexOptions.IgnoreCase))
            {
                label1Check.Content = "ОК";
                label1Check.Foreground = Brushes.Green;

            }
            else
            {
                label1Check.Content = "ПОМИЛКА";
                label1Check.Foreground = Brushes.Red;
            }
        }

        

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            string pattern = @"\S{2} \d{7}";


            string str = textBox2.Text;

            if (Regex.IsMatch(str, pattern, RegexOptions.IgnoreCase))
            {
                label2Check.Content = "ОК";
                label2Check.Foreground = Brushes.Green;

            }
            else
            {
                label2Check.Content = "ПОМИЛКА";
                label2Check.Foreground = Brushes.Red;
            }
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            string pattern = @"[10311-89645]{5}";


            string str = textBox3.Text;

            if (Regex.IsMatch(str, pattern, RegexOptions.IgnoreCase))
            {
                label3Check.Content = "ОК";
                label3Check.Foreground = Brushes.Green;

            }
            else
            {
                label3Check.Content = "ПОМИЛКА";
                label3Check.Foreground = Brushes.Red;
            }
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            string pattern = "[A-Z][a-z]{3}";


            string str = textBox4.Text;

            if (Regex.IsMatch(str, pattern))
            {
                label4Check.Content = "ОК";
                label4Check.Foreground = Brushes.Green;

            }
            else
            {
                label4Check.Content = "ПОМИЛКА";
                label4Check.Foreground = Brushes.Red;
            }
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            string pattern = "[0-23]{2}:[0-59]{2}";


            string str = textBox5.Text;

            if (Regex.IsMatch(str, pattern, RegexOptions.IgnoreCase))
            {
                label5Check.Content = "ОК";
                label5Check.Foreground = Brushes.Green;

            }
            else
            {
                label5Check.Content = "ПОМИЛКА";
                label5Check.Foreground = Brushes.Red;
            }
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            string pattern = @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$";


            string str = textBox6.Text;

            if (Regex.IsMatch(str, pattern, RegexOptions.IgnoreCase))
            {
                label6Check.Content = "ОК";
                label6Check.Foreground = Brushes.Green;

            }
            else
            {
                label6Check.Content = "ПОМИЛКА";
                label6Check.Foreground = Brushes.Red;
            }
        }
    }
}
