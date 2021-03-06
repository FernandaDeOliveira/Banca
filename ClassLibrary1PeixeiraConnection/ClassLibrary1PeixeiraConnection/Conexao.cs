﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1PeixeiraConnection
{
    public class Conexao
    {
        public MySqlConnection conn = new MySqlConnection();
        public MySqlCommand cmm;
        public MySqlDataReader dr;

        public String conString
        {
            get { return "Server=localhost;Database=bancasDB;Uid=root;Pwd=vertrigo;"; }
        }

        #region Metodos

        private void conectar()
        {
            conn.ConnectionString = conString;
            if (conn.State != System.Data.ConnectionState.Open)
            {
                conn.Open();
            }
        }

        private void desconectar()
        {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        }
        public void executarComando(string pSql)
        {
            conectar();
            cmm = new MySqlCommand(pSql, conn);
            cmm.ExecuteNonQuery();
        }
        public MySqlDataReader executarConsulta(string pSql)
        {
            conectar();
            cmm = new MySqlCommand();
            cmm.Connection = conn;
            cmm.CommandText = pSql;
            dr = cmm.ExecuteReader();

            return dr;
        }
        #endregion
    }
}
