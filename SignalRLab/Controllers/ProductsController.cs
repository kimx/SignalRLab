using Microsoft.AspNet.SignalR;
using SignalRLab.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SignalRLab.Controllers
{
    public class ProductsController : Controller
    {
        //
        // GET: /Products/
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string name)
        {
            IHubContext context = GlobalHost.ConnectionManager.GetHubContext<MyHub>();
            Product p = new Product();
            p.Name = name;
            p.Category = DateTime.Now.ToString();
            context.Clients.All.sendMessage(p);
          //  h.Send(name, "Server Send:" + DateTime.Now.ToString());
            return View();//此範例需將WinForm執行起來
        }
    }
}