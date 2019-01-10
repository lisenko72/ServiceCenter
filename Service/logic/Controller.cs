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
            string description = "")
        {
            ListOrders.AddOrder(
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

        public static Order GetOrder(int id)
        {
            return ListOrders.GetOrder(id);
        }

        public static List<Status> GetStatuses()
        {
            return ListStatuses.GetStatuses();
        }

        public static void AddServiceJournal(int idService, int idOrder, int time)
        {
            ListServiceJournals.AddServiceJournal(idService, idOrder, time);
        }
    }
}
