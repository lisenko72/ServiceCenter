using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Logic
{
    public class Order
    {
        int id;
        Status status;
        //List<ServiceLineItem> services;
        DateTime dateClosed;

        public Order()
        { }

        public int Id
        {
            get
            {
                return id;
            }
        }

        public string Status
        {
            get
            {
                return status.Name;
            }
        }

        //public List<ServiceLineItem> Services
        //{
        //    get
        //    {
        //        return services;
        //    }
        //}
    }
}
