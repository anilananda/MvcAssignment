using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelClasses.Models
{
    public class Order
    {
        public Order()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string Address { get; set; }
        public Product product { get; set; }
    }
}
