using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;

namespace FIME
{
    class Moduladores
    {
        Datos oDatos = new Datos();

        int idModulador;
        string nombreModulador;
        int precioCostoKg;
        

        double pesoEstimado;
        string nombreReferencia;
        DateTime fechaModificacion;
        int stock;

        public int pIDmodulador
        {
            get { return idModulador; }
            set { idModulador = value; }
        }

        public string pNombreModulador
        {
            get { return nombreModulador; }
            set { nombreModulador = value; }
        }
        
        public int pPrecioXkg
        {
            get { return precioCostoKg; }
            set { precioCostoKg = value; }
        }
        

        public double pPesoEstimado
        {
            get { return pesoEstimado; }
            set { pesoEstimado = value; }
        }
        

        public int pStock
        {
            get { return stock; }
            set { stock = value; }
        }
        
        public DateTime pFechaModificacion
        {
            get { return fechaModificacion; }
            set { fechaModificacion = value; }
        }

        public string pNombreReferencia { get => nombreReferencia; set => nombreReferencia = value; }

        override public string ToString()
        {
            return "Modulador " + nombreModulador  ;
        }

        /////////////////////////////////////////////
        ///

        public DataTable recuperarModuladores ()
        {

            return oDatos.consultarTabla("MODULADORES");
        }



        public void actualizar()
        {
            string consultaSQL = "UPDATE MODULADORES SET nombreModulador=@nombreModulador,pesoEstimado=@pesoEstimado,stock=@stock,nombreReferencia=@nombreReferencia,fechaModificacion=@fechaModificacion,precioCostoKg=@precioCostoKg WHERE IdModulador = @IdModulador";

            oDatos.conectarBD();
            oDatos.pComando.CommandText = consultaSQL;

            oDatos.pComando.Parameters.Clear();
            oDatos.pComando.Parameters.AddWithValue("@idModulador", this.pIDmodulador);
            oDatos.pComando.Parameters.AddWithValue("@nombreModulador", this.pNombreModulador);
            oDatos.pComando.Parameters.AddWithValue("@nombreReferencia", this.pNombreReferencia);
            oDatos.pComando.Parameters.AddWithValue("@pesoEstimado", this.pPesoEstimado);
            oDatos.pComando.Parameters.AddWithValue("@stock", this.pStock);
            oDatos.pComando.Parameters.AddWithValue("@precioCostoKg", this.pPrecioXkg);
            oDatos.pComando.Parameters.AddWithValue("@fechaModificacion", this.pFechaModificacion); // convert.dateTime


            oDatos.pComando.ExecuteNonQuery();
            oDatos.desconectarBD();



        }

        public void insertar()
        {
            string consultaSQL = "INSERT INTO MODULADORES (nombreModulador,precioCostoKg,pesoEstimado,stock,nombreReferencia,fechaModificacion)" +
                                        " VALUES ( @nombreModulador,@precioCostoKg,@pesoEstimado,@stock,@nombreReferencia,@fechaModificacion )";

            oDatos.conectarBD();
            oDatos.pComando.CommandText = consultaSQL;

            oDatos.pComando.Parameters.Clear();
            oDatos.pComando.Parameters.AddWithValue("@idModulador", this.pIDmodulador);
            oDatos.pComando.Parameters.AddWithValue("@nombreModulador", this.pNombreModulador);
            oDatos.pComando.Parameters.AddWithValue("@nombreReferencia", this.pNombreReferencia);
            oDatos.pComando.Parameters.AddWithValue("@pesoEstimado", this.pPesoEstimado);
            oDatos.pComando.Parameters.AddWithValue("@stock", this.pStock);
            oDatos.pComando.Parameters.AddWithValue("@precioCostoKg", this.pPrecioXkg);
            oDatos.pComando.Parameters.AddWithValue("@fechaModificacion", this.pFechaModificacion); // convert.dateTime


            oDatos.pComando.ExecuteNonQuery();
            oDatos.desconectarBD();



        }
        public void eliminar(int PK)
        {
            string consultaSQL = "DELETE FROM MODULADORES WHERE IdModulador = " + PK;
            oDatos.conectarBD();
            oDatos.pComando.CommandText = consultaSQL;
            oDatos.pComando.ExecuteNonQuery();
            oDatos.desconectarBD();


        }


    }
}
