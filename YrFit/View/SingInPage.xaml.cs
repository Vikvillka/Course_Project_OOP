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
using YrFit.Controller;
using YrFit.ViewModel;

namespace YrFit.View
{
    /// <summary>
    /// Логика взаимодействия для SingInPage.xaml
    /// </summary>
    public partial class SingInPage : Page
    {
        
        public SingInPage()
        {
            InitializeComponent();
            DataContext = new SingInVM();
        }

        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            var passwordBox = (PasswordBox)sender;
            var viewModel = (SingInVM)DataContext;
            viewModel.Password = passwordBox.Password;
        }


        /*    private void HLinkRegistrationClick(object sender, RoutedEventArgs e)
            {
                this.NavigationService.Navigate(new SingUpPage());
            }

            private void Button_Click(object sender, RoutedEventArgs e)
            {
                try
                {
                    if (!String.IsNullOrEmpty(txtLogin.Text) && !String.IsNullOrEmpty(txtPassword.Password))
                    {
                        var user = userControl.SingIn(txtLogin.Text.Trim().ToLower(), txtPassword.Password.Trim().ToLower());
                        App.currentUser = user;
                        this.NavigationService.Navigate(new UserMainPage());

                    }
                    else
                    {
                        MessageBox.Show("ошибка ввода", "Сстемная ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Пользователь не найден", "Сстемная ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }*/
    }
}
