using Microsoft.AspNetCore.SignalR;
using System;
using System.Threading.Tasks;

public class CommunicationHub : Hub
{
    // Join a group chat based on the module code
    public async Task JoinModuleGroup(string moduleCode)
    {
        if (string.IsNullOrEmpty(moduleCode))
        {
            Console.WriteLine("Error: moduleCode is null or empty");
            return;
        }

        await Groups.AddToGroupAsync(Context.ConnectionId, moduleCode);
        await Clients.Group(moduleCode).SendAsync("ReceiveNotification", $"{Context.ConnectionId} has joined the group {moduleCode}");
        Console.WriteLine($"Connection {Context.ConnectionId} joined group {moduleCode}");
    }

    // Leave a group chat
    public async Task LeaveModuleGroup(string moduleCode)
    {
        if (string.IsNullOrEmpty(moduleCode))
        {
            Console.WriteLine("Error: moduleCode is null or empty");
            return;
        }

        await Groups.RemoveFromGroupAsync(Context.ConnectionId, moduleCode);
        await Clients.Group(moduleCode).SendAsync("ReceiveNotification", $"{Context.ConnectionId} has left the group {moduleCode}");
        Console.WriteLine($"Connection {Context.ConnectionId} left group {moduleCode}");
    }

    // Send a message to a specific module group
    public async Task SendMessageToModuleGroup(string moduleCode, string senderName, string message, string timestamp)
    {
        if (string.IsNullOrEmpty(moduleCode))
        {
            Console.WriteLine("Error: moduleCode is null or empty");
            return;
        }

        await Clients.Group(moduleCode).SendAsync("ReceiveGroupMessage", senderName, message, timestamp);
        Console.WriteLine($"Message sent to group {moduleCode} by {senderName}: {message}");
    }

    // Override method called when a user connects
    public override Task OnConnectedAsync()
    {
        Console.WriteLine($"Client connected with ConnectionId: {Context.ConnectionId}");
        return base.OnConnectedAsync();
    }

    // Override method called when a user disconnects
    public override Task OnDisconnectedAsync(Exception? exception)
    {
        Console.WriteLine($"Client disconnected with ConnectionId: {Context.ConnectionId}");
        return base.OnDisconnectedAsync(exception);
    }
}
