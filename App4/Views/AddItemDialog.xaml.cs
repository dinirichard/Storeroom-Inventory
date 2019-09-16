using App4.Core.Models;
using App4.Core;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Telerik.UI.Xaml.Controls.Input;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Content Dialog item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace App4.Views
{
    public sealed partial class AddItemDialog : ContentDialog
    {

        public Items newItem = new Items();

        Frame _frame;
        public AddItemDialog()
        {
            this.InitializeComponent();
            newItem.IsValidationEnabled = true;
            this.Amount.Value = 0;

        }

        public AddItemDialog(Frame frame)
        {
            this.InitializeComponent();
            newItem.IsValidationEnabled = true;
            this.Amount.Value = 0;
            _frame = frame;

        }

        private void ContentDialog_PrimaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {

            newItem.Quantity = (int) this.Amount.Value;
            Debug.WriteLine(newItem.Name + "\n" + newItem.Location + "\n" + newItem.Barcode + "\n" + newItem.Quantity);

            if (!newItem.ValidateProperties())
            {
                //NameError.Text = newItem.GetErrors(newItem.Name).;
                newItem.GetErrors(newItem.Name);
                args.Cancel = true;
            }
            else
            {

                App4.Core.SqliteDataAccess.SaveItem(newItem);
                _frame.Navigate(typeof(TelerikInventoryPage), null);
            }


            //Debug.WriteLine(newItem.Name + "\n" + newItem.Location + "\n" + newItem.Barcode + "\n" + newItem.Quantity);
            //Debug.WriteLine("---------------------------------");
            //newItem.Name = this.stringEditor.Text;
            //Debug.WriteLine(this.stringEditor.Text);
        }

        private void ContentDialog_SecondaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
        }

        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void ItemName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Amount_ValueChanged(object sender, EventArgs e)
        {
            var nb = (RadNumericBox) sender;
            if (nb.Value != null)
            {
                var value = (int)nb.Value;
                var rounded = value;

                nb.Value = rounded;
            }
        }
    }
}
