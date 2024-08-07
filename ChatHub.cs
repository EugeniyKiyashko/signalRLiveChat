using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

public class Author
{
    public string id { get; set; }

    public string name { get; set; }
}

public class ChatMessage
{
    public Author User { get; set; }
    public string Message { get; set; }
    public DateTime Timestamp { get; set; }
}




public class ChatHub : Hub
{
    private static List<ChatMessage> _messages = new List<ChatMessage>();

    public async Task SendMessage(Author author, string message)
    {
        var chatMessage = new ChatMessage
        {
            User = author,
            Message = message,
            Timestamp = DateTime.UtcNow
        };

        _messages.Add(chatMessage);

        await Clients.All.SendAsync("ReceiveMessage", author, message);
    }


    public async Task GetChatHistory()
    {
        await Clients.Caller.SendAsync("ReceiveChatHistory", _messages);
    }
}