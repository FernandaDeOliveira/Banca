using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Banca.Models
{
    public class Semestre
    {
        #region Dominio
        public int IdSemestre { get; set; }
        public string NameSemestre { get; set; }
        #endregion


        #region Construtor
        public Semestre()
        {

        }

        public Semestre(int pId, string pName)
        {
            IdSemestre = pId;
            NameSemestre = pName;
        }

        #endregion
    }
}