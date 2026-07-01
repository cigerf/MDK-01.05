using Microsoft.AspNetCore.SignalR;
using cafe.Models;

namespace cafe.Hubs
{
    public class ClientHub : Hub
    {
        public async Task SendClientUpdate(Clients client)
        {
            await Clients.All.SendAsync("ClientUpdated", client);
        }

        public async Task SendBonusPointsUpdate(int clientId, int bonusPoints)
        {
            await Clients.All.SendAsync("BonusPointsChanged", clientId, bonusPoints);
        }
    }
}