using ModelClasses.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelClasses.Interfaces
{
    public interface IProduct
    {
        IEnumerable<Product> GetProducts();
        Product GetProduct(int Id);

        string addProduct(Product product);

        void DeleteProduct(int Id);

        string UpdateProduct(Product product);
    }
}
