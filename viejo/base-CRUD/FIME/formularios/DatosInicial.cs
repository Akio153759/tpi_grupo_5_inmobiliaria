using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace FIME
{
    class DatosInicial : Datos
    {
        
         public void actualizarCONparametros(string consultaSQL, inicial pedido)
        {

            conectarBD();
            pComando.CommandText = consultaSQL;

            pComando.Parameters.Clear();
            pComando.Parameters.AddWithValue("@idModulador", pedido.pIDinicial);
            pComando.Parameters.AddWithValue("@nombreModulador", pedido.pNombreInicial);
            pComando.Parameters.AddWithValue("@nombreReferencia", pedido.pNombreReferencia);
            pComando.Parameters.AddWithValue("@pesoEstimado", pedido.pPesoEstimado);
            pComando.Parameters.AddWithValue("@stock", pedido.pStock);
            pComando.Parameters.AddWithValue("@precioCostoKg", pedido.pPrecioXkg);
            pComando.Parameters.AddWithValue("@fechaModificacion", pedido.pFechaModificacion); // convert.dateTime
            

            pComando.ExecuteNonQuery();
            desconectarBD();

        }

    }
}
