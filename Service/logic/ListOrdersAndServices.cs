namespace Service.Logic
{
    public static class ListOrdersAndServices
    {
        public static bool MakeCompletedService(int idOrder, int idService, int time)
        {
            return GetOrder(idOrder).MakeCompletedService(GetService(idService), time);
        }

        private static Order GetOrder(int id)
        {
            return ListOrders.GetInstance().GetOrder(id);
        }
        
        private static Service GetService(int id)
        {
            return ListServices.GetInstance().GetService(id);
        }
    }
}