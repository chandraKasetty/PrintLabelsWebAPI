using PrintLabelsWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintLabelsWebAPI.BLL
{
    public interface IProductsBLL
    {
        Task<List<Product>> GetAllProductsAsync();
    }
}
