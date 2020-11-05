using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIME
{
    public partial class frmInicial : frmCRUD
    {
        DatosInicial objetoBaseDatos = new DatosInicial();

        const int tamanoDeArreglo = 1000;
        inicial[] arregloIniciales = new inicial[tamanoDeArreglo];


        List<inicial> lista = new List<inicial>();

        int ultimoIDseleccionado =0;
        public frmInicial()
        {

            InitializeComponent();
            // 2do _ Inicializamos el arreglo 
            for (int i = 0; i < tamanoDeArreglo; i++)
            {
                arregloIniciales[i] = null;
            }


            tabla_A = "Moduladores";
            nombre_campo_id_A = "IdModulador";
            nombre_campo_display_A = "nombreInicial";

            tabla_B = "COSTOxKG";
            nombre_campo_id_B = "idCostoXkg";
            nombre_campo_display_B = "monto";
        }


        override public void cargarLista(string nombreTabla)
        {

            objetoBaseDatos.leerTabla(nombreTabla);

            contadorIndiceArreglo = 0;// inicializa el arreglo
            lista.Clear(); // Limpia la lista

            while (objetoBaseDatos.pLectorDataReader.Read())
            {
                inicial nuevoInicial = new inicial();
                if (!objetoBaseDatos.pLectorDataReader.IsDBNull(0))
                    nuevoInicial.pIDinicial = objetoBaseDatos.pLectorDataReader.GetInt32(0);

                if (!objetoBaseDatos.pLectorDataReader.IsDBNull(1))
                    nuevoInicial.pNombreInicial = objetoBaseDatos.pLectorDataReader.GetString(1);


                //if (!objetoBaseDatos.pLectorDataReader.IsDBNull(3))
                //    nuevoInicial.pPesoEstimado = objetoBaseDatos.pLectorDataReader.GetInt32(3);

                if (!objetoBaseDatos.pLectorDataReader.IsDBNull(3))
                    nuevoInicial.pPesoEstimado= objetoBaseDatos.pLectorDataReader.GetDouble(3);

                if (!objetoBaseDatos.pLectorDataReader.IsDBNull(4))
                    nuevoInicial.pStock = objetoBaseDatos.pLectorDataReader.GetInt32(4);

                if (!objetoBaseDatos.pLectorDataReader.IsDBNull(5))
                    nuevoInicial.pNombreReferencia = objetoBaseDatos.pLectorDataReader.GetString(5);

                if (!objetoBaseDatos.pLectorDataReader.IsDBNull(6)) // si NO es nulo el valor de la columna 4 . . . .
                    nuevoInicial.pFechaModificacion = Convert.ToDateTime(objetoBaseDatos.pLectorDataReader["fechaModificacion"].ToString());

                if (!objetoBaseDatos.pLectorDataReader.IsDBNull(7))
                    nuevoInicial.pPrecioXkg = objetoBaseDatos.pLectorDataReader.GetInt32(7);

                arregloIniciales[contadorIndiceArreglo] = nuevoInicial; //cargamos el arreglo

                /////////////////////
                lista.Add(nuevoInicial);//  Cargamos la lista






                contadorIndiceArreglo++;
            }

            objetoBaseDatos.pLectorDataReader.Close();
            objetoBaseDatos.desconectarBD();

            lstPrincipal.Items.Clear();
            for (int jj = 0; jj < contadorIndiceArreglo; jj++) // Cargamos la lista desde el arreglo
            {
                lstPrincipal.Items.Add(arregloIniciales[jj].ToString());
            }
            lstPrincipal.SelectedIndex = ultimoIDseleccionado;


            // mostramos de la lista
            lst_A.Items.Clear();
            for (int xx = 0; xx < lista.Count; xx++)
            {
                lst_A.Items.Add(lista[xx].ToString());
            }

            
        }

        override public void rotuladoLabels()
        { // Le damos valor a la etiquetas que tenemos
            lblCaja1.Text = "ID Inicial";
            lblCaja2.Text = "Nombre de Inicial";
            lblCaja3.Text = "Nombre de Referencia";
            lblCaja4.Text = "Peso estimado";
            lblCaja5.Text = "Stock";
            lblCaja6.Text = "Precio x Kg";

            lblfecha.Text = "Fecha de Modificacion";


        }



        override public void cargarCampos(int posicion)
        {

            txtCaja1.Text = arregloIniciales[posicion].pIDinicial.ToString();
            txtCaja2.Text = arregloIniciales[posicion].pNombreInicial;
            txtCaja3.Text = arregloIniciales[posicion].pNombreReferencia;
            txtCaja4.Text = arregloIniciales[posicion].pPesoEstimado.ToString();
            txtCaja5.Text = arregloIniciales[posicion].pStock.ToString();
            

            //if (arregloIniciales[posicion].pPesoEstimado == 1)
            //    rbtRadio1.Checked = true;

            //if (arregloIniciales[posicion].pPesoEstimado == 2)
            //    rbtRadio2.Checked = true;

            cboCombo_B.SelectedValue = arregloIniciales[posicion].pPrecioXkg;

            cajaFecha.Value = arregloIniciales[posicion].pFechaModificacion;

        }

         public void actualizarConParametros()
        {
            // update

            int indice = lstPrincipal.SelectedIndex;
            arregloIniciales[indice].pIDinicial = Int32.Parse(txtCaja1.Text);
            arregloIniciales[indice].pNombreInicial = txtCaja2.Text;
            arregloIniciales[indice].pNombreReferencia = txtCaja3.Text;
            arregloIniciales[indice].pPesoEstimado = double.Parse(txtCaja4.Text);
            arregloIniciales[indice].pStock = Int32.Parse(txtCaja5.Text);
            arregloIniciales[indice].pPrecioXkg = (int)cboCombo_B.SelectedValue;
            
            arregloIniciales[indice].pFechaModificacion = cajaFecha.Value;


            //
            //arregloIniciales[indice].pPrecioXkg = Convert.ToDouble(txtCaja4.Text);

            string consultaSQL = "UPDATE " + tabla_A + " SET nombreModulador=@nombreModulador,pesoEstimado=@pesoEstimado,stock=@stock,nombreReferencia=@nombreReferencia,fechaModificacion=@fechaModificacion,precioCostoKg=@precioCostoKg WHERE IdModulador = @IdModulador";

            objetoBaseDatos.actualizarCONparametros(consultaSQL, arregloIniciales[indice]);

            ultimoIDseleccionado = indice;

        }


        override public void insertaNuevoRegistro()
        {
            // insert
            inicial nuevoInicial = new inicial();
            nuevoInicial.pIDinicial = Int32.Parse(txtCaja1.Text);
            nuevoInicial.pNombreInicial = txtCaja2.Text;
            //productproductoPedido.pStock = (int)cboCombo_A.SelectedValue;
            nuevoInicial.pStock = Int32.Parse(txtCaja5.Text);
            //productproductoPedido.pPrecioXkg = double.Parse(txtCaja4.Text);
            nuevoInicial.pFechaModificacion = cajaFecha.Value;

            if (rbtRadio1.Checked)
                nuevoInicial.pPesoEstimado = 1;
            if (rbtRadio2.Checked)
                nuevoInicial.pPesoEstimado = 2;


            //if (!existe(productproductoPedido.pIDInicial))
            //{

                string consultaSQL = "INSERT INTO producto (detalle,tipo,marca,precio,fecha)" +
                                       " VALUES ('" + nuevoInicial.pNombreInicial + "',"
                                                    + nuevoInicial.pPesoEstimado + ","
                                                    + nuevoInicial.pStock + ","
                                                    + nuevoInicial.pPrecioXkg + ",'"
                                                    + nuevoInicial.pFechaModificacion + "'"
                                                    + ")";


                objetoBaseDatos.actualizar(consultaSQL);
            //}

            banderaNuevoPedido = false;
        }

        public void insertarConParametros()
        {
            // insert
            inicial nuevoInicial = new inicial();
            nuevoInicial.pIDinicial = Int32.Parse(txtCaja1.Text);
            nuevoInicial.pNombreInicial = txtCaja2.Text;
            nuevoInicial.pNombreReferencia = txtCaja3.Text;
            nuevoInicial.pPesoEstimado = double.Parse(txtCaja4.Text);
            nuevoInicial.pStock = Int32.Parse(txtCaja5.Text);
            nuevoInicial.pPrecioXkg = (int)cboCombo_B.SelectedValue;

            nuevoInicial.pFechaModificacion = cajaFecha.Value;

            string consultaSQL = "INSERT INTO MODULADORES (nombreModulador,precioCostoKg,pesoEstimado,stock,nombreReferencia,fechaModificacion)" +
                                       " VALUES ( @nombreModulador,@precioCostoKg,@pesoEstimado,@stock,@nombreReferencia,@fechaModificacion )";


            objetoBaseDatos.actualizarCONparametros(consultaSQL, nuevoInicial);

            banderaNuevoPedido = false;
            ultimoIDseleccionado = lstPrincipal.Items.Count;
        }

        override public void actualizaRegistro()
        {
            // update

            int indice = lstPrincipal.SelectedIndex;
            arregloIniciales[indice].pIDinicial = Int32.Parse(txtCaja1.Text);
            arregloIniciales[indice].pNombreInicial = txtCaja2.Text;
            //arregloIniciales[indice].pStock = (int)cboCombo_A.SelectedValue;
            arregloIniciales[indice].pStock = Int32.Parse(txtCaja5.Text);
            //arregloIniciales[indice].pPrecioXkg = Convert.ToDouble(txtCaja4.Text);
            arregloIniciales[indice].pFechaModificacion = cajaFecha.Value;

            if (rbtRadio1.Checked)
                arregloIniciales[indice].pPesoEstimado = 1;

            if (rbtRadio2.Checked)
                arregloIniciales[indice].pPesoEstimado = 2;

            string consultaSQL = "UPDATE Producto SET detalle='" + arregloIniciales[indice].pNombreInicial + "',"
                                                            + "tipo=" + arregloIniciales[indice].pPesoEstimado + ","
                                                            + "marca=" + arregloIniciales[indice].pStock + ","
                                                            + "precio=" + arregloIniciales[indice].pPrecioXkg + ","
                                                            + "fecha= '" + arregloIniciales[indice].pFechaModificacion

                                                            + "' WHERE codigo = " + arregloIniciales[indice].pIDinicial;
            objetoBaseDatos.actualizar(consultaSQL);


        }


        override public void BtnBorrar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Esta seguro de eliminar este Inicial ?",
                                "Borrando",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Warning,
                                MessageBoxDefaultButton.Button2) == DialogResult.Yes)

            {
                // ------> BORRAR o DELETE;
               
                eliminarRegistro(tabla_A, nombre_campo_id_A, arregloIniciales[lstPrincipal.SelectedIndex].pIDinicial);

            }

        }
        public void eliminarRegistro(string tabla, string nombreCampoReferencia, int idRegistro)
        {

            

            string consultaSQL = "DELETE FROM " + tabla + " WHERE " + nombreCampoReferencia + " = " + idRegistro;
            //string consultaSQL = "DELETE FROM " +tabla + " WHERE codigo = " + arregloIniciales[lstIniciales.SelectedIndex].pIDInicial;
            objetoBaseDatos.actualizar(consultaSQL);
            cargarLista(tabla_A);
            limpiar();
        }

        private void cargarCombo(ComboBox combo, string nombreTabla, string campoDisplay, string campoID)
        {

            DataTable tabla = new DataTable();

            tabla = objetoBaseDatos.consultarTabla(nombreTabla);
            combo.DataSource = tabla;
            combo.DisplayMember = campoDisplay;
            combo.ValueMember = campoID;

        }
        private void cargarCombo1(ComboBox combo, string nombreTabla)
        {
            DataTable tabla = new DataTable();
            tabla = objetoBaseDatos.consultarTabla(nombreTabla);
            combo.DataSource = tabla;
            combo.DisplayMember = tabla.Columns[1].ColumnName;
            combo.ValueMember = tabla.Columns[0].ColumnName;
        }

        private void Prueba_Load(object sender, EventArgs e)
        {
            if (tabla_A != "")
                cargarCombo(cboCombo_A, tabla_A, nombre_campo_display_A, nombre_campo_id_A);
            if (tabla_B != "")
                cargarCombo(cboCombo_B, tabla_B, nombre_campo_display_B, nombre_campo_id_B);
            
            if (tabla_C != "")
                cargarCombo(cboCombo_C, tabla_C, nombre_campo_display_C, nombre_campo_id_C);

            if (tabla_D != "")
                cargarCombo(cboCombo_D, tabla_D, nombre_campo_display_D, nombre_campo_id_D);

            cargarLista(tabla_A); // cargamos la lista desde la tabla preoductos

            cboCombo_B.SelectedIndex = cboCombo_B.Items.Count - 1;  ///Seleccionamos el ultimo
        }

        private void BtnUltimoPrecio_Click(object sender, EventArgs e)
        {
            cboCombo_B.SelectedIndex = cboCombo_B.Items.Count - 1;  ///Seleccionamos el ultimo precio
        }

        override public bool validarDatos()
        {

            if(!verificarTEXTBOXvacio(txtCaja1,"Falta codigo ID "))
                return false;

            if (!verificarTEXTBOXvacio(txtCaja2, "Falta colocar Nombre Inicial . . ."))
                return false;

            if (!verificarTEXTBOXvacio(txtCaja3, "Falta colocar Nombre REFERENCIA . . ."))
                return false;

            if (!verificarSiDOUBLE(txtCaja4, "Falta colocar PESO ESTIMADO o VALOR NO VALIDO. . ."))
                return false;

            if (!verificarSiINT(txtCaja5, "Falta colocar STOCK o VALOR NO VALIDO  . . ."))
                return false;

            if (!verificaCombo(cboCombo_B, "Falta seleccionar $ x KG nuevo. . ."))
                return false;
            
            return true;
        }

       
    }



}
