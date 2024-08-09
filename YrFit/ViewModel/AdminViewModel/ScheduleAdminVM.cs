using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using YrFit.Controller;
using YrFit.Model;
using YrFit.Utilities;
using YrFit.View;

namespace YrFit.ViewModel.AdminViewModel
{
    class ScheduleAdminVM : ViewModelBase
    {
        private ObservableCollection<Training> _trainings;

        public ObservableCollection<Training> Trainings
        {
            get { return _trainings; }
            set
            {
                _trainings = value;
                OnPropertyChanged();

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

        public ScheduleAdminVM()
        {
            _dateTime = DateTime.Now;
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
        }

        private string _type;
        public string Type
        {
            get { return _type; }
            set
            {
                _type = value;
                OnPropertyChanged(nameof(Type));
            }
        }

        private DateTime _dateTime;
        public DateTime DateTime
        {
            get { return _dateTime; }
            set
            {
                _dateTime = value;
                OnPropertyChanged(nameof(DateTime));
            }
        }

        private string _nameTrainer;
        public string NameTrainer
        {
            get { return _nameTrainer; }
            set
            {
                _nameTrainer = value;
                OnPropertyChanged(nameof(NameTrainer));
            }
        }

        private string _description;
        public string Description
        {
            get { return _description; }
            set
            {
                _description = value;
                OnPropertyChanged(nameof(Description));
            }
        }

        private int _prise;
        public int Prise
        {
            get { return _prise; }
            set
            {
                if (value >= 0)
                {
                    _prise = value;
                    OnPropertyChanged(nameof(Prise));
                }
                else
                {
                    MessageBox.Show("Стоимость должна быть положительным числом.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
        }

        private int _location;
        public int Location
        {
            get { return _location; }
            set
            {
                if (value >= 0)
                {
                    _location = value;
                    OnPropertyChanged(nameof(Location));
                }
                else
                {
                    MessageBox.Show("Номер зала должен быть положительным числом.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
        }

        private int _duration;
        public int Duration
        {
            get { return _duration; }
            set
            {
                if (value >= 0)
                {
                    _duration = value;
                    OnPropertyChanged(nameof(Duration));
                }
                else
                {
                    MessageBox.Show("Продолжительность должна быть положительным числом.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
        }


        private int _maxPeople;
        public int MaxPeople
        {
            get { return _maxPeople; }
            set
            {
                if (value >= 0)
                {
                    _maxPeople = value;
                    OnPropertyChanged(nameof(MaxPeople));
                }
                else
                {
                    MessageBox.Show("Количество человек должно быть положительным числом.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
        }

        public ICommand AllCommand => new RelayCommand(AllTrainings);
        public ICommand MondayCommand => new RelayCommand(parameter => FilterByDay(DayOfWeek.Monday));
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

        public ICommand DeleteClosedTrainingCommand => new RelayCommand(DeleteClosedTrainings);

        private void DeleteClosedTrainings(object parameter)
        {
            MessageBoxResult result = MessageBox.Show("Вы уверены, что хотите удалить закрытые тренировки?", "Подтверждение удаления", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                using (var dbContext = new AppDbContext()) 
                {
                    var closedTrainings = dbContext.Trainings
                        .Where(t => t.DateTime < DateTime.Now || t.MaxPeople <= 0)
                        .ToList();

                    dbContext.Trainings.RemoveRange(closedTrainings);
                    dbContext.SaveChanges();
                }

                LoadTrainings();
            }
        }

        public ICommand AddCommand => new RelayCommand(AddAction);

        private void AddAction(object parameter)
        {
            try
            {
                if (string.IsNullOrEmpty(Type) || DateTime == default || Duration <= 0 || Location <= 0 || Prise <= 0 || string.IsNullOrEmpty(NameTrainer) || string.IsNullOrEmpty(Description) || MaxPeople <= 0)
                {
                    MessageBox.Show("Пожалуйста, заполните все поля корректно", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Information);
                    return;
                }
                else
                {
                    var newTraining = new Training
                    {
                        Type = Type,
                        DateTime = DateTime,
                        Duration = Duration,
                        Location = Location,
                        Prise = Prise,
                        NameTrainer = NameTrainer,
                        Description = Description,
                        MaxPeople = MaxPeople
                    };

                    using (var context = new AppDbContext())
                    {
                        context.Trainings.Add(newTraining);
                        context.SaveChanges();
                    }

                    LoadTrainings();
                    Type = string.Empty;
                    DateTime = DateTime.Now;
                    Duration = 0;
                    Location = 0;
                    Prise = 0;
                    NameTrainer = string.Empty;
                    Description = string.Empty;
                    MaxPeople = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при добавлении акции: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        public ICommand DeleteCommand => new RelayCommand(DeleteAction);

        private void DeleteAction(object parameter)
        {
            try
            {
                if (parameter is Training training)
                {
                    var result = MessageBox.Show("Вы уверены, что хотите удалить эту тренеровку?", "Подтверждение удаления", MessageBoxButton.YesNo, MessageBoxImage.Question);

                    if (result == MessageBoxResult.Yes)
                    {
                        using (var context = new AppDbContext())
                        {
                            context.Trainings.Remove(training);
                            context.SaveChanges();
                        }

                        Trainings.Remove(training);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при удалении тренеровку: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }


        private Training _selectedTraining;

        public Training SelectedTraining
        {
            get => _selectedTraining;
            set
            {
                if (_selectedTraining != value)
                {
                    _selectedTraining = value;
                    OnPropertyChanged(nameof(SelectedTraining));
                }
            }
        }

        public ICommand SaveCommand => new RelayCommand(SaveAction);

        private void SaveAction(object parameter)
        {
            try
            {
                if (parameter is Training actiont)
                {
                    if (SelectedTraining != null)
                    {
                        using (var context = new AppDbContext())
                        {
                            context.Trainings.Update(SelectedTraining);
                            context.SaveChanges();
                        }

                        LoadTrainings();
                    }
                    else
                    {
                        MessageBox.Show($"Выберите элемент для изменения", "Предупреждение", MessageBoxButton.OK);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении изменений: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
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
                        Trainings = new ObservableCollection<Training>(
                            context.Trainings
                            .Where(u => u.Type.Contains(SearchTerm) || u.NameTrainer.Contains(SearchTerm) || u.ID == id)
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
    }
}
