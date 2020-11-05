namespace FIME
{
    partial class frmCRUD
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCaja1 = new System.Windows.Forms.Label();
            this.lblCaja2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCaja1 = new System.Windows.Forms.TextBox();
            this.txtCaja2 = new System.Windows.Forms.TextBox();
            this.cboCombo_A = new System.Windows.Forms.ComboBox();
            this.rbtRadio1 = new System.Windows.Forms.RadioButton();
            this.rbtRadio2 = new System.Windows.Forms.RadioButton();
            this.cajaFecha = new System.Windows.Forms.DateTimePicker();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lstPrincipal = new System.Windows.Forms.ListBox();
            this.lblCaja4 = new System.Windows.Forms.Label();
            this.txtCaja4 = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnBorrarModificado = new System.Windows.Forms.Button();
            this.lst_A = new System.Windows.Forms.ListBox();
            this.dataGrid_A = new System.Windows.Forms.DataGridView();
            this.btnLlenarGrilla = new System.Windows.Forms.Button();
            this.btn = new System.Windows.Forms.Button();
            this.cboCombo_B = new System.Windows.Forms.ComboBox();
            this.txtCaja3 = new System.Windows.Forms.TextBox();
            this.lblCaja3 = new System.Windows.Forms.Label();
            this.lst_B = new System.Windows.Forms.ListBox();
            this.txtCaja5 = new System.Windows.Forms.TextBox();
            this.lblCaja5 = new System.Windows.Forms.Label();
            this.cboCombo_C = new System.Windows.Forms.ComboBox();
            this.lblfecha = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblCaja6 = new System.Windows.Forms.Label();
            this.cboCombo_D = new System.Windows.Forms.ComboBox();
            this.txtCaja6 = new System.Windows.Forms.TextBox();
            this.lblCombo_A = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_A)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCaja1
            // 
            this.lblCaja1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaja1.Location = new System.Drawing.Point(14, 16);
            this.lblCaja1.MinimumSize = new System.Drawing.Size(140, 20);
            this.lblCaja1.Name = "lblCaja1";
            this.lblCaja1.Size = new System.Drawing.Size(150, 20);
            this.lblCaja1.TabIndex = 0;
            this.lblCaja1.Text = "lblCaja1";
            this.lblCaja1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCaja2
            // 
            this.lblCaja2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaja2.Location = new System.Drawing.Point(14, 44);
            this.lblCaja2.MinimumSize = new System.Drawing.Size(140, 20);
            this.lblCaja2.Name = "lblCaja2";
            this.lblCaja2.Size = new System.Drawing.Size(150, 20);
            this.lblCaja2.TabIndex = 1;
            this.lblCaja2.Text = "lblCaja2";
            this.lblCaja2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tipo";
            // 
            // txtCaja1
            // 
            this.txtCaja1.Location = new System.Drawing.Point(162, 16);
            this.txtCaja1.Name = "txtCaja1";
            this.txtCaja1.Size = new System.Drawing.Size(100, 20);
            this.txtCaja1.TabIndex = 0;
            // 
            // txtCaja2
            // 
            this.txtCaja2.Location = new System.Drawing.Point(162, 44);
            this.txtCaja2.Name = "txtCaja2";
            this.txtCaja2.Size = new System.Drawing.Size(200, 20);
            this.txtCaja2.TabIndex = 1;
            this.txtCaja2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtDetalle_KeyUp);
            // 
            // cboCombo_A
            // 
            this.cboCombo_A.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCombo_A.FormattingEnabled = true;
            this.cboCombo_A.Location = new System.Drawing.Point(84, 181);
            this.cboCombo_A.Name = "cboCombo_A";
            this.cboCombo_A.Size = new System.Drawing.Size(100, 21);
            this.cboCombo_A.TabIndex = 2;
            this.cboCombo_A.DropDownClosed += new System.EventHandler(this.CboMarca_DropDownClosed);
            // 
            // rbtRadio1
            // 
            this.rbtRadio1.AutoSize = true;
            this.rbtRadio1.Location = new System.Drawing.Point(84, 218);
            this.rbtRadio1.Name = "rbtRadio1";
            this.rbtRadio1.Size = new System.Drawing.Size(87, 17);
            this.rbtRadio1.TabIndex = 3;
            this.rbtRadio1.TabStop = true;
            this.rbtRadio1.Text = "1 - Notebook";
            this.rbtRadio1.UseVisualStyleBackColor = true;
            this.rbtRadio1.CheckedChanged += new System.EventHandler(this.RbtNoteBook_CheckedChanged);
            // 
            // rbtRadio2
            // 
            this.rbtRadio2.AutoSize = true;
            this.rbtRadio2.Location = new System.Drawing.Point(84, 251);
            this.rbtRadio2.Name = "rbtRadio2";
            this.rbtRadio2.Size = new System.Drawing.Size(81, 17);
            this.rbtRadio2.TabIndex = 4;
            this.rbtRadio2.TabStop = true;
            this.rbtRadio2.Text = "2 - Netbook";
            this.rbtRadio2.UseVisualStyleBackColor = true;
            // 
            // cajaFecha
            // 
            this.cajaFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cajaFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.cajaFecha.Location = new System.Drawing.Point(175, 278);
            this.cajaFecha.Name = "cajaFecha";
            this.cajaFecha.Size = new System.Drawing.Size(90, 22);
            this.cajaFecha.TabIndex = 6;
            this.cajaFecha.KeyUp += new System.Windows.Forms.KeyEventHandler(this.DtpFecha_KeyUp);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(12, 310);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(61, 23);
            this.btnNuevo.TabIndex = 8;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(237, 310);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(61, 23);
            this.btnGrabar.TabIndex = 11;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.BtnGrabar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(304, 310);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(61, 23);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(379, 310);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(61, 23);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // lstPrincipal
            // 
            this.lstPrincipal.FormattingEnabled = true;
            this.lstPrincipal.Location = new System.Drawing.Point(406, 21);
            this.lstPrincipal.Name = "lstPrincipal";
            this.lstPrincipal.Size = new System.Drawing.Size(120, 225);
            this.lstPrincipal.TabIndex = 7;
            this.lstPrincipal.SelectedIndexChanged += new System.EventHandler(this.LstProducto_SelectedIndexChanged);
            // 
            // lblCaja4
            // 
            this.lblCaja4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaja4.Location = new System.Drawing.Point(14, 100);
            this.lblCaja4.MinimumSize = new System.Drawing.Size(140, 20);
            this.lblCaja4.Name = "lblCaja4";
            this.lblCaja4.Size = new System.Drawing.Size(150, 20);
            this.lblCaja4.TabIndex = 16;
            this.lblCaja4.Text = "lblCaja4";
            this.lblCaja4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCaja4
            // 
            this.txtCaja4.Location = new System.Drawing.Point(165, 100);
            this.txtCaja4.Name = "txtCaja4";
            this.txtCaja4.Size = new System.Drawing.Size(100, 20);
            this.txtCaja4.TabIndex = 5;
            this.txtCaja4.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtPrecio_KeyUp);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(87, 310);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(61, 23);
            this.btnEditar.TabIndex = 9;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // btnBorrarModificado
            // 
            this.btnBorrarModificado.Location = new System.Drawing.Point(162, 310);
            this.btnBorrarModificado.Name = "btnBorrarModificado";
            this.btnBorrarModificado.Size = new System.Drawing.Size(61, 23);
            this.btnBorrarModificado.TabIndex = 10;
            this.btnBorrarModificado.Text = "Borrar";
            this.btnBorrarModificado.UseVisualStyleBackColor = true;
            this.btnBorrarModificado.Click += new System.EventHandler(this.BtnBorrar_Click);
            // 
            // lst_A
            // 
            this.lst_A.FormattingEnabled = true;
            this.lst_A.Location = new System.Drawing.Point(532, 21);
            this.lst_A.Name = "lst_A";
            this.lst_A.Size = new System.Drawing.Size(120, 225);
            this.lst_A.TabIndex = 17;
            this.lst_A.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            // 
            // dataGrid_A
            // 
            this.dataGrid_A.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_A.Location = new System.Drawing.Point(678, 18);
            this.dataGrid_A.Name = "dataGrid_A";
            this.dataGrid_A.Size = new System.Drawing.Size(444, 217);
            this.dataGrid_A.TabIndex = 19;
            // 
            // btnLlenarGrilla
            // 
            this.btnLlenarGrilla.Location = new System.Drawing.Point(678, 241);
            this.btnLlenarGrilla.Name = "btnLlenarGrilla";
            this.btnLlenarGrilla.Size = new System.Drawing.Size(75, 23);
            this.btnLlenarGrilla.TabIndex = 20;
            this.btnLlenarGrilla.Text = "carga grilla";
            this.btnLlenarGrilla.UseVisualStyleBackColor = true;
            this.btnLlenarGrilla.Click += new System.EventHandler(this.BtnLlenarGrilla_Click);
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(582, 311);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(77, 22);
            this.btn.TabIndex = 21;
            this.btn.Text = "Maximo valor";
            this.btn.UseVisualStyleBackColor = true;
            // 
            // cboCombo_B
            // 
            this.cboCombo_B.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCombo_B.FormattingEnabled = true;
            this.cboCombo_B.Location = new System.Drawing.Point(190, 182);
            this.cboCombo_B.Name = "cboCombo_B";
            this.cboCombo_B.Size = new System.Drawing.Size(94, 21);
            this.cboCombo_B.TabIndex = 22;
            // 
            // txtCaja3
            // 
            this.txtCaja3.Location = new System.Drawing.Point(162, 72);
            this.txtCaja3.Name = "txtCaja3";
            this.txtCaja3.Size = new System.Drawing.Size(200, 20);
            this.txtCaja3.TabIndex = 23;
            // 
            // lblCaja3
            // 
            this.lblCaja3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaja3.Location = new System.Drawing.Point(14, 72);
            this.lblCaja3.MinimumSize = new System.Drawing.Size(140, 20);
            this.lblCaja3.Name = "lblCaja3";
            this.lblCaja3.Size = new System.Drawing.Size(150, 20);
            this.lblCaja3.TabIndex = 1;
            this.lblCaja3.Text = "lblCaja3";
            this.lblCaja3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lst_B
            // 
            this.lst_B.FormattingEnabled = true;
            this.lst_B.Location = new System.Drawing.Point(799, 241);
            this.lst_B.Name = "lst_B";
            this.lst_B.Size = new System.Drawing.Size(147, 134);
            this.lst_B.TabIndex = 24;
            // 
            // txtCaja5
            // 
            this.txtCaja5.Location = new System.Drawing.Point(165, 128);
            this.txtCaja5.Name = "txtCaja5";
            this.txtCaja5.Size = new System.Drawing.Size(200, 20);
            this.txtCaja5.TabIndex = 25;
            // 
            // lblCaja5
            // 
            this.lblCaja5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaja5.Location = new System.Drawing.Point(14, 128);
            this.lblCaja5.MinimumSize = new System.Drawing.Size(140, 20);
            this.lblCaja5.Name = "lblCaja5";
            this.lblCaja5.Size = new System.Drawing.Size(150, 20);
            this.lblCaja5.TabIndex = 26;
            this.lblCaja5.Text = "lblCaja5";
            this.lblCaja5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboCombo_C
            // 
            this.cboCombo_C.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCombo_C.FormattingEnabled = true;
            this.cboCombo_C.Location = new System.Drawing.Point(290, 182);
            this.cboCombo_C.Name = "cboCombo_C";
            this.cboCombo_C.Size = new System.Drawing.Size(94, 21);
            this.cboCombo_C.TabIndex = 27;
            // 
            // lblfecha
            // 
            this.lblfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfecha.Location = new System.Drawing.Point(-2, 280);
            this.lblfecha.MinimumSize = new System.Drawing.Size(140, 20);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(150, 20);
            this.lblfecha.TabIndex = 28;
            this.lblfecha.Text = "Código";
            this.lblfecha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(568, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 23);
            this.button1.TabIndex = 29;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // lblCaja6
            // 
            this.lblCaja6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaja6.Location = new System.Drawing.Point(14, 156);
            this.lblCaja6.MinimumSize = new System.Drawing.Size(140, 20);
            this.lblCaja6.Name = "lblCaja6";
            this.lblCaja6.Size = new System.Drawing.Size(150, 20);
            this.lblCaja6.TabIndex = 30;
            this.lblCaja6.Text = "lblCaja6";
            this.lblCaja6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboCombo_D
            // 
            this.cboCombo_D.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCombo_D.FormattingEnabled = true;
            this.cboCombo_D.Location = new System.Drawing.Point(290, 230);
            this.cboCombo_D.Name = "cboCombo_D";
            this.cboCombo_D.Size = new System.Drawing.Size(94, 21);
            this.cboCombo_D.TabIndex = 31;
            // 
            // txtCaja6
            // 
            this.txtCaja6.Location = new System.Drawing.Point(165, 156);
            this.txtCaja6.Name = "txtCaja6";
            this.txtCaja6.Size = new System.Drawing.Size(200, 20);
            this.txtCaja6.TabIndex = 32;
            // 
            // lblCombo_A
            // 
            this.lblCombo_A.AutoSize = true;
            this.lblCombo_A.Location = new System.Drawing.Point(15, 185);
            this.lblCombo_A.Name = "lblCombo_A";
            this.lblCombo_A.Size = new System.Drawing.Size(63, 13);
            this.lblCombo_A.TabIndex = 33;
            this.lblCombo_A.Text = "lblCombo_A";
            // 
            // frmCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 437);
            this.Controls.Add(this.lblCombo_A);
            this.Controls.Add(this.txtCaja6);
            this.Controls.Add(this.cboCombo_D);
            this.Controls.Add(this.lblCaja6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblfecha);
            this.Controls.Add(this.cboCombo_C);
            this.Controls.Add(this.lblCaja5);
            this.Controls.Add(this.txtCaja5);
            this.Controls.Add(this.lst_B);
            this.Controls.Add(this.txtCaja3);
            this.Controls.Add(this.cboCombo_B);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.btnLlenarGrilla);
            this.Controls.Add(this.lst_A);
            this.Controls.Add(this.btnBorrarModificado);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.txtCaja4);
            this.Controls.Add(this.lblCaja4);
            this.Controls.Add(this.lstPrincipal);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.cajaFecha);
            this.Controls.Add(this.rbtRadio2);
            this.Controls.Add(this.rbtRadio1);
            this.Controls.Add(this.cboCombo_A);
            this.Controls.Add(this.txtCaja2);
            this.Controls.Add(this.txtCaja1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblCaja3);
            this.Controls.Add(this.lblCaja2);
            this.Controls.Add(this.lblCaja1);
            this.Controls.Add(this.dataGrid_A);
            this.Name = "frmCRUD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CRUD";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmProducto_FormClosing);
            this.Load += new System.EventHandler(this.FrmBase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_A)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnBorrarModificado;
        private System.Windows.Forms.Button btnLlenarGrilla;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.ListBox lst_B;
        protected System.Windows.Forms.Label lblCaja1;
        protected System.Windows.Forms.Label lblCaja2;
        protected System.Windows.Forms.TextBox txtCaja1;
        protected System.Windows.Forms.TextBox txtCaja2;
        protected System.Windows.Forms.Label lblCaja4;
        protected System.Windows.Forms.TextBox txtCaja4;
        protected System.Windows.Forms.TextBox txtCaja3;
        protected System.Windows.Forms.Label lblCaja3;
        protected System.Windows.Forms.TextBox txtCaja5;
        protected System.Windows.Forms.Label lblCaja5;
        protected System.Windows.Forms.ComboBox cboCombo_A;
        protected System.Windows.Forms.DateTimePicker cajaFecha;
        protected System.Windows.Forms.ListBox lstPrincipal;
        protected System.Windows.Forms.ListBox lst_A;
        protected System.Windows.Forms.ComboBox cboCombo_B;
        protected System.Windows.Forms.ComboBox cboCombo_C;
        protected System.Windows.Forms.Label lblfecha;
        protected System.Windows.Forms.Label label4;
        protected System.Windows.Forms.RadioButton rbtRadio1;
        protected System.Windows.Forms.RadioButton rbtRadio2;
        private System.Windows.Forms.Button button1;
        protected System.Windows.Forms.Label lblCaja6;
        public System.Windows.Forms.DataGridView dataGrid_A;
        protected System.Windows.Forms.ComboBox cboCombo_D;
        protected System.Windows.Forms.TextBox txtCaja6;
        protected System.Windows.Forms.Label lblCombo_A;
    }
}

