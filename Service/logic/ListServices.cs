using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Logic
{
    public static class ListServices
    {
        public static List<Service> GetServices()
        {
            var dbContext = DatabaseContext.GetInstance();
            return dbContext.GetServices();
        }
        public static Service GetService(int id)
        {
            var dbContext = DatabaseContext.GetInstance();
            var services = dbContext.GetServices();
            return services.FirstOrDefault(service => service.Id == id);
        }
    }
}
