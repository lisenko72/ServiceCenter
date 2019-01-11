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
        public int Time { get; set; }

        public ServiceJournal(Service service, int time)
        {
            Service = service;
            Time = time;
        }
    }
}