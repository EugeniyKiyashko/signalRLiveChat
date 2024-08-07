# SignalRChatApp

SignalRChatApp is a real-time chat application using SignalR for seamless communication and message history retrieval. This project demonstrates how to build a chat system with message persistence and history retrieval.

## Features

- Real-time messaging using SignalR
- Message history retrieval on client connection
- Simple, extensible architecture
- Easy setup and deployment

## Getting Started

Follow these instructions to get a copy of the project up and running on your local machine.

### Prerequisites

- [.NET 6 SDK](https://dotnet.microsoft.com/download/dotnet/6.0)
- [Node.js](https://nodejs.org/) (for client-side package management)
- A database for message storage (optional, for production)

### Installation

1. **Clone the repository:**
```
git clone https://github.com/yourusername/SignalRChatApp.git
cd SignalRChatApp
```

2. **Build and run the project:**
```
dotnet build
dotnet run
```

3. **Setting Up an HTTP Server**
To host your client-side application separately using an HTTP server, you can use a simple Node.js server or any other HTTP server of your choice.

Using http-server:
Install http-server:

If you don't have http-server installed globally, you can install it using npm:
```
npm install -g http-server
Run the HTTP server:
```
Navigate to the directory where your built client-side files are located and start the server:
```
http-server
```

### Access your client application:

Open your browser and navigate to the address provided by http-server: http://localhost:8080. 
To use the chat, you can open this address in two tabs. When you enter text and send it in one of the chats, the changes will be reflected in the other.
When you open and create a new browser tab with chat instance, the current message history will be displayed inside.

### Acknowledgments
[SignalR Documentation](https://learn.microsoft.com/en-us/aspnet/core/signalr/introduction?view=aspnetcore-8.0)

### Contributing
Contributions are welcome! Please fork the repository and submit a pull request for any enhancements or bug fixes.

### License
This project is licensed under the MIT License. See the LICENSE file for details.