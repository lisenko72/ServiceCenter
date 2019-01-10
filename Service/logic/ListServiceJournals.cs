using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Logic
{
    public static class ListServiceJournals
    {
        public static bool AddServiceJournal(int idService, int idOrder, int time)
        {
            var dbContext = DatabaseContext.GetInstance();

            var services = dbContext.GetServices();
            var service = services.FirstOrDefault(s => s.Id == idService);
            if (service == null)
                return false;

            var orders= dbContext.GetOrders();
            var order = orders.FirstOrDefault(o => o.Id == idOrder);
            if (order == null)
                return false;

            int id = new Random().Next(1, 2000);
            var serviceJournal = new ServiceJournal(id, service, order, time);
            dbContext.AddServiceJournals(serviceJournal);
            return true;
        }
    }
}
