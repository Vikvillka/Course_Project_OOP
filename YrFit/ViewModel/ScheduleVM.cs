using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using YrFit.Model;
using YrFit.Controller;

using YrFit.Utilities;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System.ComponentModel;

namespace YrFit.ViewModel
{
    public class ScheduleVM : Utilities.ViewModelBase
    {
        public User user;

        private ObservableCollection<Training> _trainings;
        
        public ObservableCollection<Training> Trainings
        {
            get { return _trainings; }
            set { _trainings = value; 
                OnPropertyChanged();
                OnPropertyChanged("CanSignUpForTraining");

                if (_trainings == null || _trainings.Count == 0)
                {
                    IsEmptyImageVisible = true; 
                }
                else
                {
                    IsEmptyImageVisible = false; 
                }
            }
        }

        private bool _isEmptyImageVisible;
        public bool IsEmptyImageVisible
        {
            get { return _isEmptyImageVisible; }
            set
            {
                _isEmptyImageVisible = value;
                OnPropertyChanged();
            }
        }

        public ScheduleVM()
        {
            _selectedDate = DateTime.Now;
            LoadTrainings();
        }

        private void LoadTrainings()
        {
            using (var context = new AppDbContext())
            {
                Trainings = new ObservableCollection<Training>(
                                       context.Trainings
                                       .OrderBy(c => c.DateTime)
                                       .ToList());
            }

            if (App.currentUser != null)
            {
                user = App.currentUser;
            }
        }

        private Training _selectedTraining;
        public Training SelectedTraining
        {
            get { return _selectedTraining; }
            set
            {
                _selectedTraining = value;
                OnPropertyChanged();
                OnPropertyChanged("MaxPeople");

                if (SelectedTraining.MaxPeople == 0)
                {
                    EntryVisibility = "Visible";
                }

                else if(SelectedTraining.DateTime < DateTime.Now)
                {
                    EntryVisibility = "Visible";
                }
                else
                {
                    EntryVisibility = "";
                }
            }
        }


        public int MaxPeople
        {
            get { return SelectedTraining?.MaxPeople ?? 0; }
            set
            {
                if (SelectedTraining != null)
                {
                    SelectedTraining.MaxPeople = value;
                    OnPropertyChanged("MaxPeople");
                   
                }
            }
        }

        private string _entryVisibility;

        public string EntryVisibility
        {
            get { return _entryVisibility; }
            set
            {
                _entryVisibility = value;
                OnPropertyChanged(nameof(EntryVisibility));
            }
        }

        public ICommand AllCommand => new RelayCommand(AllTrainings);
        public ICommand MondayCommand => new RelayCommand(parameter =>FilterByDay(DayOfWeek.Monday));
        public ICommand TuesdayCommand => new RelayCommand(parameter => FilterByDay(DayOfWeek.Tuesday));
        public ICommand WednesdayCommand => new RelayCommand(parameter => FilterByDay(DayOfWeek.Wednesday));
        public ICommand ThursdayCommand => new RelayCommand(parameter => FilterByDay(DayOfWeek.Thursday));
        public ICommand FridayCommand => new RelayCommand(parameter => FilterByDay(DayOfWeek.Friday));
        public ICommand SaturdayCommand => new RelayCommand(parameter => FilterByDay(DayOfWeek.Saturday));
        public ICommand SundayCommand => new RelayCommand(parameter => FilterByDay(DayOfWeek.Sunday));
       
        private void AllTrainings(object sender)
        {
            LoadTrainings();
        }

        private void FilterByDay(DayOfWeek dayOfWeek)
        {
            LoadTrainings();
            var filteredTrainings = Trainings.Where(t => t.DateTime.DayOfWeek == dayOfWeek);
            Trainings = new ObservableCollection<Training>(filteredTrainings);
        }

        public ICommand FilterTrainingsCommand => new RelayCommand(FilterTrainings);

        private void FilterTrainings(object parameter)
        {
            LoadTrainings();
            var filteredByDateTrainings = Trainings.Where(t => t.DateTime < DateTime.Now).ToList();
            var filteredByMaxPeopleTrainings = Trainings.Where(t => t.MaxPeople <= 0).ToList();
            var filteredTrainings = filteredByDateTrainings.Concat(filteredByMaxPeopleTrainings).Distinct().ToList();
            Trainings = new ObservableCollection<Training>(filteredTrainings);
        }

        private ICommand signUpCommand;
        public ICommand SignUpCommand
        {
            get
            {
                if (signUpCommand == null)
                {
                    signUpCommand = new DelegateCommand(SignUpForTraining, CanSignUpForTraining);
                }
                return signUpCommand;
            }
        }

        private void SignUpForTraining()
        {
            if (SelectedTraining == null || user == null)
                return;

            using (var context = new AppDbContext())
            {
                var existingTrainingUser = context.TrainingsUser.FirstOrDefault(u => u.UserId == App.currentUser.Id && u.TrainingId == SelectedTraining.ID);
                var dbSelectedTraining = context.Trainings.FirstOrDefault(t => t.ID == SelectedTraining.ID);

                if (existingTrainingUser != null)
                {
                    if (existingTrainingUser.Status)
                    {
                        MessageBox.Show("У вас уже есть активная запись на эту тренировку", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Information);
                        return;
                    }
                    else
                    {
                        dbSelectedTraining.MaxPeople--;
                        existingTrainingUser.Status = true;
                    }
                }
                else
                {
                    
                    if (dbSelectedTraining == null)
                    {
                        MessageBox.Show("Ошибка загрузки данных о тренировке из базы данных.");
                        return;
                    }
                    else
                    {
                        dbSelectedTraining.MaxPeople--;
                        SelectedTraining.MaxPeople = dbSelectedTraining.MaxPeople; // Обновляем значение в SelectedTraining
                        context.Trainings.Update(dbSelectedTraining);
                        OnPropertyChanged("MaxPeople");
                        OnPropertyChanged("SelectedTraining");

                        var newTrainingUser = new TrainingUser
                        {
                            TrainingId = dbSelectedTraining.ID,
                            UserId = App.currentUser.Id,
                            AttendanceDate = DateTime.Now,
                            Status = true
                        };

                        context.TrainingsUser.Add(newTrainingUser);
                    }
                }

                try
                {
                    context.SaveChanges();
                    LoadTrainings();

                    MessageBox.Show("Вы успешно записались на тренировку. В своем профиле вы можете управлять активными записями");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при сохранении записи о тренировке: " + ex.Message);
                }
            }
        }


        private bool CanSignUpForTraining()
        {
            if (SelectedTraining == null)
            {
                return false;
            }
            else if (SelectedTraining.MaxPeople <= 0)
            {
                return false;
            }
            else if (SelectedTraining.DateTime <= DateTime.Now)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private DateTime _selectedDate;
        public DateTime SelectedDate
        {
            get { return _selectedDate; }
            set
            {
                _selectedDate = value;
                OnPropertyChanged(nameof(SelectedDate));
                FilterByDateTrainings();
            }
        }

        private void FilterByDateTrainings()
        {
            LoadTrainings();
            var filteredTrainings = Trainings.Where(t => t.DateTime.Date >= SelectedDate.Date);
            Trainings = new ObservableCollection<Training>(filteredTrainings);
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
                        Trainings = new ObservableCollection<Training>(
                            context.Trainings
                            .Where(u => u.Type.Contains(SearchTerm) || u.NameTrainer.Contains(SearchTerm))
                            .ToList()
                        );
                    }
                    else
                    {
                        Trainings = new ObservableCollection<Training>(
                            context.Trainings
                            .OrderByDescending(t => t.DateTime)
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

    }
}