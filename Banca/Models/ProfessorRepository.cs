using ClassLibrary1PeixeiraConnection;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Banca.Models
{
    public class ProfessorRepository
    {
        Conexao conn = new Conexao();

        public IEnumerable<Professor> getAll()
        {
            string sql = "SELECT * FROM professores";
            MySqlDataReader dr = conn.executarConsulta(sql);

            List<Professor> professores = new List<Professor>();
            while (dr.Read())
            {///parse do banco para oo
                professores.Add(new Professor((int)dr["id"],(string)dr["nome"]));
            }
            return professores;
        }

        public void create(Professor pProfessor)
        {
            
        }

        public void update(Professor pProfessor)
        {
           

        }
        public void delete(int pId)
        {
            
        }
    }
}