namespace Yoda.Net.Networking.Packet.Info.Cosme
{
    
    
    using System;
    using System.Collections;
using System.Collections.Generic;
using Yoda.Net.Networking.Data.Cosme;

    public class GetShopCosmeticDetailResultData : ICommandData
    {
        public GetShopCosmeticDetailResultData()
        {
        }
   
        public int packetId
        {
            get
            {
                return PacketId.GET_SHOP_COSME_DETAIL_RESULT;
            }
        }
      
        public void readData(PiggStream In)
        {
           CosmeDressUpItemData cosmeDressupItemData = null;

			this.shopCode = In.readUTF();

			var totalnum = In.readInt();

			this.list = new List<CosmeDressUpItemData>(totalnum);

			var i = 0;

			while(i < totalnum){
				cosmeDressupItemData = new CosmeDressUpItemData();
				cosmeDressupItemData.readData(In);

				this.list.Add
                    ( cosmeDressupItemData);
				i++;
			}
            return;
        }

        public void writeData(PiggStream Out)
        {
            Out.writeUTF(shopCode);
            return;
        }

        public string shopCode { get; set; }
    
public  List<CosmeDressUpItemData> list { get; set; }}
}

