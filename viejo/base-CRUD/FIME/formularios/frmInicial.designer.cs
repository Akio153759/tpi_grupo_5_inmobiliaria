namespace FIME
{
    partial class frmInicial
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnUltimoPrecio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCaja1
            // 
            this.txtCaja1.Size = new System.Drawing.Size(86, 20);
            this.txtCaja1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCaja4
            // 
            this.txtCaja4.Size = new System.Drawing.Size(86, 20);
            this.txtCaja4.TabIndex = 3;
            this.txtCaja4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCaja3
            // 
            this.txtCaja3.TabIndex = 2;
            // 
            // txtCaja5
            // 
            this.txtCaja5.Size = new System.Drawing.Size(86, 20);
            this.txtCaja5.TabIndex = 4;
            this.txtCaja5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cboCombo_A
            // 
            this.cboCombo_A.Location = new System.Drawing.Point(84, 154);
            this.cboCombo_A.Visible = false;
            // 
            // lstIniciales
            // 
            this.lstPrincipal.Location = new System.Drawing.Point(401, 16);
            this.lstPrincipal.TabIndex = 14;
            // 
            // listBox1
            // 
            this.lst_A.Location = new System.Drawing.Point(860, 21);
            // 
            // cboCombo_B
            // 
            this.cboCombo_B.TabIndex = 5;
            // 
            // cboCombo_C
            // 
            this.cboCombo_C.Location = new System.Drawing.Point(290, 181);
            this.cboCombo_C.Visible = false;
            // 
            // label4
            // 
            this.label4.Visible = false;
            // 
            // rbtRadio1
            // 
            this.rbtRadio1.Visible = false;
            // 
            // rbtRadio2
            // 
            this.rbtRadio2.Visible = false;
            // 
            // cboCombo_D
            // 
            this.cboCombo_D.Visible = false;
            // 
            // btnUltimoPrecio
            // 
            this.btnUltimoPrecio.Location = new System.Drawing.Point(84, 182);
            this.btnUltimoPrecio.Name = "btnUltimoPrecio";
            this.btnUltimoPrecio.Size = new System.Drawing.Size(100, 21);
            this.btnUltimoPrecio.TabIndex = 31;
            this.btnUltimoPrecio.Text = "Ultimo Precio";
            this.btnUltimoPrecio.UseVisualStyleBackColor = true;
            this.btnUltimoPrecio.Click += new System.EventHandler(this.BtnUltimoPrecio_Click);
            // 
            // frmInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 350);
            this.Controls.Add(this.btnUltimoPrecio);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInicial";
            this.Text = "Inicial";
            this.Load += new System.EventHandler(this.Prueba_Load);
            this.Controls.SetChildIndex(this.cboCombo_D, 0);
            this.Controls.SetChildIndex(this.lblCaja1, 0);
            this.Controls.SetChildIndex(this.lblCaja2, 0);
            this.Controls.SetChildIndex(this.lblCaja3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtCaja1, 0);
            this.Controls.SetChildIndex(this.txtCaja2, 0);
            this.Controls.SetChildIndex(this.cboCombo_A, 0);
            this.Controls.SetChildIndex(this.rbtRadio1, 0);
            this.Controls.SetChildIndex(this.rbtRadio2, 0);
            this.Controls.SetChildIndex(this.cajaFecha, 0);
            this.Controls.SetChildIndex(this.lstPrincipal, 0);
            this.Controls.SetChildIndex(this.lblCaja4, 0);
            this.Controls.SetChildIndex(this.txtCaja4, 0);
            this.Controls.SetChildIndex(this.lst_A, 0);
            this.Controls.SetChildIndex(this.cboCombo_B, 0);
            this.Controls.SetChildIndex(this.txtCaja3, 0);
            this.Controls.SetChildIndex(this.txtCaja5, 0);
            this.Controls.SetChildIndex(this.lblCaja5, 0);
            this.Controls.SetChildIndex(this.cboCombo_C, 0);
            this.Controls.SetChildIndex(this.lblfecha, 0);
            this.Controls.SetChildIndex(this.lblCaja6, 0);
            this.Controls.SetChildIndex(this.btnUltimoPrecio, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUltimoPrecio;
    }
}