using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Logic
{
    public class Service
    {
        int id;
        string name;

        public Service(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        public int Id
        {
            get
            {
                return id;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
        }
    }
}
