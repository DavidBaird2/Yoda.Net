
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yoda.Net.Networking;
using Yoda.Net.Networking.Packet.Info.User;

namespace Yoda.Net.Client
{

    /// <summary>
    /// InfoClient向けのクライアント
    /// </summary>
    public class InfoClient : CommandClient
    {
        public BotSession session;
        public InfoClient(BotSession client, IMessageHandler del)
            : base( del, ServerType.Info)
        {
            base.manager.OnSocketClosed += manager_OnSocketClosed;
        }

        public override void onReady()
        {
            manager.SendCommand(new LoginData(session.ticket, session.authTicket, session.userAgent, session.flashPlayerVersion, session.frmId));
        }
        void manager_OnSocketClosed()
        {
            
        }
    }
}
