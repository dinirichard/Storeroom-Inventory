using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Prism.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using SQLite;

namespace App4.Core.Models
{
    public class Items : ValidatableBindableBase, INotifyPropertyChanged
    {
        private int id;
        private string name;
        private long barcode;
        private int quantity;
        private string location;

        [PrimaryKey, AutoIncrement]
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        [Required(ErrorMessage = "Name is required.")]
        [MinLength(3,ErrorMessage = "Min is 3")]
        public string Name
        {   get { return name; }
            set { SetProperty(ref name, value); }
        }

        [Required(ErrorMessage = "Barcode is required")]
        [RegularExpression("([1-9][0-9]*)", ErrorMessage = "Please enter valid integer Number")]
        public long Barcode
        {
            get { return barcode; }
            set { barcode = value; }
        }
        [Required(ErrorMessage = "Quantity is required")]
        [Range(0, long.MaxValue, ErrorMessage = "Please enter valid integer Number")]
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        public string Location
        {
            get { return location; }
            set { location = value; }
        }





    }
}
