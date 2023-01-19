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

namespace Toy_Magazine
{
    /// <summary>
    /// Логика взаимодействия для Cataloge.xaml
    /// </summary>
    public partial class Cataloge : Window
    {
        public Cataloge()
        {
            InitializeComponent();
        }

        private void Profile_Click(object sender, RoutedEventArgs e)
        {
            Profile profileWindow = new Profile();
            profileWindow.Show();
            this.Close();
        }

        private void Busket_Click(object sender, RoutedEventArgs e)
        {
            Busket busketWindow = new Busket();
            busketWindow.Show();
            this.Close();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void BuyCar_Click(object sender, RoutedEventArgs e)
        {
            datatransfer.toybusket += "\n Машинка " + "1000руб.";
            DataBank.sum = DataBank.sum + 1000;
            MessageBox.Show("Товар добавлен в корзину", "", MessageBoxButton.OK, MessageBoxImage.Asterisk);
        }

        private void BuyDoll_Click(object sender, RoutedEventArgs e)
        {
            datatransfer.toybusket += "\n Кукла " + "1500руб.";
            DataBank.sum = DataBank.sum + 1500;
            MessageBox.Show("Товар добавлен в корзину", "", MessageBoxButton.OK, MessageBoxImage.Asterisk);
        }

        private void BuySworld_Click(object sender, RoutedEventArgs e)
        {
            datatransfer.toybusket += "\n Мечь " + "2000руб.";
            DataBank.sum = DataBank.sum + 2000;
            MessageBox.Show("Товар добавлен в корзину", "", MessageBoxButton.OK, MessageBoxImage.Asterisk);
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}
