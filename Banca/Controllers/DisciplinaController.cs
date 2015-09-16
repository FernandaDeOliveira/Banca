using Banca.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Banca.Controllers
{
    public class DisciplinaController : Controller
    {
        // GET: Disciplina
        DisciplinasRepository discRepo = new DisciplinasRepository();
        public ActionResult Disciplina()
        {
            var disciplina = discRepo.getAll();

            return View(disciplina);
        }
    }
}