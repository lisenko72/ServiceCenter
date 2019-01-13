using System;
using System.Collections.Generic;

namespace Service.Logic
{
    public class Order
    {
        private int id;
        private string shortDescription;
        private string description;
        private DateTime dateCreate;
        private DateTime dateEnd;
        private Status status;
        private List<CompletedService> serviceJournals;

        public Order(
            int id,
            string shortDescription,
            Status status,
            string description = "",
            DateTime dateCreate = default(DateTime),
            DateTime dateEnd = default(DateTime))
        {
            this.id = id;
            this.shortDescription = shortDescription;
            this.description = description;
            this.dateCreate = dateCreate == DateTime.MinValue ? DateTime.Now : dateCreate;
            this.dateEnd = dateEnd;
            this.status = status;
            serviceJournals = new List<CompletedService>();
        }

        public bool MakeCompletedService(Service service, int time)
        {
            CompletedService completedService = new CompletedService(service, time);
            serviceJournals.Add(completedService);
            return true;
        }

        public bool UpdateOrder(string description, Status status, DateTime dateEnd)
        {
            if (status == null)
                return false;

            this.status = status;
            this.description = description;
            this.dateEnd = dateEnd;

            return true;
        }

        public List<CompletedService> GetCompletedServices()
        {
            return serviceJournals;
        }

        public double GetTime()
        {
            double time = 0;
            foreach (var serviceJournal in serviceJournals)
            {
                time = time + serviceJournal.Time;
            }

            return time;
        }

        public int Id
        {
            get { return id; }
        }

        public Status Status
        {
            get { return status; }
            set { status = value; }
        }

        public DateTime DateEnd
        {
            get { return dateEnd; }
            set { dateEnd = value; }
        }

        public DateTime DateCreate
        {
            get { return dateCreate; }
            set { dateCreate = value; }
        }

        public string ShortDescription
        {
            get { return shortDescription; }
            set { shortDescription = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }
    }
}