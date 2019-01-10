using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Logic
{
    public static class Controller
    {
        public static bool AddOrder(
            string shortDescription, 
            int idStatus, 
            DateTime dateCreate = default(DateTime), 
            DateTime dateEnd = default(DateTime), 
            string description = "")
        {
            return ListOrders.AddOrder(
                shortDescription: shortDescription,
                idStatus: idStatus,
                description: description,
                dateCreate: dateCreate,
                dateEnd: dateEnd);
        }

        public static bool UpdateOrder(
            int idOrder, 
            DateTime dateEnd, 
            int statusId, 
            string description)
        {
            return ListOrders.UpdateOrder(idOrder, dateEnd, statusId, description);
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

        public static List<Service> GetServices()
        {
            return ListServices.GetServices();
        }

        public static bool AddServiceJournal(int idService, int idOrder, int time)
        {
            return ListServiceJournals.AddServiceJournal(idService, idOrder, time);
        }

        public static List<ServiceJournal> GetServiceJournals(int idOrder)
        {
            return ListServiceJournals.GetServiceJournals(idOrder);
        }
    }
}
