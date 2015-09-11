using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yoda.Net.Networking;
using Yoda.Net.Networking.Packet.Info;
using Yoda.Net.Networking.Packet.Info.Area;
using Yoda.Net.Networking.Packet.Info.Area;
using Yoda.Net.Networking.Packet.Info.User;
using Yoda.Net.Server.DataAccess;
using Yoda.Net.Server.Models;

namespace Yoda.Net.Server.Info
{
    public class InfoMessageHandler : IMessageHandler
    {
        public InfoServer server;
        public InfoMessageHandler(InfoServer server)
        {
            this.server = server;
        }
        public string GetRandomHexCode()
        {
           return System.Guid.NewGuid().ToString().Replace("-", string.Empty).Substring(0, 16);
        }

        public User GetUser(string amebaAuthTicket, bool CreateIfNotExist)
        {
            using (var db = new AmebaContext())
            {

                User user = db.Users.Where(i => i.AmebaAuthTicket == amebaAuthTicket ).SingleOrDefault();
                if (user == null && CreateIfNotExist)
                {
                    user = new User();
                    user.AmebaAuthTicket = amebaAuthTicket;
                    user.HasAvatarCreated = false;
                    user.NickName = "新規ユーザー";
                    user.HexCode = GetRandomHexCode();
                    db.Users.Add(user);
                    db.SaveChanges();

                }
                return user;
            }
        }
        public void onLogin(LoginData data, RemortClient client)
        {
            User user = client.user;

            if (user == null)
            {
                user = GetUser(data.amebaAuthTicket, true);
                client.user = user;
            }

            LoginResultData result = new LoginResultData();
            result.asUserId = user.UserId.ToString();
            if(data!=null)
            result.ticket = data.ticket;
            result.isSuccess = true;
            client.secure = new byte[8];
            new Random().NextBytes(client.secure);

            result.secure = client.secure;
            if (user.HasAvatarCreated)
            {
                result.hasPigg = LoginResultData.HAS_PIGG_CREATE;
                result.isFirstDay = true;
                result.code = user.HexCode;
                result.nickname = user.NickName;
                result.isShopNotification = true;
                result.tutorial = 13;
            }
            else
            {
                result.hasPigg = LoginResultData.HAS_PIGG_UNCREATE;
                result.isFirstDay = true;

                result.isShopNotification = true;
            
            }
            client.manager.SendCommand(result);
        }
        public void onStartCreateUser(StartCreateUserData data, RemortClient client)
        {
            StartCreateUserResultData result = new StartCreateUserResultData();
            result.nickname = client.user.NickName;
            result.tutorialType = "";
            client.manager.SendCommand(result);
        }
        public void onCreate(CreateUserData data,RemortClient client)
        {
      
            client.user.NickName = data.nickname;
            client.user.SetPosition( data.data.position);
            client.user.SetItem( data.data.item);
            client.user.SetParts( data.data.part);
            client.user.SetColor( data.data.color);
            client.user.HasAvatarCreated = true;
            using (var db = new AmebaContext())
            {
               db.Users.Attach(client.user);
                db.Entry(client.user).State = EntityState.Modified;
                db.SaveChanges();
            }
            onLogin(null, client);
        }
        public void onGetArea(GetAreaData data,RemortClient client)
        {
            GetAreaResultData result = new GetAreaResultData();
            result.category = data.category;
            result.code = data.code;
            result.server = "chat01.pigg.ameba.jp:1936";
            result.protocol = "rtmp";
            client.manager.SendCommand(result);
        }
    }
}
