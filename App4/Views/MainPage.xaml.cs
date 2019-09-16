using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Windows.Storage;
using Windows.UI.Xaml.Controls;

namespace App4.Views
{
    public sealed partial class MainPage : Page, INotifyPropertyChanged
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void Set<T>(ref T storage, T value, [CallerMemberName]string propertyName = null)
        {
            if (Equals(storage, value))
            {
                return;
            }

            storage = value;
            OnPropertyChanged(propertyName);
        }

        private void OnPropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        private async void Btn_folderAsync_ClickAsync(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            Windows.Storage.StorageFolder local_CacheFolder = ApplicationData.Current.LocalFolder;
            await Windows.System.Launcher.LaunchFolderAsync(local_CacheFolder);
        }

        private void Page_Loaded(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            StorageFolder.GetPath();
        }
    }
}
