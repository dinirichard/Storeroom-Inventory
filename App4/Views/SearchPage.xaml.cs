using App4.Core;
using App4.Core.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace App4.Views
{
    public sealed partial class SearchPage : Page, INotifyPropertyChanged
    {
        public ObservableCollection<Items> Source { get; } = new ObservableCollection<Items>();
        public bool HasRowDetails { get; set; }
        public Items SelectedOrder = new Items();
        public SearchPage()
        {
            InitializeComponent();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private ComboBoxItem obj;

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

        

        

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var combo = (ComboBox)sender;
            var obj2 = (ComboBoxItem)combo.SelectedItem;

            obj = obj2;

            if (obj.Content.ToString().Equals("Search by Name"))
            {
                search_box.Visibility = Visibility.Visible;
                search_barcode.Visibility = Visibility.Collapsed;
            }
            else
            {
                search_box.Visibility = Visibility.Collapsed;
                search_barcode.Visibility = Visibility.Visible;
            }

        }

        private void Search_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            var data = new List<Items>();
            if (obj.Content.ToString().Equals("Search by Name"))
            {
                data = App4.Core.SqliteDataAccess.SearchByName(search_box.Text);
            }
            else
            {
                long barcode = (long)search_barcode.Value;
                data = App4.Core.SqliteDataAccess.SearchByBarcode(barcode);
            }



            Source.Clear();

            // TODO WTS: Replace this with your actual data
            //var data = SqliteDataAccess.LoadItems();

            foreach (var item in data)
            {
                Source.Add(item);
            }
        }

        private void Grid_SelectionChanged(object sender, Telerik.UI.Xaml.Controls.Grid.DataGridSelectionChangedEventArgs e)
        {
            var item = (Items)this.grid.SelectedItem;

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

        private async void GetButton_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
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

        private void Grid_Tapped(object sender, Windows.UI.Xaml.Input.TappedRoutedEventArgs e)
        {

        }

        private void Grid_DoubleTapped(object sender, Windows.UI.Xaml.Input.DoubleTappedRoutedEventArgs e)
        {

        }
    }
}
