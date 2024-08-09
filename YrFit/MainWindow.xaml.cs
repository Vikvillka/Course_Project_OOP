using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using YrFit.View;
using YrFit.View.ViewAdmin;

namespace YrFit
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void WindowLoaded(object sender, RoutedEventArgs e)
        {
            MainFrame.NavigationService.Navigate(new SingInPage());
        }

        private void AuthFrameContentRendered(object sender, EventArgs e)
        {
            MainFrame.NavigationService.Navigate(new SingInPage());
        }

        private void MainFrameLoaded(object sender, RoutedEventArgs e)
        {
            MainFrame.NavigationService.Navigate(new SingInPage());
        }

        private void CloseApp_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

      
    }
}