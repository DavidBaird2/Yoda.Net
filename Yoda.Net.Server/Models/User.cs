using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yoda.Net.Networking;
using Yoda.Net.Networking.Data.Common;

namespace Yoda.Net.Server.Models
{
    public class User
    {
        [Key]
        public long UserId { get; set; }
        public string AmebaAuthTicket { get; set; }
        public string NickName { get; set; }
        public string HexCode { get; set; }
        public bool HasAvatarCreated { get; set; }
        public byte[] Color { get; set; }
        public byte[] Item { get; set; }
        public byte[] Part { get; set; }
        public byte[] Position { get; set; }


        public void SetColor(BodyColorData color)
        {
            var stream = new PiggStream();
            color.writeData(stream);
            Color = stream.toArray();
        }

        public void SetItem(BodyItemData item)
        {
            var stream = new PiggStream();
            item.writeData(stream);
            Item = stream.toArray();
        }

        public void SetPosition(BodyPositionData position)
        {
            var stream = new PiggStream();
            position.writeData(stream);
            Position = stream.toArray();
        }

        public void SetParts(BodyPartData parts)
        {
            var stream = new PiggStream();
            parts.writeData(stream);
            Part = stream.toArray();
        }

        public BodyColorData GetColor()
        {
            var color = new BodyColorData();
            var stream = new PiggStream(Color);
            color.readData(stream);
            return color;
        }

        public BodyItemData GetItem()
        {
            var item = new BodyItemData();
            var stream = new PiggStream(Item);
            item.readData(stream);
            return item;
        }

        public BodyPositionData GetPosition()
        {
            var position = new BodyPositionData();
            var stream = new PiggStream(Position);
            position.readData(stream);
            return position;
        }

        public BodyPartData GetParts()
        {
            var parts = new BodyPartData();
            var stream = new PiggStream(Part);
            parts.readData(stream);
            return parts;
        }
    }
}
