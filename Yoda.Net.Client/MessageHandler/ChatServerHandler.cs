using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yoda.Net.Networking;
using Yoda.Net.Networking.Packet.Chat;
using Yoda.Net.Networking.Packet.Chat.Areagame;

namespace Yoda.Net.Client.MessageHandler
{
    public class ChatServerHandler : IMessageHandler
    {
        private AmebaPigg piggClient;

        private ChatClient client;



        public ChatServerHandler(AmebaPigg piggClient, ChatClient client)
        {
            this.piggClient = piggClient;
            this.client = client;
        }
     
        public void onError(ErrorData data)
        {

        
        
        }
        public void onLoginChatResult(LoginChatResultData data)
        {

            client.enterRoom(client.AreaCategory, client.AreaCode, false, 0);

        }
        public void onAreaGamePlayResult (AreaGamePlayResultData data)
        {

        }
        public void onPetApperResult(PetAppearResultData data)
        {

        }
        public void onEnterAreaResult(EnterAreaResultData data)
        {
            client.onEnterRoom(data);
        }
        public void onEnterUserRoomResult(EnterUserRoomResultData data)
        {
            client.onEnterRoom(data);
        }
        public void onEnterUserGardenResult(EnterUserGardenResultData data)
        {
            client.onEnterRoom(data);
        }
        public void onEnterRoomFullResult(EnterRoomFullResultData data)
        {

        }
        public void onEnterRoomReadyResult(EnterRoomReadyResultData data)
        {

        }
        public void onEnterQueueStartResult(EnterQueueStartResultData data)
        {

        }
        public void onEnterQueueResult(EnterQueueResultData data)
        {

        }
        public void onCheckAreaGameResult(CheckAreaGameResultData data)
        {

        }
        public void onAreaGameFieldResult(AreaGameFieldResultData data)
        {

        }
        public void onAreaGameJoinResult(AreaGameJoinResultData data)
        {

        }
   
      
    }
    
}
