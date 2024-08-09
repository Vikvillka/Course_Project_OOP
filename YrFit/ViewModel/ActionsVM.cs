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
    internal class ActionsVM :  ViewModelBase
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


        public ActionsVM()
        {
            using (var context = new AppDbContext())
            {
                Actions = new ObservableCollection<YrFit.Model.Action>(
                    context.Actions.Include(c => c.User)
                     .OrderByDescending(c => c.DateTime)
                
                    .ToList()
                );
            }
        }
    }
}
