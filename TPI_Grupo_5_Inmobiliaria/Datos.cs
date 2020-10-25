using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;



namespace TPI_Grupo_5_Inmobiliaria
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

            // cadena Ale
            cadenaConeccion = @"Data Source=NOTE_ALE\SQLEXPRESS;Initial Catalog=INMOBILIARIA;Integrated Security=True";



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

        public void leerTabla(string nombreTabla)
        {
            conectarBD();
            pComando.CommandText = "SELECT * FROM " + nombreTabla;
            lector = pComando.ExecuteReader();

        }


        public void actualizar(string consultaSQL)
        {
            conectarBD();
            pComando.CommandText = consultaSQL;
            pComando.ExecuteNonQuery();
            desconectarBD();

        }

        public void maximoValor(string nombreTabla, string campo)
        {
            conectarBD();

            pComando.CommandText = "SELECT max (" + campo + ") FROM " + nombreTabla;

            lector = pComando.ExecuteReader();

        }


        



        // consiltas entregadas en el practico
        public DataTable consulta1()
        {
            conectarBD();

            pComando.CommandText = "select e.codEmpleado as 'Cod. Empleado', " +
                                    "e.nombreEmpleado + ' ' + e.apellidoEmpleado as 'Nombre completo', " +
                                    "count(*) as 'Cantidad de ventas', " +
                                    "avg(o.montoTotal) as 'Monto promedio' " +
                                    "from OPERACIONES o inner join EMPLEADOS e on o.codEmpleado = e.codEmpleado " +
                                    "inner join TIPOS_OPERACIONES t on o.idTipoOperacion = t.idTipoOperacion " +
                                    " where year(o.fechaOperancion) = year(getdate()) and t.descripcion = 'Venta'" +
                                    " group by e.codEmpleado, e.nombreEmpleado + ' ' + e.apellidoEmpleado " +
                                    " having COUNT(*) < (select count(*) / count(distinct op.codEmpleado)" +
                                    "                       from OPERACIONES op " +
                                    "                            where year(op.fechaOperancion) = year(getdate()))";

            DataTable tabla = new DataTable();
            tabla.Load(pComando.ExecuteReader());

            desconectarBD();

            return tabla;

        }

            public DataTable consulta2()
        {
            conectarBD();

            pComando.CommandText = "select b.idBarrio as 'Cod. Barrio', b.barrio as 'Barrio', count(*) as 'Cant. Operaciones' " +
                                    "from OPERACIONES o inner join PROPIEDADES p on o.codPropiedad = p.codPropiedad " +
                                    "inner join BARRIOS b on p.idBarrio = b.idBarrio " +
                                    " where year(o.fechaOperancion) between year(getdate()) -5 and year(getdate()) " +
                                    " group by b.idBarrio, b.barrio " +
                                    " having count(*) >= 3 " +
                                    " order by 'Cant. Operaciones'";

            DataTable tabla = new DataTable();
            tabla.Load(pComando.ExecuteReader());

            desconectarBD();

            return tabla;

        }


        public DataTable consulta3()
        {
            conectarBD();

            pComando.CommandText = "select lo.localidad ' localidad',ba.barrio'Barrio', count(pro.codPropiedad)' Cant Propiedades'" +
                                    " from PROPIETARIOSxPROPIEDADES pXp join PROPIETARIOS pr on " +
                                    " pXp.idPropietario = pr.idPropietario " +
                                    " join PROPIEDADES pro on pro.codPropiedad = pxp.codPropiedad " +
                                    " join BARRIOS ba on pro.idBarrio = ba.idBarrio " +
                                    " join LOCALIDADES lo on lo.idLocalidad = ba.idLocalidad " +
                                    " where pro.aptoAlquiler = 1";

            DataTable tabla = new DataTable();
            tabla.Load(pComando.ExecuteReader());

            desconectarBD();

            return tabla;

        }

    }
}
