using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Banca.Models
{
    public class Aluno
    {
        #region Dominio
        public int IdAluno { get; set; }
        public string NameAluno { get; set; }
        #endregion


        #region Construtor
        public Aluno()
        {

        }

        public Aluno(int pId, string pName)
        {
            IdAluno = pId;
            NameAluno = pName;
        }

        #endregion
    }
}