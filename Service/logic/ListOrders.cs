using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Logic
{
    public static class ListOrders
    {
        public static bool AddOrder(
            string shortDescription,
            int idStatus,
            DateTime dateCreate = default(DateTime),
            DateTime dateEnd = default(DateTime),
            string description = "")
        {
            var dbContext = DatabaseContext.GetInstance();

            var status = dbContext.GetStatuses().FirstOrDefault(s => s.Id == idStatus);
            if (status == null)
                return false;

            int id = new Random().Next(1, 200);

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

        public static Order GetOrder(int id)
        {
            var dbContext = DatabaseContext.GetInstance();
            var orders = dbContext.GetOrders();
            return orders.FirstOrDefault(order => order.Id == id);
        }

        public static bool UpdateOrder(
            int idOrder,
            DateTime dateEnd,
            int statusId,
            string description)
        {
            var order = GetOrder(idOrder);
            if (order == null)
                return false;

            if (order.Status.Id != statusId)
            {
                var dbContext = DatabaseContext.GetInstance();
                var status = dbContext.GetStatuses().FirstOrDefault(s => s.Id == statusId);
                if (status == null)
                    return false;

                order.Status = status;
            }

            order.DateEnd = dateEnd;
            order.Description = description;

            return true;
        }
    }
}