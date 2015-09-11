
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yoda.Net.Networking;
using Yoda.Net.Networking.Packet.Chat;
using Yoda.Net.Networking.Util;

namespace Yoda.Net.Client
{

    /// <summary>
    /// InfoClient向けのクライアント
    /// </summary>
    public class ChatClient : CommandClient
    {
        public string AreaCategory;
        public string AreaCode;
        public BotUser session;
        private AmebaPigg piggClient;
        public bool InRoom = false;
        public ChatClient(AmebaPigg piggClient)
            : base( ServerType.Chat)
        {
            this.piggClient = piggClient;
            this.session = piggClient.session;
            base.manager.OnSocketClosed += manager_OnSocketClosed;
        }


        public override void onReady()
        {
            manager.SendCommand(new LoginChatData() { amebaId = session.hexCode, connectionId = manager.connectionId, secure = session.secureCode });
        }
        void manager_OnSocketClosed()
        {
            
        }

        public void enterRoom(string category, string code, bool queue, int frommove)
        {
            var data = new EnterRoomData();
            data.category = category;
            data.code = code;
            data.queue = queue;
            data.fromMove = frommove;
            manager.SendCommand(data);
        }

        public void onEnterRoom(BaseEnterRoomResultData data)
        {
            piggClient.ChatClientList.RemoveAll(i => i.InRoom);


            InRoom = true;

            string[] line = StartupPositionUtil.getAval(data);
            
            var intArray = Array.ConvertAll( line, new Converter<string, int>( s => int.Parse( s ) ) );

            manager.SendCommand(new MoveEndData(intArray[0], intArray[1], intArray[2]));
        }

    }
}
