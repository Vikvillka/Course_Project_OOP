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
using YrFit.ViewModel;

namespace YrFit.View
{
    /// <summary>
    /// Логика взаимодействия для SingUpPage.xaml
    /// </summary>
    public partial class SingUpPage : Page
    {
        public SingUpPage()
        {
            InitializeComponent();
            DataContext = new SingUpVM();
        }

        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            var passwordBox = (PasswordBox)sender;
            var viewModel = (SingUpVM)DataContext;
            viewModel.Password = passwordBox.Password;
        }

    }
}
