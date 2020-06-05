using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ModelClasses.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [MaxLength(250)]
        public string ProductName { get; set; }

        public double Price { get; set; }

        public int Quantity { get; set; }
    }
}
