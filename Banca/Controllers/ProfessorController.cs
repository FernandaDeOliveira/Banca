using Banca.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Banca.Controllers
{
    public class ProfessorController : Controller
    {
        // GET: Professor
        ProfessorRepository profRepo = new ProfessorRepository();
        public ActionResult Professores()
        {
            var professores = profRepo.getAll();

            return View(professores);
        }
    }
}