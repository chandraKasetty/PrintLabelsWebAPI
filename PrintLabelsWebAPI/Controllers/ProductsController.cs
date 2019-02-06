using PrintLabelsWebAPI.BLL;
using PrintLabelsWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace PrintLabelsWebAPI.Controllers
{
    public class ProductsController : ApiController
    {
        private readonly IProductsBLL _ProductsBLL;
        public ProductsController(IProductsBLL productsBLL)
        {
            _ProductsBLL = productsBLL;
        }

        #region Get
        [HttpGet]
        public async Task<IEnumerable<Product>> GetAllProducts()
        {
            return await _ProductsBLL.GetAllProductsAsync();
        }
        public string GetProductById(int id)
        {
            return "value";
        }

        #endregion
        
        #region Post
        // POST: api/Products
        public void Post([FromBody]string value)
        {

        }
        #endregion

        #region Put
        // PUT: api/Products/5
        public void Put(int id, [FromBody]string value)
        {
        }
        #endregion

        #region Delete
        // DELETE: api/Products/5
        public void Delete(int id)
        {
        }
        #endregion

    }
}
