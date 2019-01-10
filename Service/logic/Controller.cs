using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Logic
{
    public static class Controller
    {
        public static void AddOrder(
            string shortDescription, 
            int idStatus, 
            DateTime dateCreate = default(DateTime), 
            DateTime dateEnd = default(DateTime), 
            string description = "", 
            int id = -1)
        {
            ListOrders.AddOrder(
                id: id,
                shortDescription: shortDescription,
                idStatus: idStatus,
                description: description,
                dateCreate: dateCreate,
                dateEnd: dateEnd);
        }

        public static List<Order> GetOrders()
        {
            return ListOrders.GetOrders();
        }

        public static List<Status> GetStatuses()
        {
            return ListStatuses.GetStatuses();
        }
    }
}
