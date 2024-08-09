using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using YrFit.Model;
using YrFit.Utilities;

namespace YrFit.ViewModel
{
    class CommentVM : ViewModelBase
    {

        public User user;

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

        public CommentVM()
        {
            using (var context = new AppDbContext())
            {
                Comments = new ObservableCollection<Comment>(
                 context.Comments.Include(c => c.User)
                .OrderByDescending(c => c.DateTime)
                .ToList());
            }

            if (App.currentUser != null)
            {
                user = App.currentUser;
            }
        }

        private string _commentText;
        public string CommentText
        {
            get { return _commentText; }
            set
            {
                _commentText = value;
                OnPropertyChanged();
            }
        }

        private string _errorComment;
        public string ErrorComment
        {
            get { return _errorComment; }
            set
            {
                _errorComment = value;
                OnPropertyChanged();
            }
        }

        public ICommand AddCommentCommand => new RelayCommand(AddComment);

        public void AddComment(object parameter)
        {
            try
            {
                if (user == null)
                {
                    ErrorComment = "Вы не вошли как пользователь";
                    return;
                }

                if (string.IsNullOrEmpty(CommentText))
                {
                    ErrorComment = "Комментарий пустой";
                    return;
                }

                Comment newComment = new Comment
                {
                    UserId = user.Id,
                    CommentText = CommentText,
                    DateTime = DateTime.Now
                };

                using (var context = new AppDbContext())
                {
                    context.Comments.Add(newComment);
                    context.SaveChanges();
                }

                CommentText = string.Empty;
                ErrorComment = string.Empty;

                using (var context = new AppDbContext())
                {
                    Comments = new ObservableCollection<Comment>(
                        context.Comments.Include(c => c.User)
                        .OrderByDescending(c => c.DateTime)
                        .ToList()
                    );
                }
            }
            catch (Exception ex)
            {
                ErrorComment = "Произошла ошибка при добавлении комментария: " + ex.Message;
            }
        }

    }
}
