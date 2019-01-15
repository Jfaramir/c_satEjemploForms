using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
//este es el q contiene la declaracion del DataTable
using System.Data;


namespace EjemploForms
{
    class Conexion
    {
        public MySqlConnection conexion;

        public Conexion()
        {
            conexion = new MySqlConnection("Server = 127.0.0.1 = test; Uid = root;  Pwd =; Port = 3306");
        }

        public DataTable getClientes()
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta = new MySqlCommand("Select * from h1");
                MySqlDataReader resultado = consulta.ExecuteReader();
                DataTable clientes = new DataTable();
                clientes.Load(resultado);
                conexion.Close();
                return clientes;
            }

            catch(MySqlException e)
            {
                throw e;
            }
        }

    }
}
