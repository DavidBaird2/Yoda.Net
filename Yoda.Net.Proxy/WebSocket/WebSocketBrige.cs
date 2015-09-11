
using Yoda.Net.Networking;

namespace Yoda.Net.Proxy.WebSocket
{
    public class WebSocketBrige : ProxyBridge
    {
        public WebSocketClient client;
        public WebSocketRemortClient remortClient;

        public SuperWebSocket.WebSocketSession Session;
        public WebSocketBrige(ProxySession session, WebSocketServer server, ServerType type)
            : base(session, server.getManager(), type)
        {
            client = new WebSocketClient(this);
            remortClient = new WebSocketRemortClient(this);

            base.Client = client;
            base.RemortClient = remortClient;
        }


        
        internal void Start(SuperWebSocket.WebSocketSession wss)
        {
            Session = wss;
            remortClient.SetWebProxySession(wss);
            Open();
        }

        
    }
}
