﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Logic
{
    public static class ListOrders
    {
        public static bool AddOrder(
            int id,
            string shortDescription,
            int idStatus,
            DateTime dateCreate = default(DateTime),
            DateTime dateEnd = default(DateTime),
            string description = "")
        {
            var dbContext = DatabaseContext.GetInstance();

            var status = dbContext.GetStatus(idStatus);
            if (status == null)
                return false;

            if (id == -1)
                id = 2; ///////////////

            var order = new Order(
                id: id,
                shortDescription: shortDescription,
                status: status,
                description: description,
                dateCreate: dateCreate,
                dateEnd: dateEnd
            );

            return dbContext.AddOrder(order);
        }

        public static List<Order> GetOrders()
        {
            var dbContext = DatabaseContext.GetInstance();
            return dbContext.GetOrders();
        }
    }
}