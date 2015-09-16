using Banca.Models;
using ClassLibrary1PeixeiraConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Banca.Controllers
{
    public class AlunoController : Controller
    {
        // GET: Aluno
        AlunoRepository alunoRepo = new AlunoRepository();
        public ActionResult Alunos()
        {
            var alunos = alunoRepo.getAll();

            return View(alunos);
        }

        public ActionResult create()
        {          
            return View();
        }

        [HttpPost]
        public ActionResult create(Aluno pAluno)
        {
            alunoRepo.create(pAluno);
            return RedirectToAction("Alunos");
        }

        public ActionResult Update(int Id)
        {
            var aluno = alunoRepo.getOne(Id);
            return View(aluno); 
        }

        [HttpPost]
        public ActionResult Update(Aluno pAluno)
        {
            alunoRepo.update(pAluno);
            return RedirectToAction("Alunos");
        }
    }
}