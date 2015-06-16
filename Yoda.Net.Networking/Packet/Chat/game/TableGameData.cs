


namespace Yoda.Net.Networking.Packet.Chat.game.data
{


    public class TableGameData : IPacket
    {
        public string method;
        public AmebaStream data;

        public virtual int packetId
        {
            get
            {
                return PacketId.TABLE_GAME;
            }
        }
        public TableGameData(string param1, AmebaStream param2)
        {
            this.method = param1;
            this.data = param2;
            return;
        }
        public TableGameData()
        {
            data = new AmebaStream();
            return;
        }
        public void readData(AmebaStream In)
        {
            method = In.readUTF();
            if (In.readBoolean())
            {
                data.writeBytes(In.readBytes((int)(In.length - In.position)));
            }
            
        }


        public void writeData(AmebaStream Out)
        {
            if (method == "surrender")
            {
                //Engine.Sessions.trackerSession.ChatClient.doCSTalk("サレンダー！");
            }
            if (method == "hit")
            {
              //  Engine.Sessions.trackerSession.ChatClient.doCSTalk("ヒット！");
            }
            if (method == "doubleDown")
            {
            //    Engine.Sessions.trackerSession.ChatClient.doCSTalk("ダブルダウン！");
            }
            if (method == "stay")
            {
            //    Engine.Sessions.trackerSession.ChatClient.doCSTalk("スタンド！");
            }
            if (method == "split")
            {
               // Engine.Sessions.trackerSession.ChatClient.doCSTalk("スプリット！");
            }
            Out.writeUTF(method);
            if (data != null)
            {
                Out.writeBoolean(true);
                data.position = 0;
                Out.writeBytes(data.readBytes((int)data.length));
            }
            else
            {
                Out.writeBoolean(false);
            }
            return;
        }


    }
}

