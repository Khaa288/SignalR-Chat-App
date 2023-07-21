using Microsoft.AspNetCore.SignalR;

namespace SignalR_Chat_App.Hubs;

public class ChatHub : Hub {
    public async Task SendMessage(string user, string message)
    {
        await Clients.All.SendAsync("ReceiveMessage", user, message, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
    }
}