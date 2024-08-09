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
using YrFit.ViewModel;

namespace YrFit.View
{
    /// <summary>
    /// Логика взаимодействия для Shedule.xaml
    /// </summary>
    public partial class Shedule : UserControl
    {
        public Shedule()
        {
            InitializeComponent();
            DataContext = new ScheduleVM();
        }

        /*private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            // Получаем контекст данных
            var viewModel = (ScheduleVM)DataContext;
            // Устанавливаем SelectedTraining
            //viewModel.SelectedTraining = viewModel.Trainings.FirstOrDefault();
        }*/
    }
}
