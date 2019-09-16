using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using App4.Core;
using App4.Core.Models;
using App4.Core.Services;
using Telerik.UI.Xaml.Controls.Grid;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace App4.Views
{
    public sealed partial class TelerikInventoryPage : Page, INotifyPropertyChanged
    {
        public ObservableCollection<SampleOrder> Source { get; } = new ObservableCollection<SampleOrder>();
        public ObservableCollection<Items> Source2 { get; } = new ObservableCollection<Items>();

        public bool HasRowDetails { get; set; }
        public Items SelectedOrder = new Items();

        // TODO WTS: Change the grid as appropriate to your app, adjust the column definitions on TelerikInventoryPage.xaml.
        // For help see http://docs.telerik.com/windows-universal/controls/raddatagrid/gettingstarted
        // You may also want to extend the grid to work with the RadDataForm http://docs.telerik.com/windows-universal/controls/raddataform/dataform-gettingstarted
        public TelerikInventoryPage()
        {
            InitializeComponent();
        }

        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            Source.Clear();
            Source2.Clear();

            // TODO WTS: Replace this with your actual data
            var data = await SampleDataService.GetGridDataAsync();
            var data2 = SqliteDataAccess.LoadItems(); ;

            foreach (var item in data)
            {
                Source.Add(item);
            }

            foreach (var item in data2)
            {
                Source2.Add(item);
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

        //private void ProductButton_Click(object sender, RoutedEventArgs e)
        //{
        //    HasRowDetails = !HasRowDetails;


        //    var cb = (CheckBox)sender;
        //    var newCheckedItem = (Items)sender;
        //    if (HasRowDetails)
        //    {
        //        this.grid.ShowRowDetailsForItem(newCheckedItem);
        //    }
        //    else
        //    {
        //        this.grid.HideRowDetailsForItem(newCheckedItem);
        //    }
        //}

        private async void GetButton_Click(object sender, RoutedEventArgs e)
        {

            ContentDialog1 contentDialog1 = new ContentDialog1(SelectedOrder);
            contentDialog1.PrimaryButtonText = "Get";
            contentDialog1.RequestedTheme = ElementTheme.Light;
            contentDialog1.Title = "Get " + SelectedOrder.Name;
            await contentDialog1.ShowAsync();


        }

        private void RestockButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Grid_SelectionChanged(object sender, Telerik.UI.Xaml.Controls.Grid.DataGridSelectionChangedEventArgs e)
        {
            
            var item = (Items) this.grid.SelectedItem;

            HasRowDetails = !HasRowDetails;

            if (HasRowDetails && !SelectedOrder.Equals(null))
            {
                this.grid.ShowRowDetailsForItem(this.grid.SelectedItem);
            }
            else
            {
                this.grid.HideRowDetailsForItem(item);
            }

            if (SelectedOrder != null)
            {
                HasRowDetails = false;
            }
            SelectedOrder = item;


        }

        private void Grid_DoubleTapped(object sender, Windows.UI.Xaml.Input.DoubleTappedRoutedEventArgs e)
        {

        }

        private async void AddNewItem_btn_Click(object sender, RoutedEventArgs e)
        {
            AddItemDialog addItemDialog = new AddItemDialog( this.Frame);
            await addItemDialog.ShowAsync();
        }

        private void Grid_Tapped(object sender, Windows.UI.Xaml.Input.TappedRoutedEventArgs e)
        {

        }
    }
}
