﻿using System.Data.SqlClient;
using System.Data;

namespace ChivoFlixDesktop.Data
{
    class ValidarLogin
    {
        readonly Conexion conexion = new Conexion();

        SqlConnection cnn;
        SqlCommand cmd;
        SqlDataReader dr;

        public bool ConexionBd()
        {
            try
            {
                string database = "Data Source=" + conexion.servidor + ";Initial Catalog=CHIVOFLIX;Integrated Security=True";
                cnn = new SqlConnection(database);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Login(string username, string password)
        {
            bool solicitud = false;
            if (ConexionBd())
            {
                cmd = new SqlCommand
                {
                    Connection = cnn,
                    CommandType = CommandType.Text,
                    CommandText = "select * from usuarios where username = '" + username + "' and password = '" + password + "' and idRol = 1"
                };
                cnn.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    solicitud = true;
                }
                else
                {
                    solicitud = false;
                }
                cnn.Close();
                return solicitud;
            }
            else
            {
                return solicitud;
            }
        }
    }
}
