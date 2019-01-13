using System;
using System.Collections.Generic;
using System.Linq;

namespace Service.Logic
{
    public class ListOrders
    {
        private List<Order> orders;

        private static ListOrders instance;

        public ListOrders()
        {
            orders = new List<Order>
            {
                new Order(1, "Замена экрана на утопленном iPhone", GetStatus(1), dateCreate: DateTime.Now)
            };

        }

        public static ListOrders GetInstance()
        {
            return instance ?? (instance = new ListOrders());
        }

        public bool AddOrder(
            string shortDescription,
            int idStatus,
            DateTime dateCreate = default(DateTime),
            DateTime dateEnd = default(DateTime),
            string description = "")
        {
            if (orders == null)
                orders = new List<Order>();
            
            var status = GetStatus(idStatus);
            if (status == null)
                return false;

            int id = new Random().Next(1, 200);

            var order = new Order(id, shortDescription, status, description, dateCreate, dateEnd);

            orders.Add(order);
            return true;
        }

        public List<Order> GetOrders()
        {
            return orders;
        }

        public Order GetOrder(int id)
        {
            return orders.FirstOrDefault(order => order.Id == id);
        }

        public bool UpdateOrder(
            int idOrder,
            DateTime dateEnd,
            int idStatus,
            string description)
        {
            var order = GetOrder(idOrder);
            if (order == null)
                return false;

            var status = GetStatus(idStatus);

            return order.UpdateOrder(description, status, dateEnd);
        }

        public Status GetStatus(int idStatus)
        {
            return ListStatuses.GetInstance().GetStatus(idStatus);
        }
    }
}