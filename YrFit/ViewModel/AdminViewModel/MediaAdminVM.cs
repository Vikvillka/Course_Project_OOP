using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using YrFit.Model;
using YrFit.Utilities;
using YrFit.View;

namespace YrFit.ViewModel.AdminViewModel
{
    public class MediaAdminVM : ViewModelBase
    {
        private ObservableCollection<MediaTraining> _mediasTraining;


        public ObservableCollection<MediaTraining> MediasTraining
        {
            get { return _mediasTraining; }
            set
            {
                _mediasTraining = value;
                OnPropertyChanged();
            }

        }

        public MediaAdminVM() 
        {
            using (var context = new AppDbContext())
            {
                MediasTraining = new ObservableCollection<MediaTraining>(
                    context.MediaTraining
                    .ToList()
                );
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

        private string _mediaContent;
        public string MediaContent
        {
            get { return _mediaContent; }
            set
            {
                _mediaContent = value;
                OnPropertyChanged(nameof(MediaContent));
            }
        }

        public ICommand DeleteCommand => new RelayCommand(DeleteMedia);

        private void DeleteMedia(object parameter)
        {
            if (parameter is MediaTraining media)
            {
                MessageBoxResult result = MessageBox.Show($"Вы действительно хотите удалить '{media.Title}'?", "Подтверждение удаления", MessageBoxButton.YesNo, MessageBoxImage.Question);

                if (result == MessageBoxResult.Yes)
                {
                    try
                    {
                        using (var context = new AppDbContext())
                        {
                            context.MediaTraining.Remove(media);
                            context.SaveChanges();
                        }
                        MediasTraining.Remove(media);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при удалении элемента: {ex.Message}");
                    }
                }
            }
        }

        public ICommand AddCommand => new RelayCommand(AddAction);

        private void AddAction(object parameter)
        {
            if (string.IsNullOrWhiteSpace(Title) || string.IsNullOrWhiteSpace(Description) || string.IsNullOrWhiteSpace(MediaContent))
            {
                MessageBox.Show("Пожалуйста, заполните все обязательные поля.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            try
            {
                var newAction = new MediaTraining
                {
                    Title = Title,
                    Description = Description,
                    UserId = App.currentUser.Id,
                    PostCategory = PostCategory.Trainings,
                    MediaContent = MediaContent
                };

                using (var context = new AppDbContext())
                {
                    context.MediaTraining.Add(newAction);
                    context.SaveChanges();
                }

                MediasTraining.Add(newAction);

                Title = string.Empty;
                Description = string.Empty;
                MediaContent = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при добавлении акции: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
