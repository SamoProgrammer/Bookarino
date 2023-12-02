
// using UnityEngine;
// using Microsoft.AspNetCore.SignalR.Client;
// using System.Threading.Tasks;

// public class ChatHub : MonoBehaviour
// {
//     private HubConnection hubConnection;

//     // Specify the URL where your SignalR hub is hosted.
//     private string hubUrl = "https://your-api-url/chatHub"; // Replace with your actual API URL.

//     private async void Start()
//     {
//         hubConnection = new HubConnectionBuilder()
//             .WithUrl(hubUrl)
//             .Build();

//         // Register hub methods
//         hubConnection.On<string, string>("SendMessage", (sender, message) =>
//         {
//             // Handle incoming messages from the server
//             Debug.Log(sender + ": " + message);
//         });

//         try
//         {
//             await hubConnection.StartAsync();
//             Debug.Log("Connected to SignalR hub");

//             // Join a group
//             await hubConnection.SendAsync("JoinGroup", "groupName"); // Replace with the desired group name

//             // Send a message
//             await hubConnection.SendAsync("SendMessage", "YourName", "Hello, Server!");
//         }
//         catch (Exception ex)
//         {
//             Debug.LogError("Error: " + ex.Message);
//         }
//     }

//     private void OnDestroy()
//     {
//         // Clean up when the game object is destroyed
//         if (hubConnection != null && hubConnection.State == HubConnectionState.Connected)
//         {
//             hubConnection.StopAsync();
//             hubConnection.DisposeAsync();
//         }
//     }
// }

