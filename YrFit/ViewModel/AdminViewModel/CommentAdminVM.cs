using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YrFit.Model;
using YrFit.Utilities;
using System.Windows.Input;
using System.Windows;

namespace YrFit.ViewModel.AdminViewModel
{
    class CommentAdminVM :ViewModelBase
    {
        private ObservableCollection<Comment> _comments;

        public ObservableCollection<Comment> Comments
        {
            get { return _comments; }
            set
            {
                _comments = value;
                OnPropertyChanged();
            }
        }

        public CommentAdminVM()
        {
            using (var context = new AppDbContext())
            {
                Comments = new ObservableCollection<Comment>(
                 context.Comments.Include(c => c.User)
                .OrderByDescending(c => c.DateTime)
                .ToList());
            }
        }

        public ICommand DeleteCommand => new RelayCommand(DeleteComment);

        private void DeleteComment(object parameter)
        {
            if (parameter is Comment comment)
            {
                try
                {
                    var result = MessageBox.Show("Вы уверены, что хотите удалить этот комментарий?", "Подтверждение удаления", MessageBoxButton.YesNo, MessageBoxImage.Question);

                    if (result == MessageBoxResult.Yes)
                    {
                        using (var context = new AppDbContext())
                        {
                            context.Comments.Remove(comment);
                            context.SaveChanges();
                        }

                        Comments.Remove(comment);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при удалении комментария: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
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
                       
                        Comments = new ObservableCollection<Comment>(
                            context.Comments.Include(c => c.User)
                            .Where(u => u.User.Login.Contains(SearchTerm) || u.CommentText.Contains(SearchTerm))
                            .ToList()
                        );
                    }
                    else
                    {
                        Comments = new ObservableCollection<Comment>(
                            
                             context.Comments.Include(c => c.User)
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
    }
}
