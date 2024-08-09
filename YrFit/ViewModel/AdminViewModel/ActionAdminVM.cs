using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YrFit.Model;
using YrFit.Utilities;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using YrFit.Controller;

namespace YrFit.ViewModel.AdminViewModel
{
    class ActionAdminVM : ViewModelBase
    {
        private ObservableCollection<YrFit.Model.Action> _actions;

        public ObservableCollection<YrFit.Model.Action> Actions
        {
            get { return _actions; }
            set
            {
                _actions = value;
                OnPropertyChanged();
            }
        }

        public ActionAdminVM()
        {
           UpdateCollection();
        }

        private void UpdateCollection()
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    Actions = new ObservableCollection<YrFit.Model.Action>(
                    context.Actions.Include(c => c.User)
                         .OrderByDescending(c => c.DateTime)
                        .ToList());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при получении достпа к базе данных: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            
        }

        private YrFit.Model.Action _selectedAction;
        public YrFit.Model.Action SelectedAction
        {
            get { return _selectedAction; }
            set
            {
                _selectedAction = value;
                OnPropertyChanged(nameof(SelectedAction));

               
            }
        }

        private string _title;
        public string Title
        {
            get { return _title; }
            set
            {
                _title = value;
                OnPropertyChanged(nameof(Title));
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

        private byte[] _actionImg;
        public byte[] ActionImg
        {
            get => _actionImg;
            set
            {
                _actionImg = value;
                OnPropertyChanged(nameof(ActionImg));
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

                        Actions = new ObservableCollection<YrFit.Model.Action> (
                            context.Actions.Include(c => c.User)
                            .Where(u => u.Description.Contains(SearchTerm) || u.Title.Contains(SearchTerm))
                            .ToList()
                        );
                    }
                    else
                    {
                        Actions = new ObservableCollection<YrFit.Model.Action>(
                             context.Actions.Include(c => c.User)
                             .OrderByDescending(c => c.DateTime)
                            .ToList());

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при доступе к базе данных, попробуйте перезапустить приложение: ", "Системная ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        public ICommand SaveCommand => new RelayCommand(SaveAction);

        private void SaveAction(object parameter)
        {
            try
            {
                if (parameter is YrFit.Model.Action actiont)
                {
                    if (SelectedAction != null)
                    {
                        if (string.IsNullOrWhiteSpace(SelectedAction.Title) || string.IsNullOrWhiteSpace(SelectedAction.Description))
                        {
                            MessageBox.Show("Пожалуйста, заполните обязательные поля: Название и Описание.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                            return;
                        }

                        MessageBoxResult result = MessageBox.Show("Хотите ли вы изменить изображение?", "Подтверждение", MessageBoxButton.YesNo);
                        if (result == MessageBoxResult.Yes)
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

                                SelectedAction.ActionImg = imageBytes;

                                using (var context = new AppDbContext())
                                {
                                    context.Actions.Update(SelectedAction);
                                    context.SaveChanges();
                                }
                            }
                        }
                        else
                        {

                            using (var context = new AppDbContext())
                            {
                                context.Actions.Update(SelectedAction);
                                context.SaveChanges();
                            }
                        }

                        UpdateCollection();
                    }

                }
                else
                {
                    MessageBox.Show($"Выберите элемент для изменения", "Предупреждение", MessageBoxButton.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении изменений: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        public ICommand DeleteCommand => new RelayCommand(DeleteAction);

        private void DeleteAction(object parameter)
        {
            try
            {
                if (parameter is YrFit.Model.Action actiont)
                {
                    var result = MessageBox.Show("Вы уверены, что хотите удалить эту акцию?", "Подтверждение удаления", MessageBoxButton.YesNo, MessageBoxImage.Question);

                    if (result == MessageBoxResult.Yes)
                    {
                        using (var context = new AppDbContext())
                        {
                            context.Actions.Remove(actiont);
                            context.SaveChanges();
                        }

                        Actions.Remove(actiont);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при удалении акции: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        public ICommand AddCommand => new RelayCommand(AddAction);

        private void AddAction(object parameter)
        {

            if (string.IsNullOrWhiteSpace(Title) || string.IsNullOrWhiteSpace(Description) || ActionImg == null)
            {
                MessageBox.Show("Пожалуйста, заполните обязательные поля: Название, Описание и Изображение.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            try
            {
                var newAction = new YrFit.Model.Action
                {
                    Title = Title,
                    Description = Description,
                    DateTime = DateTime.Now,
                    ActionImg = ActionImg,
                    UserId = App.currentUser.Id,
                    PostCategory = 0
                };

                using (var context = new AppDbContext())
                {
                    context.Actions.Add(newAction);
                    context.SaveChanges();
                }

                Actions.Add(newAction);

                Title = string.Empty;
                Description = string.Empty;
                ActionImg = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при добавлении акции: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        public ICommand AddImageCommand => new RelayCommand(AddImage);

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

                    ActionImg = imageBytes;
                    OnPropertyChanged(nameof(ActionImg));
                    using (var context = new AppDbContext())
                    {

                        context.SaveChanges();
                    }

                }
            }
            catch
            {
                MessageBox.Show("Ошибка: загрузка изображения");
            }
        }

    }
}
