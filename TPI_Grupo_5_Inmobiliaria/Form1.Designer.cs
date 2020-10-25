namespace TPI_Grupo_5_Inmobiliaria
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtConsulta_1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtConsulta_2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(62, 28);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(174, 160);
            this.listBox1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(242, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(650, 253);
            this.dataGridView1.TabIndex = 1;
            // 
            // txtConsulta_1
            // 
            this.txtConsulta_1.Location = new System.Drawing.Point(761, 287);
            this.txtConsulta_1.Name = "txtConsulta_1";
            this.txtConsulta_1.Size = new System.Drawing.Size(131, 29);
            this.txtConsulta_1.TabIndex = 2;
            this.txtConsulta_1.Text = "Consulta 1";
            this.txtConsulta_1.UseVisualStyleBackColor = true;
            this.txtConsulta_1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(47, 512);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(923, 20);
            this.textBox1.TabIndex = 3;
            // 
            // txtConsulta_2
            // 
            this.txtConsulta_2.Location = new System.Drawing.Point(761, 322);
            this.txtConsulta_2.Name = "txtConsulta_2";
            this.txtConsulta_2.Size = new System.Drawing.Size(131, 27);
            this.txtConsulta_2.TabIndex = 4;
            this.txtConsulta_2.Text = "Consulta 2";
            this.txtConsulta_2.UseVisualStyleBackColor = true;
            this.txtConsulta_2.Click += new System.EventHandler(this.TxtConsulta_2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 592);
            this.Controls.Add(this.txtConsulta_2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtConsulta_1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button txtConsulta_1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button txtConsulta_2;
    }
}

