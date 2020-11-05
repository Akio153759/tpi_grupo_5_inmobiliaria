using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FIME
{
    public partial class frmCRUD : Form
    {
        


        string nombreBD = "GYG";

        // tablas a cargar en los combos
        protected string tabla_A, nombre_campo_id_A, nombre_campo_display_A ;
        protected string tabla_B, nombre_campo_id_B, nombre_campo_display_B;
        protected string tabla_C, nombre_campo_id_C, nombre_campo_display_C;
        protected string tabla_D, nombre_campo_id_D, nombre_campo_display_D;

        protected int ultimoRegistro; // la ultima PK de la tabla producto
        protected int contadorIndiceArreglo;// contador del arreglo

        protected bool banderaNuevoPedido; // bandera para controlar entre registro nuevo y modificado

        enum acciones //Enumeraciones
        {
            nuevo,
            editado,
            otro1,
            otro2
        }
         acciones miAccion;

        public frmCRUD()
        {
            InitializeComponent();


            

            // Inicializamos los combos
            tabla_A = "";
            nombre_campo_id_A = "";
            nombre_campo_display_A = "";

            tabla_B = "";
            nombre_campo_id_B = "";
            nombre_campo_display_B="";

            tabla_C = "";
            nombre_campo_id_C = "";
            nombre_campo_display_C= "";

            tabla_D = "";
            nombre_campo_id_D = "";
            nombre_campo_display_D= "";

            banderaNuevoPedido = false; // bandera pa controlar si el registro se edita o se hace 1 nuevo


            

            
            //listadoTablasBD = oDatos.listarTablas(nombreBD); // lista todas las tablas 
            //lst_B.DataSource = listadoTablasBD;
            //lst_B.DisplayMember = "name";


        }

       


        virtual public void rotuladoLabels()
        { // Le damos valor a la etiquetas que tenemos


        }

        virtual public void cargarLista(string nombreTabla)
        {   

        }

        virtual public void cargarCampos(int posicion)
        {

        }


        

        private void habilitar(bool ToF)
        {   
            //txtCaja1.Enabled = ToF;
            //txtCaja2.Enabled = ToF;
            //txtCaja3.Enabled = ToF;
            //txtCaja4.Enabled = ToF;
            //txtCaja5.Enabled = ToF;

            //cboCombo_A.Enabled = ToF;
            //cboCombo_B.Enabled = ToF;
            //cboCombo_C.Enabled = ToF;

            //rbtRadio1.Enabled = ToF;
            //rbtRadio2.Enabled = ToF;

            //cajaFecha.Enabled = ToF;

            //btnNuevo.Enabled = !ToF;
            //btnEditar.Enabled = !ToF;
            //btnBorrarModificado.Enabled = !ToF;
            //btnCancelar.Enabled = ToF;
            //btnEditar.Enabled = !ToF; 
            //btnGrabar.Enabled = ToF;

            //btnSalir.Enabled = !ToF;
            //lstPrincipal.Enabled = !ToF;

            

        }

         

        virtual public bool validarDatos()
        {   

            if (txtCaja1.Text == "")
            {
                MessageBox.Show("Falta colocar CODIGO . . .");
                txtCaja1.Focus();
                return false;
            }

            if (txtCaja2.Text == string.Empty)
            {
                MessageBox.Show("Falta colocar DETALLE . . .");
                txtCaja2.Focus();
                return false;
            }

            if (txtCaja4.Text=="")
            {
                MessageBox.Show("Falta colocar PRECIOS . . .");
                txtCaja4.Focus();
                return false;
            }

            if (cboCombo_A.SelectedIndex == -1)
            {
                MessageBox.Show("Falta seleccionar MARCA . . .");
                cboCombo_A.Focus();
                return false;
            }

            double valor = 0.25;
            if (!double.TryParse(txtCaja4.Text, out valor)) //Verificamos si el precio es un DOUBLE
            {
                MessageBox.Show("El numero debe ser decimal . . .");
                txtCaja4.Focus();
                return false;
            }
            return true;
        }


        virtual public void limpiar()
        {   

            txtCaja1.Text = string.Empty;
            txtCaja2.Clear();
            txtCaja3.Clear();
            txtCaja4.Clear();
            txtCaja5.Clear();

            cboCombo_A.SelectedIndex = -1;
            cboCombo_B.SelectedIndex = -1;
            cboCombo_C.SelectedIndex = -1;

            cajaFecha.Value = DateTime.Today; // fecha de hoy

        }

        private void FrmProducto_FormClosing(object sender, FormClosingEventArgs e)
        {   

            if (MessageBox.Show("Esta seguro de salir de la aplicacion ?",
                                "Saliendo",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question,
                                MessageBoxDefaultButton.Button1) == DialogResult.Yes)

            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }

        }








        //**********************   BOTONES ********************


        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            habilitar(false);
           
            banderaNuevoPedido = false;
        }

 ///////////////////   GRABAR      //////////////////////////////////////////////
        private void BtnGrabar_Click(object sender, EventArgs e)
        {   
           
            // 1ero validamos los datos
            if (validarDatos())
            {
               
                if (banderaNuevoPedido)
                {
                    // insert
                    //insertaNuevoRegistro();
                    insertar();
                }
                else
                {
                    // update
                    //actualizaRegistro();
                    actualizarBD();
                }

             
                cargarLista(tabla_A);
                habilitar(false);
            }
            else
            {
                // seguir editando
                
            }

            

        }

        virtual public void actualizaRegistro()
        {
            // update
            
        }

        virtual public void actualizarBD()
        {
            // update

        }

        virtual public void insertaNuevoRegistro()
        {
            // insert

        }

        virtual public void insertar()
        {
            // insert
           
        }

        ///////////////////    FIN GRABAR      //////////////////////////////////////////////


        //private bool existe(int PK)
        //{   // Verificamos si existe el valor PK en el campo

        //    bool esta = false;
        //    for (int i = 0; i < contadorIndiceArreglo; i++)
        //    {
        //        if (arregloModuladores[i].pIDmodulador == PK)
        //        {
        //            esta = true;
        //        }

        //    }
        //    return esta;
        //}



        virtual public void BtnBorrar_Click(object sender, EventArgs e)
        {
            

            // ------> BORRAR o DELETE;

        }

        

        private void BtnEditar_Click(object sender, EventArgs e)
        {   

            if (lstPrincipal.SelectedIndex != -1)
            {
                habilitar(true);
                txtCaja1.Enabled = false; 
                txtCaja2.Focus();
                cajaFecha.Value = DateTime.Now;

            }
            else
                MessageBox.Show("Por favor elija un producto . . ", "ELIJA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {   

            //if(tamanoDeArreglo > contadorIndiceArreglo)// verificamos que no sobrepase los registros del arreglo
            //{
                habilitar(true);
                limpiar();

                txtCaja2.Focus();
                banderaNuevoPedido = true;

                //txtCaja1.Text = (maximoValorINT(tabla_A,nombre_campo_id_A) + 1).ToString(); // asignamos una PK al nuevo producto
                txtCaja1.Enabled = false;

                cajaFecha.Value = DateTime.Now;
            //}
            //else
            //{
            //    MessageBox.Show("NO puede agregar mas registros . . ", "Maxima Capacidad", MessageBoxButtons.OK);
            //}
               
        }

        private void LstProducto_SelectedIndexChanged(object sender, EventArgs e)
        {  
            cargarCampos(lstPrincipal.SelectedIndex);
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarCampos(lst_A.SelectedIndex);
        }

        private void TxtDetalle_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Return )
                if(cboCombo_A.SelectedIndex == -1)
                {
                    cboCombo_A.Focus();
                    cboCombo_A.DroppedDown = true;
                }
                else
                {
                    txtCaja4.Focus();
                }

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //frmModuladores Formulario = new frmModuladores();
            //Formulario.Show();
        }

        private void RbtNoteBook_CheckedChanged(object sender, EventArgs e)
        {
            txtCaja4.Focus();
        }

        private void CboMarca_DropDownClosed(object sender, EventArgs e)
        {
            txtCaja4.Focus();
        }

        

        private void TxtPrecio_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Return && txtCaja4.Text !="")
            {
                cajaFecha.Focus();
                SendKeys.Send("{F4}");
            }
        }

        private void FrmBase_Load(object sender, EventArgs e)
        {
            habilitar(false);

            rotuladoLabels();

            //if (tabla_A != "")
            //    cargarCombo(cboCombo_A, tabla_A, nombre_campo_display_A, nombre_campo_id_A);
            //if (tabla_B != "")
            //    cargarCombo(cboCombo_B, tabla_B, nombre_campo_display_B, nombre_campo_id_B);

            //if (tabla_C != "")
            //    cargarCombo(cboCombo_C, tabla_C, nombre_campo_display_C, nombre_campo_id_C);

            //if (tabla_D != "")
            //    cargarCombo(cboCombo_D, tabla_D, nombre_campo_display_D, nombre_campo_id_D);

            miAccion = acciones.nuevo;
        }

        private void DtpFecha_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Return)
            {
                btnGrabar.Focus();
                //dtpFecha.DropDown(); 
            }
        }

        private void BtnLlenarGrilla_Click(object sender, EventArgs e)
        {
            //DataTable tabla = new DataTable();

            ////tabla = objetoBaseDatos.listarTablas("LIBRERIA"); // lista las tablas
            //tabla = oDatos.consultarTabla(lst_B.Text); // lista los campos
            //dataGrid_A.DataSource = tabla;


        }

        //private int maximoValorINT(string tabla, string campo)
        //{
            //oDatos.maximoValor(tabla, campo);
            //int maximoValor=0;



            //while (oDatos.pLectorDataReader.Read())
            //{
            //    maximoValor = oDatos.pLectorDataReader.GetInt32(0);
            //    btn.Text = maximoValor.ToString();
            //}

            //oDatos.pLectorDataReader.Close();
            //oDatos.desconectarBD();

            //return maximoValor;
        //}

        // private void cargarCombo(ComboBox combo, string nombreTabla, string campoDisplay, string campoID)
        //{

           

        //}
        private void cargarCombo1(ComboBox combo, string nombreTabla)
        {
            //DataTable tabla = new DataTable();
            //tabla = oDatos.consultarTabla(nombreTabla);
            //combo.DataSource = tabla;
            //combo.DisplayMember = tabla.Columns[1].ColumnName;
            //combo.ValueMember = tabla.Columns[0].ColumnName;
        }

        // VERIFICACIONES
        public bool verificaCombo(ComboBox combo, string mensaje)
        {
            bool seleccionado = true;
            if (combo.SelectedIndex == -1)
            {
                MessageBox.Show(mensaje,"No selecciono...",MessageBoxButtons.OK);
                combo.Focus();
                seleccionado = false;
            }
            return seleccionado;
        }
        
        public bool verificarSiDOUBLE(TextBox caja, string mensaje)
        {
            bool esNumero = true;
            double valor = 0.25;
            if (!double.TryParse(caja.Text, out valor)) //Verificamos si el valor es un DOUBLE
            {
                MessageBox.Show(mensaje, "No es numero valido...", MessageBoxButtons.OK);
                caja.Focus();
                esNumero= false;
            }
            return esNumero;
        }

        public bool verificarSiINT(TextBox caja, string mensaje)
        {
            bool esNumero = true;
            int valor = 1;
            if (!Int32.TryParse(caja.Text, out valor)) //Verificamos si el precio es un INT
            {
                MessageBox.Show(mensaje, "No es numero valido...", MessageBoxButtons.OK);
                caja.Focus();
                esNumero = false;
            }
            return esNumero;
        }

        public bool verificarTEXTBOXvacio(TextBox caja, string mensaje)
        {
            bool contenido = true;
            if (caja.Text == string.Empty)
            {
                MessageBox.Show(mensaje, "Campo vacio ...", MessageBoxButtons.OK);
                caja.Focus();
                contenido = false;
            }
            return contenido;
        }
    }
}
