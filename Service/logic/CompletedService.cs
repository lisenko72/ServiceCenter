using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Logic
{
    public class CompletedService
    {
        private Service service;
        private int time;

        public CompletedService(Service service, int time)
        {
            this.service = service;
            this.time = time;
        }
        
        public Service Service
        {
            get { return service; }
        }

        public int Time
        {
            get { return time; }
        }
    }
}