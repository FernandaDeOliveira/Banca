using ClassLibrary1PeixeiraConnection;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Banca.Models
{
    public class DisciplinasRepository
    {
        Conexao conn = new Conexao();

        public IEnumerable<Disciplinas> getAll()
        {
            string sql = "SELECT * FROM disciplinas";
            MySqlDataReader dr = conn.executarConsulta(sql);

            List<Disciplinas> disciplina = new List<Disciplinas>();
            while (dr.Read())
            {///parse do banco para oo
                disciplina.Add(new Disciplinas((int)dr["idDisciplina"], (string)dr["nomeDisciplina"]));
            }
            return disciplina;
        }

        public Disciplinas getOne(int pId)
        {
            string sql = "SELECT * FROM disciplinas WHERE idDisciplina=" + pId;
            MySqlDataReader dr = conn.executarConsulta(sql);

            dr.Read();
            Disciplinas disciplinaEditada = (new Disciplinas((int)dr["idDisciplina"], (string)dr["nomeDisciplina"]));
            return disciplinaEditada;
        }


        public void create(Disciplinas pDisciplina)
        {
            
        }

        public void update(Disciplinas pDisciplina)
        {
            

        }
        public void delete(int pId)
        {
            
        }
    }
}