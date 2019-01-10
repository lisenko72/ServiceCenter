using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Logic
{
    public class DatabaseContext
    {
        private List<Order> orders;
        private List<Status> statuses;
        private List<ServiceJournal> serviceJournals;
        private List<Service> services;

        static DatabaseContext database;

        public DatabaseContext()
        {
            statuses = new List<Status>
            {
                new Status(1, "Открыт"),
                new Status(2, "Обслужен"),
                new Status(3, "Закрыт")
            };

            orders = new List<Order>
            {
                new Order(1, "Замена экрана на утопленном iPhone", GetStatus(1), dateCreate: DateTime.Now),
                new Order(1, "Замена батареи Samsung", GetStatus(2), dateCreate: DateTime.Now.AddDays(-2), dateEnd: DateTime.Now)
            };
        }

        public static DatabaseContext GetInstance()
        {
            return database ?? (database = new DatabaseContext());
        }

        public bool AddOrder(Order order)
        {
            orders.Add(order);
            return true;
        }

        public List<Order> GetOrders()
        {
            return orders;
        }

        public Status GetStatus(int id)
        {
            return statuses.FirstOrDefault(s => s.Id == id);
        }

        public List<Status> GetStatuses()
        {
            return statuses;
        }

        public bool AddServiceJournals(ServiceJournal serviceJournal)
        {
            serviceJournals.Add(serviceJournal);
            return true;
        }

        public List<ServiceJournal> GetServiceJournals()
        {
            return serviceJournals;
        }

        public List<Service> GetServices()
        {
            return services;
        }
    }
}