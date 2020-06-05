using ModelClasses.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class AssignmentContext : DbContext
    {
        public AssignmentContext() : base("name=AppConnection") { }

        public virtual DbSet<Product> products { get; set; }
        public virtual DbSet<Order> orders { get; set; }
    }
}
