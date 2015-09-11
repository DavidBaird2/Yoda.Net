using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Yoda.Net.Networking;
using Yoda.Net.Server.Info;

namespace Yoda.Net.Server.Chat
{
    public class ChatServer
    {
        public List<RemortClient> Clients;
        public TcpListener Listener { get; set; }
        public IMessageHandler handler;
        private int clientCounter { get; set; }
        public ChatServer()
        {
            clientCounter = 1000;
            Clients = new List<RemortClient>();
            SetHandler(new ChatMessageHandler(this));
        }
        public void SetHandler(IMessageHandler handler)
        {
            this.handler = handler;
        }
        public void Start(IPEndPoint ipEndPoint)
        {
            Listener = new TcpListener(ipEndPoint);
            Listener.Start();
            Listener.BeginAcceptTcpClient(AcceptClientAsync, null);
        }

        public void AcceptClientAsync(IAsyncResult ar)
        {
            clientCounter++;
            var socket = Listener.EndAcceptTcpClient(ar).Client;
            var manager = new SocketManager(handler);
            manager.connectionId = clientCounter;
            manager.SetSocket(socket);
            RemortClient client = new RemortClient(this, manager);

            Listener.BeginAcceptTcpClient(AcceptClientAsync, null);
        }
        public void RemoveClient(RemortClient client)
        {
            Clients.Remove(client);
        }
        public void AddClient(RemortClient client)
        {
            Clients.Add(client);
        }

  
    }
}
