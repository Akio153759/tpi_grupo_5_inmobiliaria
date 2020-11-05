using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;



namespace Inmobiliaria
{
    class Datos 
    {
        //Base de datos SQL server
        SqlConnection conexionBD;
        SqlCommand comando;
        string cadenaConeccion;


        DataTable tabla = new DataTable();
        SqlDataReader lector;
       



        public SqlDataReader pLectorDataReader { get => lector; set => lector = value; }
        public string pCadenaConeccion { get => cadenaConeccion; set => cadenaConeccion = value; }
        public SqlCommand pComando { get => comando; set => comando = value; }

        public Datos()
        {
            conexionBD = new SqlConnection();
            pComando = new SqlCommand();

            cadenaConeccion = @"Data Source=NOTE_ALE\SQLEXPRESS;Initial Catalog=GyG;Integrated Security=True";



        }

        public Datos(string cadenaConeccion)
        {
            conexionBD = new SqlConnection();
            pComando = new SqlCommand();
            this.pCadenaConeccion = cadenaConeccion;
        }


        public void conectarBD()
        {

            conexionBD.ConnectionString = pCadenaConeccion;
            try
            {
                conexionBD.Open();
                pComando.Connection = conexionBD;
                pComando.CommandType = CommandType.Text;
            }
            catch
            {
                // error de coneccion
                int pp = 0;
            }
        }

        public void desconectarBD()
        {
            conexionBD.Close();
        }
        public DataTable consultarTabla(string nombreTabla)
        {
            conectarBD();

                pComando.CommandText = "SELECT * FROM " + nombreTabla;

                DataTable tabla = new DataTable();
                tabla.Load(pComando.ExecuteReader());

            desconectarBD();

            return tabla;

        }

        public void leerTodaTabla(string nombreTabla)
        {
            conectarBD();
            pComando.CommandText = "SELECT * FROM " + nombreTabla;
            lector = pComando.ExecuteReader();

        }


        public void actualizarBD(string consultaSQL)
        {
            try
            {
                conectarBD();
                pComando.CommandText = consultaSQL;
                pComando.ExecuteNonQuery();
                desconectarBD();
            }
            catch(Exception e)
            {
                string pp = e.Message;
            }
           

        }

        public void maximoValor(string nombreTabla, string campo)
        {
            conectarBD();

            pComando.CommandText = "SELECT max (" + campo + ") FROM " + nombreTabla;

            lector = pComando.ExecuteReader();

        }


        public DataTable listarTablasBD(string nombreDB)
        {
            conectarBD();

            pComando.CommandText = "SELECT name FROM SYS.tables " + nombreDB;

            DataTable tabla = new DataTable();
            tabla.Load(pComando.ExecuteReader());

            desconectarBD();

            return tabla;

        }



        
    }
}
