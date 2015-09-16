using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Banca.Models
{
    public class Professor
    {
        #region Dominio
        public int IdProfessor { get; set; }
        public string NameProfessor { get; set; }
        #endregion


        #region Construtor
        public Professor()
        {

        }

        public Professor(int pId, string pName)
        {
            IdProfessor = pId;
            NameProfessor = pName;
        }

        #endregion
    }
}