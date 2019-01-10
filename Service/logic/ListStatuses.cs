using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Logic
{
    public static class ListStatuses
    {
        public static Status GetStatus(int id)
        {
            var dbContext = DatabaseContext.GetInstance();
            return dbContext.GetStatuses().FirstOrDefault(s => s.Id == id);
        }

        public static List<Status> GetStatuses()
        {
            var dbContext = DatabaseContext.GetInstance();
            return dbContext.GetStatuses();
        }
    }
}
