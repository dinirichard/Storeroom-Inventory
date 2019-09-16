using App4.Core;
using App4.Core.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Telerik.UI.Xaml.Controls.Data;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Content Dialog item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace App4.Views
{
    public sealed partial class ContentDialog1 : ContentDialog
    {

        private Items selectedContent;

        public int quantityCount;
        public int hold = 0;

        public ContentDialog1()
        {
            this.InitializeComponent();
        }

        public ContentDialog1(Items sampleOrder)
        {
            this.InitializeComponent();

            selectedContent = sampleOrder;

            this.DataContext = selectedContent;
            this.StackQuantity.DataContext = new Items();
        }

        private void ContentDialog_Loaded(object sender, RoutedEventArgs e)
        {
            this.ItemName.Text = selectedContent.Name;
            this.LocationName.Text = selectedContent.Location;
            this.BarcodeName.Text = selectedContent.Barcode.ToString();
            quantityCount = selectedContent.Quantity;
            
            //this.Amount.Maximum = selectedContent.Quantity;
            this.StackQuantity.DataContext = new Items();
            this.QuantityName.Text = quantityCount.ToString();
        }

        private void RadNumericBox_ValueChanged(object sender, EventArgs e)
        {
            
            this.Amount.Maximum = selectedContent.Quantity;

            if ((int)Amount.Value > hold)
            {
                quantityCount -= 1;
            }
            else if ((int)Amount.Value < hold)
            {
                quantityCount += 1;
            }

            hold = (int)Amount.Value;
        }

        private void ContentDialog_PrimaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
            selectedContent.Quantity = quantityCount;
            App4.Core.SqliteDataAccess.UpdateItemQuantity(selectedContent);
        }

        private void ContentDialog_SecondaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
        }

        private void Personel_btn_Click(object sender, RoutedEventArgs e)
        {

        }

        
    }
}
