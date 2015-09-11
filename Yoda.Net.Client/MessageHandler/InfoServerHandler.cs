using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yoda.Net.Networking;
using Yoda.Net.Networking.Packet.Info;
using Yoda.Net.Networking.Packet.Info.Area;
using Yoda.Net.Networking.Packet.Info.Item;
using Yoda.Net.Networking.Packet.Info.Shop;
using Yoda.Net.Networking.Packet.Info.User;

namespace Yoda.Net.Client.Delegate
{
    class InfoServerHandler : IMessageHandler
    {

        private AmebaPigg piggClient;


        public InfoServerHandler(AmebaPigg piggClient)
        {
            // TODO: Complete member initialization
            this.piggClient = piggClient;
        }

        public void onError(ErrorData data)
        {

        }
        public void onListUserItem(ListUserItemResultData data)
        {

        }

        public void onGetAreaResult(GetAreaResultData data)
        {
            string[] server = data.server.Split(':');

            int port =  Convert.ToInt32(server[1]);

            piggClient.OpenChat(server[0], port, data.category, data.code);
        }

        public void onCreateUserResult(CreateUserResultData data)
        {

        }

        public void onStartCreateUserResult(StartCreateUserResultData data)
        {

        }
        public void onBuyGiftItemResult(BuyGiftItemResultData data)
        {

        }
        public void onLoginResultData(LoginResultData data)
        {


            if (data.isSuccess)
            {

                piggClient.session.hexCode = data.code;
                piggClient.session.secureCode = data.secure;

                if (data.hasPigg == LoginResultData.HAS_PIGG_CREATE)
                {
                    //    if (d.tutorial() != 13)
                    //  {
                    //      proceedTutorial(13);
                    //  }
                    piggClient.MoveArea("user", "bcabe7a75a1ccd99");
                }
                else if (data.hasPigg == LoginResultData.HAS_PIGG_UNCREATE)
                {
                    //ユーザーを未作成
                    //       _msession.isCreateUser = true;
                    //  this.sendCommandToServer(new StartCreateUserData(_msession.N));
                }
                else
                {
                    //  Engine.Log("ログインに失敗しました-");
                }
            }
            else
            {
                //    Engine.Log("ログインに失敗しました");
            }
        }

    }
}
