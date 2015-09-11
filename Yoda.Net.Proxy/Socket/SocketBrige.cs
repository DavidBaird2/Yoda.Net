using Yoda.Net.Networking;

namespace Yoda.Net.Proxy.Socket
{
    public class SocketBrige : ProxyBridge
    {
        private SocketClient client;
        private SocketRemortClient remortClient;

        public SocketBrige(ProxySession session, SocketServer server, ServerType type)
            : base(session, server.GetManager(), type)
        {
            client = new SocketClient(this);
            remortClient = new SocketRemortClient(this);

            base.Client = client;
            base.RemortClient = remortClient;
        }

        internal void Start(System.Net.Sockets.Socket clientSocket)
        {
            remortClient.socket = clientSocket;

            base.Open();

        }
    }
}
