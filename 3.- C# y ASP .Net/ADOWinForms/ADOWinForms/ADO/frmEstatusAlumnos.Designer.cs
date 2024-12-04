namespace ADOWinForms.ADO
{
    partial class frmEstatusAlumnos
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
            this.cbxEstatus = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dvgEstatus = new System.Windows.Forms.DataGridView();
            this.txbxNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnCompletarAcc = new System.Windows.Forms.Button();
            this.lblClave = new System.Windows.Forms.Label();
            this.btnCancelarAcc = new System.Windows.Forms.Button();
            this.txbxClave = new System.Windows.Forms.TextBox();
            this.pnlEstatus = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dvgEstatus)).BeginInit();
            this.pnlEstatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxEstatus
            // 
            this.cbxEstatus.FormattingEnabled = true;
            this.cbxEstatus.Location = new System.Drawing.Point(181, 51);
            this.cbxEstatus.Name = "cbxEstatus";
            this.cbxEstatus.Size = new System.Drawing.Size(121, 21);
            this.cbxEstatus.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(332, 51);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(434, 51);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 2;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(532, 51);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dvgEstatus
            // 
            this.dvgEstatus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgEstatus.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dvgEstatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgEstatus.Location = new System.Drawing.Point(34, 90);
            this.dvgEstatus.Name = "dvgEstatus";
            this.dvgEstatus.Size = new System.Drawing.Size(754, 248);
            this.dvgEstatus.TabIndex = 4;
            // 
            // txbxNombre
            // 
            this.txbxNombre.Location = new System.Drawing.Point(358, 45);
            this.txbxNombre.Name = "txbxNombre";
            this.txbxNombre.Size = new System.Drawing.Size(100, 20);
            this.txbxNombre.TabIndex = 8;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(303, 45);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 6;
            this.lblNombre.Text = "Nombre";
            // 
            // btnCompletarAcc
            // 
            this.btnCompletarAcc.Location = new System.Drawing.Point(294, 76);
            this.btnCompletarAcc.Name = "btnCompletarAcc";
            this.btnCompletarAcc.Size = new System.Drawing.Size(75, 23);
            this.btnCompletarAcc.TabIndex = 9;
            this.btnCompletarAcc.UseVisualStyleBackColor = true;
            this.btnCompletarAcc.Click += new System.EventHandler(this.btnCompletarAcc_Click);
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Location = new System.Drawing.Point(303, 12);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(34, 13);
            this.lblClave.TabIndex = 5;
            this.lblClave.Text = "Clave";
            // 
            // btnCancelarAcc
            // 
            this.btnCancelarAcc.Location = new System.Drawing.Point(425, 76);
            this.btnCancelarAcc.Name = "btnCancelarAcc";
            this.btnCancelarAcc.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarAcc.TabIndex = 10;
            this.btnCancelarAcc.Text = "Cancelar";
            this.btnCancelarAcc.UseVisualStyleBackColor = true;
            this.btnCancelarAcc.Click += new System.EventHandler(this.btnCancelarAcc_Click);
            // 
            // txbxClave
            // 
            this.txbxClave.Location = new System.Drawing.Point(358, 12);
            this.txbxClave.Name = "txbxClave";
            this.txbxClave.Size = new System.Drawing.Size(100, 20);
            this.txbxClave.TabIndex = 7;
            // 
            // pnlEstatus
            // 
            this.pnlEstatus.Controls.Add(this.txbxClave);
            this.pnlEstatus.Controls.Add(this.btnCancelarAcc);
            this.pnlEstatus.Controls.Add(this.lblClave);
            this.pnlEstatus.Controls.Add(this.btnCompletarAcc);
            this.pnlEstatus.Controls.Add(this.lblNombre);
            this.pnlEstatus.Controls.Add(this.txbxNombre);
            this.pnlEstatus.Location = new System.Drawing.Point(34, 344);
            this.pnlEstatus.Name = "pnlEstatus";
            this.pnlEstatus.Size = new System.Drawing.Size(754, 100);
            this.pnlEstatus.TabIndex = 11;
            // 
            // frmEstatusAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlEstatus);
            this.Controls.Add(this.dvgEstatus);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cbxEstatus);
            this.Name = "frmEstatusAlumnos";
            this.Text = "frmEstatusAlumnos";
            this.Load += new System.EventHandler(this.frmEstatusAlumnos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgEstatus)).EndInit();
            this.pnlEstatus.ResumeLayout(false);
            this.pnlEstatus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxEstatus;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dvgEstatus;
        private System.Windows.Forms.TextBox txbxNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnCompletarAcc;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.Button btnCancelarAcc;
        private System.Windows.Forms.TextBox txbxClave;
        private System.Windows.Forms.Panel pnlEstatus;
    }
}