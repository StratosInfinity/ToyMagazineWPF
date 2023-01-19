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
    /// Логика взаимодействия для Profile.xaml
    /// </summary>
    public partial class Profile : Window
    {
        public Profile()
        {
            InitializeComponent();

            
        }

        private void UpBalance_Click(object sender, RoutedEventArgs e)
        {
            int newbalance=Convert.ToInt32(uppBalanceBox.Text) + Convert.ToInt32(BalanceBox.Text);
            BalanceBox.Text = Convert.ToString(newbalance);
            datatransfer.money = newbalance;
            
           
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void GoBusket_Click(object sender, RoutedEventArgs e)
        {
            Busket busketWindow = new Busket();
            busketWindow.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void GoCataloge_Click(object sender, RoutedEventArgs e)
        {
            Cataloge catalogeWindow = new Cataloge();
            catalogeWindow.Show();
            this.Close();
        }

        private void BalanceBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Window_Initialized(object sender, EventArgs e)
        {
            
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            BalanceBox.Text = Convert.ToString(datatransfer.money);
            userlogin.Text = datatransfer.ulogin;
        }
    }
}
