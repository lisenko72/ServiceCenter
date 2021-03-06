﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Service.Logic;

namespace Service
{
    public static class Controller
    {
        public static DataTable GetServices()
        {
            var table = new DataTable();
            table.Columns.Add("Наименование");
            table.Columns.Add("Id");

            var services = ListServices.GetInstance().GetServices();
            foreach (var service in services)
            {
                table.Rows.Add(service.Name, service.Id);
            }

            return table;
        }

        public static bool MakeServiceJournal(int idService, int idOrder, int time)
        {
            return ListOrdersAndServices.MakeCompletedService(idOrder, idService, time);
        }

        public static bool UpdateOrder(
            int idOrder,
            DateTime dateEnd,
            int statusId,
            string description)
        {
            return ListOrders.GetInstance().UpdateOrder(idOrder, dateEnd, statusId, description);
        }

        public static DataTable GetOrders()
        {
            var orders = ListOrders.GetInstance().GetOrders();
            var dataTable = new DataTable();
            dataTable.Columns.Add("Id");
            dataTable.Columns.Add("Дата создания");
            dataTable.Columns.Add("Краткое описание");
            dataTable.Columns.Add("Статус");
            dataTable.Columns.Add("Дата завершения");
            foreach (var order in orders)
            {
                dataTable.Rows.Add(order.Id, order.DateCreate, order.ShortDescription, order.Status.Name, order.DateEnd);
            }

            return dataTable;
        }

        public static DataTable GetStatuses()
        {
            var table = new DataTable();
            table.Columns.Add("Наименование");
            table.Columns.Add("Id");

            var statuses = ListStatuses.GetInstance().GetStatuses();
            foreach (var status in statuses)
            {
                table.Rows.Add(status.Name, status.Id);
            }

            return table;
        }

        public static DataTable GetServiceJournals(int idOrder)
        {
            var serviceJournals = (from completedService in GetOrder(idOrder).GetCompletedServices()
                                    group completedService by completedService.Service.Name
                                    into g
                                    select new { g.Key, Sum = g.Sum(s => s.Time) }).ToList();
            var dataTable = new DataTable();
            dataTable.Columns.Add("Услуга");
            dataTable.Columns.Add("Время");
            foreach (var serviceJournal in serviceJournals)
            {
                dataTable.Rows.Add(serviceJournal.Key, serviceJournal.Sum);
            }

            return dataTable;
        }

        public static string GetOrderShortDescription(int id)
        {
            var order = GetOrder(id).ShortDescription;
            return order;
        }

        public static DateTime GetOrderDateCreate(int id)
        {
            return GetOrder(id).DateCreate;
        }

        public static DateTime GetOrderDateEnd(int id)
        {
            return GetOrder(id).DateEnd;
        }

        public static int GetOrderStatusId(int id)
        {
            return GetOrder(id).Status.Id;
        }

        public static string GetOrderDescription(int id)
        {
            return GetOrder(id).Description;
        }

        public static string GetOrderTime(int id)
        {
            return GetOrder(id).GetTime().ToString();
        }

        private static Order GetOrder(int id)
        {
            return ListOrders.GetInstance().GetOrder(id);
        }
    }
}
