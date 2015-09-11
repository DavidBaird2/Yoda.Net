
using Yoda.Net.Networking;
using Yoda.Net.Networking.Game.TableGame;
using Yoda.Net.Networking.Packet.Chat;
using Yoda.Net.Proxy;

namespace ConsoleApplication1
{
    class ChatServerHandler : IMessageHandler
    {
        private ProxySession session;

        public ChatServerHandler(ProxySession session)
        {
            this.session = session;
        }

        public CommandRouteOption onEnterAreaResultData(EnterAreaResultData data)
        {

            return CommandRouteOption.Nothing;
        }

    }
}
