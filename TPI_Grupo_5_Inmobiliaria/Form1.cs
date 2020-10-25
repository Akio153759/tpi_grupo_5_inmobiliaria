using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace TPI_Grupo_5_Inmobiliaria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //MessageBox.Show("hola");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Datos nDatos = new Datos();
            dataGridView1.DataSource = nDatos.consulta1();
           
        }

        private void TxtConsulta_2_Click(object sender, EventArgs e)
        {
            Datos nDatos = new Datos();
            dataGridView1.DataSource = nDatos.consulta2();
        }
    }
}
