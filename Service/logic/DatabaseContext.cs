using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Logic
{
    public class DatabaseContext
    {
        private static List<Order> orders;
        private static List<Status> statuses;
        private static List<Service> services;

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
                new Order(1, "Замена экрана на утопленном iPhone", statuses.FirstOrDefault(s => s.Id == 1), dateCreate: DateTime.Now),
                new Order(2, "Замена батареи Samsung", statuses.FirstOrDefault(s => s.Id == 2), dateCreate: DateTime.Now.AddDays(-2), dateEnd: DateTime.Now)
            };


            services = new List<Service>
            {
                new Service(1, "Замена экрана"),
                new Service(2, "Пайка сокета")
            };


            orders[0].AddServiceJournal(new ServiceJournal(services[0], 31));
            orders[0].AddServiceJournal(new ServiceJournal(services[1], 13));
        }

        public static DatabaseContext GetInstance()
        {
            return database ?? (database = new DatabaseContext());
        }

        public static bool AddServiceJournal(int idOrder, ServiceJournal sj)
        {
            orders.FirstOrDefault(order => order.Id == idOrder).AddServiceJournal(sj);
            return true;
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

        public List<Status> GetStatuses()
        {
            return statuses;
        }

        public List<Service> GetServices()
        {
            return services;
        }
    }
}