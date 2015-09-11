
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yoda.Net.Networking;
using Yoda.Net.Networking.Packet.Info.Area;
using Yoda.Net.Networking.Packet.Info.User;

namespace Yoda.Net.Client
{

    /// <summary>
    /// InfoClient向けのクライアント
    /// </summary>
    public class InfoClient : CommandClient
    {
        public BotUser session;
        public InfoClient(BotUser client)
            : base( ServerType.Info)
        {
            session = client;
            base.manager.OnSocketClosed += manager_OnSocketClosed;
        }

        public override void onReady()
        {
            SendCommand(new LoginData(session.ticket, session.authTicket, session.userAgent, session.flashPlayerVersion, session.frmId));
        }
        void manager_OnSocketClosed()
        {
            
        }

        public void GetArea(string category, string code)
        {
            if (isGettingArea)
            {
                return;
            }
            SendCommand(new GetAreaData(category, code));
        }

        public bool isGettingArea { get; set; }
    }
}
