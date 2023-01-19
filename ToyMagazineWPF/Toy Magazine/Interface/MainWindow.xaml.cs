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

namespace Toy_Magazine
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

        }


        private void Enter_Click(object sender, RoutedEventArgs e)
        {
            datatransfer.ulogin = logbox.Text;
            string Log = logbox.Text;
            string Pass = passwordBox.Password;
            if (Log == DataBank.login && Pass == DataBank.password)
            {
                
                Profile profileWindow = new Profile();
                profileWindow.Show();
                this.Close();
            }
            else
            {
                if (Log == DataBank.login1 && Pass == DataBank.password1)
                {

                    Profile profileWindow = new Profile();
                    profileWindow.Show();                  
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Введенные данные не верны", "", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                }
            }

        }



        private void ExitApp_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        private void showPassord_Checked(object sender, RoutedEventArgs e)
        {
            passwordTxtBox.Text = passwordBox.Password;
            passwordBox.Visibility = Visibility.Collapsed;
            passwordTxtBox.Visibility = Visibility.Visible;
        }
        private void showPassord_Unchecked(object sender, RoutedEventArgs e)
        {
            passwordBox.Password = passwordTxtBox.Text;
            passwordTxtBox.Visibility = Visibility.Collapsed;
            passwordBox.Visibility = Visibility.Visible;
        }


    }
}
