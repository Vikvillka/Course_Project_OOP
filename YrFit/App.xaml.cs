using System.Collections.ObjectModel;
using System.Configuration;
using System.Data;
using System.Windows;
using YrFit.Model;
using YrFit.ViewModel;
using YrFit.View;
using MaterialDesignThemes.Wpf;
using System.IO;

namespace YrFit
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
       
        public static User currentUser = null;

        public ObservableCollection<Training> Trainings { get; set; }
        AppDbContext db = new AppDbContext();

        /* public App()
         {
             db = new AppDbContext();
             db.Database.EnsureCreated();
             Trainings = new ObservableCollection<Training>(db.Trainings);
         }*/

       /* private void OnStartup(object sender, StartupEventArgs e)
        {

            Directory.SetCurrentDirectory(AppDomain.CurrentDomain.BaseDirectory);
        }*/


        protected override void OnExit(ExitEventArgs e)
        {
            base.OnExit(e);
            db.SaveChanges();
           
        }
    }

}
