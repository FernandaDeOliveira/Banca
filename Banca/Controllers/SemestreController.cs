using Banca.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Banca.Controllers
{
    public class SemestreController : Controller
    {
        // GET: Semestre
        SemestreRepository semRepo = new SemestreRepository();
        public ActionResult Semestre()
        {

            var semestre = semRepo.getAll();

            return View(semestre);
        }
    }
}