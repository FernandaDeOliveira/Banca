using ClassLibrary1PeixeiraConnection;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Banca.Models
{
    public class AlunoRepository
    {
        Conexao conn = new Conexao();

        public IEnumerable<Aluno> getAll()
        {
            string sql = "SELECT * FROM alunos";
            MySqlDataReader dr = conn.executarConsulta(sql);

            List<Aluno> alunos = new List<Aluno>();
            while (dr.Read())
            {///parse do banco para oo
                alunos.Add(new Aluno((int)dr["idAluno"], (string)dr["nomeAluno"]));
            }
            return alunos;
        }

        public Aluno getOne(int pId)
        {
            string sql = "SELECT * FROM alunos WHERE idAluno="+pId;
            MySqlDataReader dr = conn.executarConsulta(sql);

            dr.Read();
            Aluno alunoEditando = (new Aluno((int)dr["idAluno"], (string)dr["nomeAluno"]));
            return alunoEditando;          
        }

        public void create(Aluno pAluno)
        {
            string insert = "INSERT INTO alunos value(";
            insert+=pAluno.IdAluno+",'"+pAluno.NameAluno+"')";
            conn.executarComando(insert);
        }

        public void update(Aluno pAluno)
        {
            string update = "UPDATE alunos set nomeAluno='" + pAluno.NameAluno + "' WHERE idAluno=" + pAluno.IdAluno;
            conn.executarComando(update);
        }
        public void delete(int pId)
        {
            
        }
    }
}