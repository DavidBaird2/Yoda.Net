using libPigg.net.info.user;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yoda.Net.Networking;

namespace Yoda.Net.Client
{
    public class InfoClient : CommandClient
    {
        public BotSession session;
        public InfoClient(BotSession client, IMessageDelegate del)
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
