using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Banca.Models
{
    public class Disciplinas
    {
        #region Dominio
        public int IdDisciplina { get; set; }
        public string NameDisciplina { get; set; }
        #endregion


        #region Construtor
        public Disciplinas()
        {

        }

        public Disciplinas(int pId, string pName)
        {
            IdDisciplina = pId;
            NameDisciplina = pName;
        }

        #endregion
    }
}