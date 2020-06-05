using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelClasses.Models
{
    public class OrderProductVM
    {
        public string OrderId { get; set; }
        public string Product { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
    }
}
