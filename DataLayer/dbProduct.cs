using ModelClasses.Interfaces;
using ModelClasses.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class dbProduct : IProduct
    {
        AssignmentContext _context;
        public dbProduct()
        {
            _context = new AssignmentContext();
        }

        public Product GetProduct(int Id)
        {
            try
            {
                Product product = _context.products.SingleOrDefault(p => p.ProductId == Id);

                if (product == null)
                    throw new KeyNotFoundException();

                return product;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IEnumerable<Product> GetProducts()
        {
            try
            {
                return _context.products.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public string addProduct(Product product)
        {
            try
            {

                _context.products.Add(product);
                _context.SaveChanges();
                return "Added";

            }
            catch (Exception)
            {

                throw;
            }
        }

        public void DeleteProduct(int Id)
        {
            try
            {
                Product product = _context.products.Find(Id);
                if (product == null)
                    throw new KeyNotFoundException();


                _context.products.Remove(product);
                _context.SaveChanges();

            }
            catch (Exception)
            {

                throw;
            }
        }

        public string UpdateProduct(Product product)
        {
            try
            {
                if (product != null && product.ProductId > 0)
                {
                    var currentProduct = _context.products.Where(p => p.ProductId == product.ProductId).SingleOrDefault();
                    if (currentProduct != null)
                    {
                        currentProduct.ProductId = product.ProductId;
                        currentProduct.ProductName = product.ProductName;
                        currentProduct.Price = product.Price;
                        currentProduct.Quantity = product.Quantity;

                        _context.products.Attach(currentProduct);
                        _context.Entry(currentProduct).State = EntityState.Modified;
                        _context.SaveChanges();
                        return "Successfully updated!";
                    }
                    else
                    {
                        throw new KeyNotFoundException();
                    }
                }
                else
                    throw new KeyNotFoundException();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
