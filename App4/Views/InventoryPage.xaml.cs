using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using App4.Core;
using App4.Core.Models;
using App4.Core.Services;

using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace App4.Views
{
    public sealed partial class InventoryPage : Page, INotifyPropertyChanged
    {
        public ObservableCollection<Items> Source { get; } = new ObservableCollection<Items>();

        // TODO WTS: Change the grid as appropriate to your app, adjust the column definitions on InventoryPage.xaml.
        // For more details see the documentation at https://docs.microsoft.com/windows/communitytoolkit/controls/datagrid
        public InventoryPage()
        {
            InitializeComponent();
        }

        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            Source.Clear();

            // TODO WTS: Replace this with your actual data
            var data = SqliteDataAccess.LoadItems();

            var data2 = await ItemsServices.AllItems();

            foreach (var item in data)
            {
                Source.Add(item);
            }
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
    }
}
