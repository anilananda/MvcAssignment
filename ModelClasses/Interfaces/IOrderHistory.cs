using ModelClasses.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelClasses.Interfaces
{
    public interface IOrderHistory
    {
        IEnumerable<OrderProductVM> getOrderHistory();

    }
}
