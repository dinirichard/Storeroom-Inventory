using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace App4.Core.Data
{
    public class ItemsEntity
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Name;
        public long Barcode;
        public int Quantity;
        public string Location;

    }
}
