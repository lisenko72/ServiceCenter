using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Logic
{
    public class ServiceJournal
    {
        public int Id { get; set; }
        public Service Service {get; set; } 
        public Order Order { get; set; }
        public int Time { get; set; }

        public ServiceJournal(int id, Service service, Order order, int time)
        {
            Id = id;
            Order = order;
            Service = service;
            Time = time;
        }
    }
}