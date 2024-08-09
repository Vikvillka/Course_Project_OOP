using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using YrFit.Utilities;
using YrFit.View;
using YrFit.ViewModel.AdminViewModel;

namespace YrFit.ViewModel
{
    class NavigationVM : ViewModelBase
    {
        private object _currentView;
        public object CurrentView
        {
            get { return _currentView; }
            set { _currentView = value; OnPropertyChanged(); }
        }


        public ICommand HomeCommand { get; set; }
        public ICommand ScheduleCommand { get; set; }
        public ICommand ActionsCommand { get; set; }
        public ICommand PersonCommand { get; set; }
        public ICommand CommentCommand { get; set; }
        public ICommand MediaCommand { get; set; }

        public ICommand UserAdminCommand { get; set; }
        public ICommand CommentAdminCommand { get; set; }
        public ICommand ActionAdminCommand { get; set; }
        public ICommand ScheduleAdminCommand { get; set; }
        public ICommand EntryAdminCommand { get; set; }
        public ICommand MediaAdminCommand { get; set; }

        private void Home(object obj) => CurrentView = new HomeVM();
        private void Schedule(object obj) => CurrentView = new ScheduleVM();
        private void Actions(object obj) => CurrentView = new ActionsVM();
        private void Person(object obj) => CurrentView = new PersonVM();
        private void Comment(object obj) => CurrentView = new CommentVM();
        private void Media(object obj) => CurrentView = new MediaVM();

        private void UserAdmin(object obj) => CurrentView = new UserAdminVM();
        private void CommentAdmin(object obj) => CurrentView = new CommentAdminVM();
        private void ActionAdmin(object obj) => CurrentView = new ActionAdminVM();
        private void ScheduleAdmin(object obj) => CurrentView = new ScheduleAdminVM();
        private void EntryAdmin(object obj) => CurrentView = new EntryAdminVM();
        private void MediaAdmin(object obj) => CurrentView = new MediaAdminVM();


        public NavigationVM()
        {
            HomeCommand = new RelayCommand(Home);
            ScheduleCommand = new RelayCommand(Schedule);
            ActionsCommand = new RelayCommand(Actions);
            PersonCommand = new RelayCommand(Person);
            CommentCommand = new RelayCommand(Comment);
            MediaCommand = new RelayCommand(Media);

            UserAdminCommand = new RelayCommand(UserAdmin);
            CommentAdminCommand = new RelayCommand(CommentAdmin);
            ActionAdminCommand = new RelayCommand(ActionAdmin);
            ScheduleAdminCommand = new RelayCommand(ScheduleAdmin);
            EntryAdminCommand = new RelayCommand(EntryAdmin);
            MediaAdminCommand = new RelayCommand(MediaAdmin);

            CurrentView = new HomeVM();
        }
    }
}
