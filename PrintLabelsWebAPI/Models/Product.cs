using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrintLabelsWebAPI.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Barcode { get; set; }
        public string Colour { get; set; }
        public int Size { get; set; }
        public double RRP_Price { get; set; }
        public double NOW_Price { get; set; }
    }
}