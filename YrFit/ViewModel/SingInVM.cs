using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;
using YrFit.Controller;
using YrFit.Utilities;
using YrFit.Model;
using System.Windows.Controls;
using YrFit.View;
using System.IO;

namespace YrFit.ViewModel
{
    public class SingInVM : ViewModelBase
    {
       

        private string _login;
        public string Login
        {
            get { return _login; }
            set
            {
                _login = value;
                OnPropertyChanged();
            }
        }

       
        private string _password;
        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                OnPropertyChanged();
            }
        }

        private string _errorBox;
        public string ErrorBox
        {
            get { return _errorBox; }
            set
            {
                _errorBox = value;
                OnPropertyChanged();
            }
        }

        private UserController _userController;

        public SingInVM()
        {
            _userController = new UserController();

        }

        public ICommand SignInCommand => new RelayCommand(SignIn);

        private void SignIn(object parameter)
        {
            try
            {

                if (string.IsNullOrEmpty(Login) || string.IsNullOrEmpty(Password))
                {
                    ErrorBox = "Пожалуйста заполните все поля";
                }
                else
                {
                    ErrorBox = "";


                    var hashedPassword = UserController.HashPassword(Password.Trim());

                    var (user, error) = _userController.SingIn(Login.Trim(), hashedPassword, StringComparison.Ordinal);
                    if (error == null)
                    {
                        App.currentUser = user;

                        var frame = (Frame)Application.Current.MainWindow.FindName("MainFrame");

                        if (user.Role == Model.Role.Admin)
                        {
                            frame.Navigate(new AdminMainPage());
                        }
                        else if (user.Role == Model.Role.User)
                        {
                            frame.Navigate(new UserMainPage());
                        }
                        else
                        {
                            MessageBox.Show("Ошибка при входе в приложение, возможно проблемы с базой данных,", "Системная ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                        }
                    }
                    else { ErrorBox = error; }
                }
            }
            catch (Exception)
            {
                ErrorBox = "Пользователь c таким логином не найден";
            }
        }

        public ICommand HLinkRegistrationCommand => new RelayCommand(HLinkRegistration);

        private void HLinkRegistration(object obj)
        {
            var frame = (Frame)Application.Current.MainWindow.FindName("MainFrame");
            frame.Navigate(new SingUpPage());
        }
    }
}
