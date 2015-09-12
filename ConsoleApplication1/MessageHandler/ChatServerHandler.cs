using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yoda.Net.Networking;
using Yoda.Net.Networking.Packet.Chat;
using Yoda.Net.Networking.Packet.Info.Shop;
using Yoda.Net.Networking.Packet.Info.User;
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

        //エリアに入室するときのコマンドをハンドルする
        public CommandRouteOption onEnterAreaResultData(EnterAreaResultData data)
        {
            //dataを書き換える
            var items = data.areaData.areaName = "ひぐのちんこ！";
          

                //Edit→コマンドを編集　Nothing→なにもしない Block→ブロックする
            return CommandRouteOption.Edit;
        }

    }
}
