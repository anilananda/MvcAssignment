using ModelClasses.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class dbOrderHistory : ModelClasses.Interfaces.IOrderHistory
    {
        AssignmentContext _context;
        public dbOrderHistory()
        {
            _context = new AssignmentContext();
        }

        public IEnumerable<OrderProductVM> getOrderHistory()
        {
            //    IEnumerable<ToursViewModel> tours = (
            //from p in _context.PostsInfo
            //join r in _context.Region
            //on p.RegionId equals r.Id
            //where r.CountryId == 1
            //select new ToursViewModel
            //{
            //    RegionName = r.CountryId,
            //    ImageName = p.ImageName
            //});

            try
            {
                IEnumerable<OrderProductVM> orderHis = (from o in _context.orders
                                                        join p in _context.products
                                                        on o.ProductId equals p.ProductId
                                                        select new OrderProductVM
                                                        {
                                                            OrderId = o.Id.ToString(),
                                                            Price = p.Price,
                                                            Product = p.ProductName,
                                                            Quantity = o.Quantity
                                                        });
                return orderHis;
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
