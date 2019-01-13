using System;
using System.Collections.Generic;
using System.Linq;

namespace Service.Logic
{
    public class ListServices
    {
        private List<Service> services;

        private static ListServices instance;

        public ListServices()
        {
            services = new List<Service>
            {
                new Service(1, "Замена экрана")
            };
        }

        public static ListServices GetInstance()
        {
            return instance ?? (instance = new ListServices());
        }

        public List<Service> GetServices()
        {
            return services;
        }
        public Service GetService(int id)
        {
            return services.FirstOrDefault(service => service.Id == id);
        }
    }
}