using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;


namespace AssignmentPorfolio_Flybook_V2
{
    [HubName("chat")]
    public class MyHub1 : Hub
    {
        public void HelloSendMessage(string name, string message)
        {
            Clients.All.broadcastMessage(name, message);
        }

    }
}