using ClassLibrary1PeixeiraConnection;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Banca.Models
{
    public class SemestreRepository
    {
        Conexao conn = new Conexao();

        public IEnumerable<Semestre> getAll()
        {
            string sql = "SELECT * FROM semestre";
            MySqlDataReader dr = conn.executarConsulta(sql);

            List<Semestre> semestre = new List<Semestre>();
            while (dr.Read())
            {///parse do banco para oo
                semestre.Add(new Semestre((int)dr["idSemestre"], (string)dr["nomeSemestre"]));
            }
            return semestre;
        }

        public void create(Semestre pSemestre)
        {
            
        }

        public void update(Semestre pSemestre)
        {
           

        }
        public void delete(int pId)
        {
            
        }

    }
}