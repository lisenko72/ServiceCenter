using System;
using System.Collections.Generic;

namespace Service.Logic
{
    public class Order
    {
        public int Id { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public DateTime DateCreate { get; set; }
        public DateTime DateEnd { get; set; }
        public Status Status { get; set; }
        public List<ServiceJournal> ServiceJournals { get; set; }

        public Order(
            int id,
            string shortDescription,
            Status status,
            string description = "",
            DateTime dateCreate = default(DateTime),
            DateTime dateEnd = default(DateTime))
        {
            Id = id;
            ShortDescription = shortDescription;
            Description = description;
            DateCreate = dateCreate == DateTime.MinValue ? DateTime.Now : dateCreate;
            DateEnd = dateEnd;
            Status = status;
            ServiceJournals = new List<ServiceJournal>();
            //ServiceJournals = new List<ServiceJournal>{
            //    new ServiceJournal(new Service(2, "ццывы"), 30),
            //    new ServiceJournal(new Service(4, "111"), 30)
            //};
        }

        public bool MakeServiceJournal(Service service, int time)
        {
            ServiceJournal sj = new ServiceJournal(service, time);
            DatabaseContext.AddServiceJournal(Id, sj);
            return true;
        }

        public bool AddServiceJournal(ServiceJournal sj)
        {
            ServiceJournals.Add(sj);
            return true;
        }

        public List<ServiceJournal> GetServiceJournals()
        {
            return ServiceJournals;
        }

        public double GetTime()
        {
            double time = 0;
            foreach (var serviceJournal in ServiceJournals)
            {
                time = time + serviceJournal.Time;
            }

            return time;
        }
    }
}