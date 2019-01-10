using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Logic
{
    public static class ListServices
    {
        static List<Service> services = DatabaseContext.Services;

        public static List<Service> Services
        {
            get
            {
                return services;
            }
        }

    }
}
