using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Logic
{
    class ListOrsers
    {
        static List<Order> orders = DatabaseContext.Order;

        public static List<Order> Services
        {
            get
            {
                return orders;
            }
        }
    }
}
