using System;
using Yoda.Net.Networking;
using Yoda.Net.Networking.Packet;
namespace Yoda.Net.Proxy
{

    public interface ICommandBridge
    {
        void SendMessageToClient(ICommandData command);
        void SendMessageToServer(ICommandData command);
        void SendDataToClient(byte[] data);
        void SendDataToServer(byte[] data);
        void SetClientHandler(IMessageHandler clientHandler);
        void SetServerHandler(IMessageHandler serverHandler);
        void RouteDataFromClient(byte[] data);
        void RouteDataFromServer(byte[] data);
        void HandleServerCommand(CommandFactory factory,Header header, PiggStream body, PiggStream rawData);
        void HandleClientCommand(CommandFactory factory,  Header header, PiggStream body, PiggStream rawData);
        void HandleClientClosed();
        void HandleServerClosed();
        void HandleConnected(ICommandConnection context);
        int ConnectionId { get; set; }
        string TargetHost { get; set; }
        byte[] EncryptionKey { get; set; }
        ServerType GetServerType();
        CommandProxy GetProxyManager();
        void Close();
    }
}
