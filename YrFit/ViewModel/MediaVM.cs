using Microsoft.EntityFrameworkCore;
using Microsoft.Web.WebView2.WinForms;
using Microsoft.Web.WebView2.Wpf;
using Microsoft.Win32;
using System.Collections.ObjectModel;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using YrFit.Controller;
using YrFit.Model;
using YrFit.Utilities;
using YrFit.View;

namespace YrFit.ViewModel
{
    class MediaVM : ViewModelBase
    {
        private ObservableCollection<MediaTraining> _mediasTraining;


        public ObservableCollection<MediaTraining> MediasTraining
        {
            get { return _mediasTraining; }
            set
            {
                _mediasTraining = value;
                OnPropertyChanged();
            }

        }

        private MediaTraining _selectedTrain;
        public MediaTraining SelectedTrain
        {
            get { return _selectedTrain; }
            set
            {
                MediaContent = value?.MediaContent;
                _selectedTrain = value;
                OnPropertyChanged(nameof(SelectedTrain));
                OnPropertyChanged(nameof(MediaContent));
            }
        }

        public MediaVM()
        {

            using (var context = new AppDbContext())
            {
                MediasTraining = new ObservableCollection<MediaTraining>(
                    context.MediaTraining
                    .ToList()
                );
            }

        }

        private string _mediaContent = "https://www.youtube.com/@Nobadaddiction/videos"; 

        public string MediaContent
        {
            get { return _mediaContent; }
            set
            {
                _mediaContent = value ?? "https://www.youtube.com/@Nobadaddiction/videos"; 
            }
        }


    }
}