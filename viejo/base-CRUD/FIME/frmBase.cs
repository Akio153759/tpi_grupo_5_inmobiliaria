using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Inmobiliaria
{
    public partial class frmBase : Form
    {
        


        string nombreBD = "GYG";

        // tablas a cargar en los combos
        protected string tabla_A, nombre_campo_id_A, nombre_campo_display_A ;
        protected string tabla_B, nombre_campo_id_B, nombre_campo_display_B;
        protected string tabla_C, nombre_campo_id_C, nombre_campo_display_C;
        protected string tabla_D, nombre_campo_id_D, nombre_campo_display_D;
        protected string tabla_E, nombre_campo_id_E, nombre_campo_display_E;



        protected int ultimoRegistro; // la ultima PK de la tabla producto
        protected int contadorIndiceArreglo;// contador del arreglo

        protected bool banderaAgregar; // bandera para controlar entre registro nuevo y modificado

        enum acciones //Enumeraciones
        {
            nuevo,
            editado,
            otro1,
            otro2
        }
         acciones miAccion;

        public frmBase()
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

            tabla_E = "";
            nombre_campo_id_E = "";
            nombre_campo_display_E = "";




            banderaAgregar = false; // bandera pa controlar si el registro se edita o se hace 1 nuevo


            

            
            //listadoTablasBD = oDatos.listarTablas(nombreBD); // lista todas las tablas 
            //lst_B.DataSource = listadoTablasBD;
            //lst_B.DisplayMember = "name";


        }
        private void FrmBase_Load(object sender, EventArgs e)
        {
            habilitar(false);
            rotuladoLabels();
            miAccion = acciones.nuevo;
            eventoLoadForm();
        }

        virtual public void eventoLoadForm()
        {

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


        }


        virtual public void limpiar()
        {   

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
            banderaAgregar = false;
        }

 ///////////////////   GRABAR      //////////////////////////////////////////////
        private void BtnGrabar_Click(object sender, EventArgs e)
        {   
           
            // 1ero validamos los datos
            if (validarDatos())
            {
               
                if (banderaAgregar)
                {
                    // insert
                    Agregar();
                }
                else
                {
                    // update
                    Actualizar();
                }

             
                cargarLista(tabla_A);
                habilitar(false);
            }
            else
            {
                // seguir editando
                
            }

            

        }

        private bool validarDatos()
        {

            return false;
        }

        virtual public void actualizaRegistro()
        {
            // update
            
        }

        virtual public void Actualizar()
        {
            // update

        }

        virtual public void Agregar()
        {
            // insert
           
        }

       virtual public void Eliminar()
        {

        }



        virtual public void LlenarGrilla()
        {
            
        }




        ///
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
