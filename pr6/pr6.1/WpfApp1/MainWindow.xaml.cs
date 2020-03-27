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
            if (combobox1.Text == "Дерево" && radiobutton1.IsChecked == true)
            {
                rezultat = (czyslo1 * czyslo2) * 0.25;
            }
            if (combobox1.Text == "Дерево" && radiobutton2.IsChecked == true)
            {
                rezultat = (czyslo1 * czyslo2) * 0.30;
            }
            if (combobox1.Text == "Метал" && radiobutton1.IsChecked == true)
            {
                rezultat = (czyslo1 * czyslo2) * 0.05;
            }
            if (combobox1.Text == "Метал" && radiobutton2.IsChecked == true)
            {
                rezultat = (czyslo1 * czyslo2) * 0.10;
            }
            if (combobox1.Text == "Металопластик" && radiobutton1.IsChecked == true)
            {
                rezultat = (czyslo1 * czyslo2) * 0.15;
            }
            if (combobox1.Text == "Металопластик" && radiobutton2.IsChecked == true)
            {
                rezultat = (czyslo1 * czyslo2) * 0.20;
            }
            if (checkbox1.IsChecked == true) { rezultat += 35; }
            labelresult.Content =$"Вартість: {rezultat} грн.";
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
