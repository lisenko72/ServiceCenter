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
    }
}
