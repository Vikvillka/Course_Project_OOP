using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;
using YrFit.Controller;
using YrFit.View;
using YrFit.Utilities;
using System.Windows.Controls;
using YrFit;
using System.ComponentModel.DataAnnotations;
using System.Net;
using Microsoft.IdentityModel.Tokens;

namespace YrFit.ViewModel
{
    public class SingUpVM : ViewModelBase
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

        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }

        private string _surname;
        public string Surname
        {
            get { return _surname; }
            set
            {
                _surname = value;
                OnPropertyChanged();
            }
        }

        private string _email;
        public string Email
        {
            get { return _email; }
            set
            {
                _email = value;
                OnPropertyChanged();
            }
        }

        private string _phoneNumber;
        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set
            {
                _phoneNumber = value;
                OnPropertyChanged();
            }
        }

        private DateTime _dateBirth = new DateTime(2005, 1, 1);
        public DateTime BirthDate
        {
            get { return _dateBirth; }
            set
            {
                _dateBirth = value;
                OnPropertyChanged(nameof(BirthDate));
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

        public SingUpVM()
        {
            _userController = new UserController();
        }

        public ICommand SignUpCommand => new RelayCommand(SingUp);

        public void SingUp(object parameter)
        {
           
            try
            {
                var check = CheckFields();
                if (!string.IsNullOrEmpty(check))
                {
                    ErrorBox = check;
                    return;
                }
                else
                {
                    
                    string HashP = UserController.HashPassword(Password);
                    var (user, error) = _userController.CreateNewUser(Login, HashP, Name, Surname, Email, PhoneNumber, BirthDate);

                    if (!string.IsNullOrEmpty(error))
                    {
                        ErrorBox = error;
                        return;
                    }

                    else
                    { 
                        var frame = (Frame)Application.Current.MainWindow.FindName("MainFrame");

                        frame.Navigate(new SingInPage()); 
                    }
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка регистрации", "Системная ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        public string CheckFields()
        {
            string errors = string.Empty;

            errors += Validate("Login") + "\n";
            errors += Validate("Password") + "\n";
            errors += Validate("Email") + "\n";
            errors += Validate("PhoneNumber") + "\n";
            errors += Validate("Surname") + "\n";
            errors += Validate("Name") + "\n";
           
            return errors.Trim();
        }

        private string Validate(string columnName)
        {
            if (columnName == null)
                return string.Empty;

            string error = string.Empty;

            switch (columnName)
            {
                case "Login":
                    {
                        if (string.IsNullOrEmpty(Login))
                            return "Введите логин";

                        var (isValid, forbiddenSymbols) = YrFit.Controller.Validator.Validate(Login, YrFit.Controller.Validator.loginRegex);

                        if (!isValid)
                            return $"Логин не может начинаться с символов: {YrFit.Controller.Validator.JoinSymbols(forbiddenSymbols)}";
                    }
                    break;

                case "Password":
                    {
                        if (string.IsNullOrEmpty(Password))
                            return "Введите пароль";

                        if (Password.Length < 6)
                            return "Пароль слишком короткий";
                    }
                    break;

                case "Email":
                    {
                        if (string.IsNullOrEmpty(Email))
                            return "Введите почту";

                        var (isValid, _) = YrFit.Controller.Validator.Validate(Email, YrFit.Controller.Validator.eMailRegex);

                        if (!isValid)
                            return "Введённая строка не является электронной почтой";
                    }
                    break;

                case "PhoneNumber":
                    {
                        if (string.IsNullOrEmpty(PhoneNumber))
                            return "Введите телефон";

                        var (isValid, _) = YrFit.Controller.Validator.Validate(PhoneNumber, YrFit.Controller.Validator.phoneRegex);

                        if (!isValid)
                            return "Неверно введен номер телефона";
                    }
                    break;

                case "Surname":
                    {
                        if (string.IsNullOrEmpty(Surname))
                            return "Введите фамилию";

                        var (isValid, forbiddenSymbols) = YrFit.Controller.Validator.Validate(Surname, YrFit.Controller.Validator.nameRegex);

                        if (!isValid)
                            return $"В фамилии присутсвуют недопустимые символы: {YrFit.Controller.Validator.JoinSymbols(forbiddenSymbols)}";
                    }
                    break;

                case "Name":
                    {
                        if (string.IsNullOrEmpty(Name))
                            return "Введите имя";

                        var (isValid, forbiddenSymbols) = YrFit.Controller.Validator.Validate(Name, YrFit.Controller.Validator.nameRegex);

                        if (!isValid)
                            return $"В имени присутсвуют недопустимые символы: {YrFit.Controller.Validator.JoinSymbols(forbiddenSymbols)}";
                    }
                    break;

          
            }

            return error;
        }


        public ICommand HLinkAutoCommand => new RelayCommand(HLinkAuto);

        private void HLinkAuto(object obj)
        {
            var frame = (Frame)Application.Current.MainWindow.FindName("MainFrame");
            frame.Navigate(new SingInPage());
        }
    }
}