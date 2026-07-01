using cafe.Models;
using Microsoft.AspNetCore.SignalR;

namespace cafe.Hubs
{
        public class OrderHub : Hub
        {
            // Отправка обновления заказа всем клиентам
            public async Task SendOrderUpdate(Orders order)
            {
                await Clients.All.SendAsync("OrderUpdated", order);
            }

            // Отправка нового статуса заказа
            public async Task SendOrderStatusUpdate(int orderId, string status)
            {
                await Clients.All.SendAsync("OrderStatusChanged", orderId, status);
            }
        }
}
