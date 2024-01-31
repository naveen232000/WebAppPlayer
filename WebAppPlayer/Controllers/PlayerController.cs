using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAppPlayer.Controllers
{
    public class PlayerController : Controller
    {
        // GET: Player
        List<Player> ListPlayer = new List<Player>() { 
        new Player(){Id=1,Name="MSD",Age=50,Team="Csk"},
         new Player(){Id=2,Name="VK",Age=50,Team="RCB"},
          new Player(){Id=3,Name="RS",Age=50,Team="MI"},
           new Player(){Id=4,Name="Rizvi",Age=50,Team="Csk"},
            new Player(){Id=5,Name="Rinku",Age=50,Team="KKR"},
        };
        public ActionResult Index()
        {
            return View(ListPlayer);
        }
    }
}