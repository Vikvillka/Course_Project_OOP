using System;
using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using YrFit.Model;
using YrFit.Utilities;
using System.Windows;

namespace YrFit.ViewModel.AdminViewModel
{
    public class EntryAdminVM : ViewModelBase
    {
        private ObservableCollection<TrainingUser> _entryes;

        public ObservableCollection<TrainingUser> Entryes
        {
            get { return _entryes; }
            set
            {
                _entryes = value;
                OnPropertyChanged();
            }
        }

        public EntryAdminVM()
        {
            using (var context = new AppDbContext())
            {
                Entryes = new ObservableCollection<TrainingUser>(
                        context.TrainingsUser
                            .Include(tu => tu.User) 
                            .Include(tu => tu.Training) 
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
                        Entryes = new ObservableCollection<TrainingUser>(
                            context.TrainingsUser.Include(tu => tu.User)
                           .Include(tu => tu.Training)
                            .Where(u => u.UserId == id || u.TrainingId == id || u.User.Login.Contains(SearchTerm))
                            .ToList()
                        );
                    }
                    else
                    {
                        Entryes = new ObservableCollection<TrainingUser>(
                       context.TrainingsUser
                           .Include(tu => tu.User)
                           .Include(tu => tu.Training)
                           .ToList());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при доступе к базе данных, попробуйте перезапустить приложение: ", "Системная ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }
    }
}
