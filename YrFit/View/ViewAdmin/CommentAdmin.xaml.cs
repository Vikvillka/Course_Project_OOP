using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using YrFit.ViewModel.AdminViewModel;

namespace YrFit.View.ViewAdmin
{
    /// <summary>
    /// Логика взаимодействия для CommentAdmin.xaml
    /// </summary>
    public partial class CommentAdmin : UserControl
    {
        public CommentAdmin()
        {
            InitializeComponent();
            DataContext = new CommentAdminVM();
        }
    }
}
