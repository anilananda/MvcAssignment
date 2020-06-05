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
    public class dbOrder : IOrder
    {
        AssignmentContext _context;
        public dbOrder()
        {
            _context = new AssignmentContext();
        }
        public Order submitOrder(Order orderDetails)
        {
            try
            {
                var pp = _context.orders.Add(orderDetails);

                //update quantity...

                _context.SaveChanges();


                Product objProruct = _context.products.Find(orderDetails.ProductId);

                if (objProruct == null)
                    return new Order();

                objProruct.Quantity = objProruct.Quantity - 1;

                _context.Entry(objProruct).State = EntityState.Modified;
                _context.SaveChanges();


                return pp;
            }
            catch (Exception)
            {

                throw;
            }
        }

        
    }
}
