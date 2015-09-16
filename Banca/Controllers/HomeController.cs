using Banca.Models;
using ClassLibrary1PeixeiraConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Banca.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// /fazer um controller do professor e por isso dentro
        /// </summary>
        
        // GET: Home
        public ActionResult Index()
        {
            

            return View();
        }
    }
}