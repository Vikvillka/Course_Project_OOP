using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using System.Windows.Media;
using YrFit.Model;
using YrFit.Utilities;
using YrFit.View;
using System.IO;
using YrFit.Controller;
using System.Windows.Interop;
using System.Collections.ObjectModel;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace YrFit.ViewModel
{
    public class PersonVM : ViewModelBase
    {
        
        public ObservableCollection<Training> ActiveTrainings { get; set; }

        public User user;

        public PersonVM()
        {

            AddImageCommand = new RelayCommand(AddImage);

            ActiveTrainings = new ObservableCollection<Training>();
            LoadActiveTrainings();

            if (App.currentUser != null)
            {
                user = App.currentUser;
            }

            
        }

        private void LoadActiveTrainings()
        {
            using (var context = new AppDbContext())
            {
                ActiveTrainings.Clear();
                var activeTrainings = context.Trainings
                    .Where(t => t.Users.Any(u => u.Id == App.currentUser.Id) && t.DateTime > DateTime.Now)
                    .Join(context.TrainingsUser, t => t.ID, м => м.TrainingId, (t, м) => new { Training = t, TrainingsUser = м })
                    .Where(тм => тм.TrainingsUser.Status == true)
                    .Select(тм => тм.Training);

                foreach (var training in activeTrainings)
                {
                    ActiveTrainings.Add(training);
                }
            }
        }

        private string lastname;
        private string lastsurname;
        private string lastlogin;
        private string lastemail;
        private string lastnumber;

        public string Login
        {
            get { return this.user.Login; }
            set
            {
                lastlogin= this.user.Login;
                user.Login = value;
                OnPropertyChanged();
                //UpdateUserData();
            }
        } 

        public string Name
        {
            get { return this.user.Name; }
            set
            {
                lastname = this.user.Name;
                user.Name = value;
                OnPropertyChanged();
                //UpdateUserData();
            }
        }

        public string Surname
        {
            get { return this.user.Surname; }
            set
            {

                lastsurname = this.user.Surname;
                user.Surname = value;
                OnPropertyChanged();
                //UpdateUserData();
            }
        }

        public string Password
        {
            get { return this.user.Password; }
            set
            {
                user.Password = value;
                OnPropertyChanged();
                //UpdateUserData();
            }
        }

        public string PhoneNumber
        {
            get { return this.user.PhoneNumber; }
            set
            {
                lastnumber = this.user.PhoneNumber;
                user.PhoneNumber = value;
                OnPropertyChanged();
                //UpdateUserData();
            }
        }

        public string Email
        {
            get { return this.user.Email; }
            set
            {

                lastemail = this.user.Email;
                user.Email = value;
                OnPropertyChanged();
                //UpdateUserData();
            }
        }

        public byte[] AvatarImg
        {
            get { return this.user.AvatarImg; }
            set
            {
                this.user.AvatarImg = value;
                OnPropertyChanged(nameof(AvatarImg));
                UpdateUserData();
            }
        }

        public void UpdateUserImage(byte[] imageBytes)
        {
            user.AvatarImg = imageBytes;
            OnPropertyChanged(nameof(AvatarImg));
            //UpdateUserData();
        }

        private bool _isTextBoxEnabled;
        public bool IsTextBoxEnabled
        {
            get { return _isTextBoxEnabled; }
            set
            {
                _isTextBoxEnabled = value;
                OnPropertyChanged(nameof(IsTextBoxEnabled));
            }
        }

        private string _updateError;
        public string UpdateError
        {
            get { return _updateError; }
            set
            {
                _updateError = value;
                OnPropertyChanged();
            }
        }


        private bool saveBuutt = false;

        public ICommand Savecommand => new RelayCommand(ButtSave);

        public void ButtSave(object parametr)
        {
            saveBuutt = true;
            UpdateUserData();
            IsTextBoxEnabled = false;
            saveBuutt = false;
        }
        AppDbContext db = new AppDbContext();
       
        private void UpdateUserData()
        {

            if (!saveBuutt)
            {
                return;
            }

            var check = CheckFields();
            using (var context = new AppDbContext())
            {

                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        var isLoginUnique = db.Users.All(item => item.Login != Login || item.Id == App.currentUser.Id);
                        var isEmailUnique = db.Users.All(item => item.Email != Email || item.Id == App.currentUser.Id);
                        var isPhoneNumberUnique = db.Users.All(item => item.PhoneNumber != PhoneNumber || item.Id == App.currentUser.Id);

                        if (!string.IsNullOrEmpty(check) || !isLoginUnique || !isEmailUnique || !isPhoneNumberUnique)
                        {
                            UpdateError = "Данные не сохранены: " + check;

                            if (!isLoginUnique)
                            {
                                UpdateError = "Такой логин уже существует";
                            }
                            else if (!isEmailUnique)
                            {
                                UpdateError = "Такая почта уже существует";
                            }
                            else if (!isPhoneNumberUnique)
                            {
                                UpdateError = "Такой телефон уже существует";
                            }

                            transaction.Rollback();
                            MessageBox.Show("Данные будут восстановлены!");
                           
                            var updtedUser = context.Users.FirstOrDefault(u => u.Id == user.Id);
                            if (updtedUser != null)
                            {
                                user.Name = updtedUser.Name;
                                user.Surname = updtedUser.Surname;
                                user.Login = updtedUser.Login;
                                user.Email = updtedUser.Email;
                                user.PhoneNumber = updtedUser.PhoneNumber;

                                OnPropertyChanged(nameof(Name));
                                OnPropertyChanged(nameof(Surname));
                                OnPropertyChanged(nameof(Login));
                                OnPropertyChanged(nameof(Email));
                                OnPropertyChanged(nameof(PhoneNumber));
                            }

                            return;
                        }
                        else
                        {
                            user.HashedLogin = UserController.HashPassword(Login);
                            context.Users.Update(user);
                            context.SaveChanges();
                            transaction.Commit();
                            UpdateError = "Данные успешно сохранены";

                        }
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        UpdateError = "Ошибка при сохранении данных: " + ex.Message;
                    }
                }
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

        private Training _selectedTraining;
        public Training SelectedTraining
        {
            get { return _selectedTraining; }
            set
            {
                _selectedTraining = value;
                OnPropertyChanged();

            }
        }

        private ICommand deleteCommand;
        public ICommand DeleteTrainingCommand
        {
            get
            {
                if (deleteCommand == null)
                {
                    deleteCommand = new DelegateCommand(DeleteTraining, CanSignUpForTraining);
                }
                return deleteCommand;
            }
        }

        private void DeleteTraining()
        {
            if (SelectedTraining == null || user == null)
                return;

            MessageBoxResult result = MessageBox.Show("Вы уверены, что хотите отменить тренировку?", "Подтверждение", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                using (var context = new AppDbContext())
                {
                    var dbSelectedTraining = context.Trainings.FirstOrDefault(t => t.ID == SelectedTraining.ID);
                    if (dbSelectedTraining == null)
                    {
                        MessageBox.Show("Ошибка загрузки данных о тренировке из базы данных.");
                        return;
                    }
                    else
                    {

                        var userTraining = context.TrainingsUser.FirstOrDefault(ut => ut.UserId == App.currentUser.Id && ut.TrainingId == SelectedTraining.ID);
                        if (userTraining != null)
                        {
                            dbSelectedTraining.MaxPeople++;

                            userTraining.Status = false;

                            try
                            {
                                context.SaveChanges();
                                LoadActiveTrainings(); 
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Ошибка при удалении записи о тренировке: " + ex.Message);
                            }
                        }
                    }
                }
            }
        }

        private bool CanSignUpForTraining()
        {
            if (SelectedTraining == null)
            {
                return false;
            }
            else if (App.currentUser == null)
            {
                return false;
            }
            else
                return true;
        }


        public ICommand IsEnabledCommand => new RelayCommand(IsEnabled);

        private void IsEnabled(object obj)
        {
            IsTextBoxEnabled = true;
        }

        public ICommand IsEnabledFalseCommand => new RelayCommand(IsEnabledFalse);

        private void IsEnabledFalse(object obj)
        {

            IsTextBoxEnabled = false;

        }

        public ICommand ExitCommand => new RelayCommand(ExitUser);

        private void ExitUser(object obj)
        {
            var frame = (Frame)Application.Current.MainWindow.FindName("MainFrame");
            frame.Navigate(new SingInPage());
        }

        public ICommand AddImageCommand { get; private set; }

        private void AddImage(object parameter)
        {
            try
            {
                Microsoft.Win32.OpenFileDialog open = new Microsoft.Win32.OpenFileDialog();
                bool? response = open.ShowDialog();
                if (response.HasValue && response.Value)
                {
                    string path = open.FileName;
                    BitmapImage bi3 = new BitmapImage();
                    bi3.BeginInit();
                    bi3.UriSource = new Uri(path);
                    bi3.EndInit();

                    byte[] imageBytes = UserController.ConvertImageToByteArray(path);

                    UpdateUserImage(imageBytes);
                }
            }
            catch
            {
                MessageBox.Show("Ошибка: загрузка изображения");
            }
        }
    }
}

