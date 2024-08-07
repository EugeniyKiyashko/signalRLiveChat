using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

public class ChatMessage
{
    public string User { get; set; }
    public string Message { get; set; }
    public DateTime Timestamp { get; set; }
}


public class ChatHub : Hub
{
    private static List<ChatMessage> _messages = new List<ChatMessage>();

    public async Task SendMessage(string user, string message)
    {
        var chatMessage = new ChatMessage
        {
            User = user,
            Message = message,
            Timestamp = DateTime.UtcNow
        };

        _messages.Add(chatMessage);

        await Clients.All.SendAsync("ReceiveMessage", user, message);
    }


    public async Task GetChatHistory()
    {
        await Clients.Caller.SendAsync("ReceiveChatHistory", _messages);
    }
}