using System;

using Yoda.Net.Networking.Packet;
using Yoda.Net.Networking;

namespace Yoda.Net.Proxy
{
    public class ProxyBridge : ICommandBridge 
    {
        private ProxySession session;
        private CommandProxy commandProxyManager;
        private ServerType serverType;
        protected virtual ICommandConnection RemortClient { get; set; }
        protected virtual ICommandConnection Client { get; set; }
        public byte[] EncryptionKey { get; set; }
        public int ConnectionId { get; set; }

        public string TargetHost { get; set; }


        public ProxyBridge(ProxySession session, CommandProxy commandProxyManager, ServerType serverType)
        {
            this.session = session;
            this.commandProxyManager = commandProxyManager;
            this.serverType = serverType;
        }
        
        public void SendMessageToClient(ICommandData command)
        {
            RemortClient.SendCommand(command);
        }

        public void SendMessageToServer(ICommandData command)
        {
            Client.SendCommand(command);
        }

        public void SendDataToClient(byte[] data)
        {
            RemortClient.SendData(data);
        }

        public void SendDataToServer(byte[] data)
        {
            Client.SendData(data);
        }

        public void SetClientHandler(IMessageHandler clientHandler)
        {
            RemortClient.SetMessageHandler(clientHandler);
        }

        public void SetServerHandler(IMessageHandler serverHandler)
        {
            Client.SetMessageHandler(serverHandler);
            
        }

        public void Close()
        {
            Client.Close();

            RemortClient.Close();
        }

        public void Open()
        {
            Client.Open();

            RemortClient.Open();

        }
       
        public void HandleClientClosed()
        {
            Close();
        }
        public void HandleServerClosed()
        {
            Close();
        }
        public ServerType GetServerType()
        {
            return serverType;
        }

        public CommandProxy GetProxyManager()
        {
            return commandProxyManager;
        }

        public void RouteDataFromClient(byte[] data)
        {
            Client.SendData(data);
        }

        public void RouteDataFromServer(byte[] data)
        {
            RemortClient.SendData(data);
        }

        public void HandleClientCommand(CommandFactory factory,Header header, PiggStream body, PiggStream rawData)
        {
            commandProxyManager.handleCommand(factory,Client, this, header, body, rawData);

        }

        public void HandleServerCommand(CommandFactory factory, Header header, PiggStream body, PiggStream rawData)
        {
            commandProxyManager.handleCommand(factory,RemortClient, this, header, body, rawData);
        }


        public void HandleConnected(ICommandConnection context)
        {
            throw new NotImplementedException();
        }
    }
}
