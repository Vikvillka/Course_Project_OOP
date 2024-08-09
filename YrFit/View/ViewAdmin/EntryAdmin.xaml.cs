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
    /// Логика взаимодействия для EntryAdmin.xaml
    /// </summary>
    public partial class EntryAdmin : UserControl
    {
        public EntryAdmin()
        {
            InitializeComponent();
            DataContext = new EntryAdminVM();
        }

        private int currentIndex = -1;

        private void Up_Click(object sender, RoutedEventArgs e)
        {
            if (currentIndex > 0)
            {
                currentIndex--;
                dataGrid.SelectedIndex = currentIndex;
                dataGrid.ScrollIntoView(dataGrid.SelectedItem);
            }
        }
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            if (currentIndex < dataGrid.Items.Count - 1)
            {
                currentIndex++;
                dataGrid.SelectedIndex = currentIndex;
                dataGrid.ScrollIntoView(dataGrid.SelectedItem);
            }
        }
    }
}
