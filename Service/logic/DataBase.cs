using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Logic
{
    public class DatabaseContext
    {
        static List<Status> statuses;
        static List<Order> orders;
        static List<Service> services;

        static DatabaseContext database;

        public DatabaseContext()
        {
            statuses = new List<Status>();
            statuses.Add(new Status(1, "Открыт"));
            statuses.Add(new Status(2, "Обслужен"));
            statuses.Add(new Status(3, "Закрыт"));

            services= new List<Service>();
            services.Add(new Service(1, "Замена экрана"));
            services.Add(new Service(2, "Замена аккумулятора"));
            services.Add(new Service(3, "Пропайка детали"));
            services.Add(new Service(4, "Замена процессора"));

            orders = new List<Order>();
            orders.Add(new Order(1, new Status(1, "Открыт"), new DateTime(2012,12, 1));
        }

        public static DatabaseContext GetInstance()
        {
            if (database == null)
                database = new DatabaseContext();
            
            return database;
        }

        public List<Status> GetStatuses()
        {
            return statuses;
        }

        public List<Service> GetServices()
        {
            return services;
        }

        public static List<Order> Orders
        {
            get
            {
                return orders;
            }
        }

        public static int getIdStatus(string name)
        {
            foreach (Status element in statuses)
            {
                if (element.Name == name)
                {
                    return element.Id;
                }
            }
            return -1;
        }

    }
}
