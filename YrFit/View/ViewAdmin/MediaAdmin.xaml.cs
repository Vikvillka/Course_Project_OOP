using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using YrFit.ViewModel.AdminViewModel;

namespace YrFit.View.ViewAdmin
{
    /// <summary>
    /// Логика взаимодействия для MediaAdmin.xaml
    /// </summary>
    public partial class MediaAdmin : UserControl
    {
        public MediaAdmin()
        {
            InitializeComponent();
            DataContext = new MediaAdminVM();
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

        private void TextBlock_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (sender is TextBlock textBlock && textBlock.DataContext is YrFit.Model.MediaTraining model)
            {
                string url = model.MediaContent;
                if (!string.IsNullOrEmpty(url))
                {
                    Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
                }
            }
        }
    }
}
