using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Logic
{
    public class ListStatuses
    {
        private List<Status> statuses;

        private static ListStatuses instance;

        public ListStatuses()
        {
            statuses = new List<Status>
            {
                new Status(1, "Выполнен"),
                new Status(2, "В работе")
            };
        }

        public static ListStatuses GetInstance()
        {
            return instance ?? (instance = new ListStatuses());
        }

        public Status GetStatus(int id)
        {
            return statuses.FirstOrDefault(s => s.Id == id);
        }

        public List<Status> GetStatuses()
        {
            return statuses;
        }
    }
}