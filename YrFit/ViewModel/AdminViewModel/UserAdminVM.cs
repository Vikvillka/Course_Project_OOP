using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using YrFit.Model;
using YrFit.Utilities;
using YrFit.View;

namespace YrFit.ViewModel.AdminViewModel
{
    internal class UserAdminVM : ViewModelBase
    {
        private ObservableCollection<User> _users;

        public ObservableCollection<User> Users
        {
            get { return _users; }
            set
            {
                _users = value;
                OnPropertyChanged();
            }
        }


        public UserAdminVM()
        {
           
            using (var context = new AppDbContext())
            {
                Users = new ObservableCollection<User>(
                    context.Users
                    .Where(u => u.Id != 1) 
                    .OrderByDescending(c => c.Id)
                    .ToList()
                );
            }
        }

        private string _searchTerm;

        public string SearchTerm
        {
            get { return _searchTerm; }
            set
            {
                _searchTerm = value;
                OnPropertyChanged();
                Search();
            }
        }

        private void Search()
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    if (!string.IsNullOrEmpty(SearchTerm))
                    {
                        int.TryParse(SearchTerm, out int id);
                        Users = new ObservableCollection<User>(
                            context.Users.Where(u => u.Id != 1)
                            .Where(u => u.Id == id || u.Login.Contains(SearchTerm) || u.Email.Contains(SearchTerm))
                            .ToList()
                        );
                    }
                    else
                    {
                        Users = new ObservableCollection<User>(
                            context.Users.Where(u => u.Id != 1)
                            .OrderByDescending(c => c.Id)
                            .ToList()
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при доступе к базе данных, попробуйте перезапустить приложение: ", "Системная ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private RelayCommand _deleteCommand;
        public RelayCommand DeleteCommand
        {
            get
            {
                if (_deleteCommand == null)
                {
                    _deleteCommand = new RelayCommand(DeleteUser, CanDeleteUser);
                }
                return _deleteCommand;
            }
        }

        private bool CanDeleteUser(object parameter)
        {
            return parameter is User;
        }

        private void DeleteUser(object parameter)
        {
            if (parameter is User user)
            {
                try
                {
                    using (var context = new AppDbContext())
                    {
                        context.Users.Remove(user);
                        context.SaveChanges();
                    }
                    Users.Remove(user);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при удалении пользователя: {ex.Message}");
                }
            }
        }

        public ICommand ExitCommand => new RelayCommand(ExitUser);

        private void ExitUser(object obj)
        {
            var frame = (Frame)Application.Current.MainWindow.FindName("MainFrame");
            frame.Navigate(new SingInPage());
        }
    }
}
