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
    /// Логика взаимодействия для Busket.xaml
    /// </summary>
    public partial class Busket : Window
    {
        public Busket()
        {
            InitializeComponent();
        }

        private void Clean_Click(object sender, RoutedEventArgs e)
        {
            datatransfer.toybusket = null;
            DataBank.sum = 0;
            tousbusket.Clear();
            allcost.Clear();
            MessageBox.Show("Корзина очищена", "", MessageBoxButton.OK, MessageBoxImage.Asterisk);
        }

        private void GoProfile_Click(object sender, RoutedEventArgs e)
        {
            Profile profileWindow = new Profile();
            profileWindow.Show();
            this.Close();
        }



        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.Hide();
           Profile profile = new Profile();
            profile.Show();
        }

        private void buskettoys_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            tousbusket.Text += datatransfer.toybusket;
            allcost.Text = Convert.ToString(DataBank.sum) + "руб.";
        }

        private void tousbusket_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Reference_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
