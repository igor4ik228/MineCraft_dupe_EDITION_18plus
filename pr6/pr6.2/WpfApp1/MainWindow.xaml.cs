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

namespace WpfApp1
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double czyslo1 = Convert.ToDouble(textbox1.Text);
            labelresult.Content = czyslo1;
            double czyslo2 = Convert.ToDouble(textbox2.Text);

            double rezultat=0;
            if (combobox1.Text == "Болгарія" && radiobutton1.IsChecked == true)
            {
                rezultat = (czyslo1 * czyslo2) * 100;
            }
            if (combobox1.Text == "Болгарія" && radiobutton2.IsChecked == true)
            {
                rezultat = (czyslo1 * czyslo2) * 150;
            }
            if (combobox1.Text == "Німеччина" && radiobutton1.IsChecked == true)
            {
                rezultat = (czyslo1 * czyslo2) * 160;
            }
            if (combobox1.Text == "Німеччина" && radiobutton2.IsChecked == true)
            {
                rezultat = (czyslo1 * czyslo2) * 200;
            }
            if (combobox1.Text == "Польша" && radiobutton1.IsChecked == true)
            {
                rezultat = (czyslo1 * czyslo2) * 120;
            }
            if (combobox1.Text == "Польша" && radiobutton2.IsChecked == true)
            {
                rezultat = (czyslo1 * czyslo2) * 180;
            }
            if (checkbox1.IsChecked == true) { rezultat+=czyslo2 * 50; }
            labelresult.Content =$"Вартість: ${rezultat}";
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void checkbox1_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
