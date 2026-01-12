using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

using SQLite;
using SQLiteNetExtensions;
using ComanCosminLab7.Models;

namespace ComanCosminLab7.Models
{
    public class ListProduct
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        [ForeignKey("ShopList")]
        public int ShopListID { get; set; }
    
        public int ProductID { get; set; }
    }
}
