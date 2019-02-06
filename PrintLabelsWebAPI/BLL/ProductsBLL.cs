using PrintLabelsWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace PrintLabelsWebAPI.BLL
{
    public class ProductsBLL: IProductsBLL
    {
        public async Task<List<Product>> GetAllProductsAsync()
        {
            var prod =  new List<Product>()
            {
                new Product{Id = 1, Barcode = "00001234", Colour= "Red", Name="Shoe1", NOW_Price = 19.99, RRP_Price = 1.99, Size = 1},
                new Product{Id = 2, Barcode = "00001235", Colour= "Black", Name="Shoe2", NOW_Price = 199.99, RRP_Price = 1.99, Size = 1},
                new Product{Id = 3, Barcode = "00001236", Colour= "White", Name="Shoe3", NOW_Price = 19.99, RRP_Price = 1.99, Size = 1},
                new Product{Id = 4, Barcode = "00001237", Colour= "Brown", Name="Shoe4", NOW_Price = 19.99, RRP_Price = 1.99, Size = 1},
                new Product{Id = 5, Barcode = "00001238", Colour= "Red", Name="Shoe5", NOW_Price = 19.99, RRP_Price = 1.99, Size = 1},
                new Product{Id = 6, Barcode = "00001239", Colour= "Black", Name="Shoe6", NOW_Price = 19.99, RRP_Price = 1.99, Size = 1}
            };

            return await Task.Run(() => prod);
           
        }
    }
}