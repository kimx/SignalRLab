using Microsoft.AspNet.SignalR;
using SignalRLab.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SignalRLab
{
    public class MyHub : Hub
    {
        public void Send(string name, string message)//Send=>Server Method
        {
            Product p = new Product();
            p.Name = name;
            p.Category = message;
            Clients.All.sendMessage(p);//sendMessage==>Client Menthod

        }
    }
}