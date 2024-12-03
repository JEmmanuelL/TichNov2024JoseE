namespace HolaMundoWindowsForm
{
    partial class FormEstados
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
            this.lblEstados = new System.Windows.Forms.Label();
            this.cbxEstados = new System.Windows.Forms.ComboBox();
            this.dgvEstados = new System.Windows.Forms.DataGridView();
            this.btnEstados = new System.Windows.Forms.Button();
            this.pnlEstados = new System.Windows.Forms.Panel();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.chxDetalles = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstados)).BeginInit();
            this.pnlEstados.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEstados
            // 
            this.lblEstados.AutoSize = true;
            this.lblEstados.Location = new System.Drawing.Point(92, 32);
            this.lblEstados.Name = "lblEstados";
            this.lblEstados.Size = new System.Drawing.Size(45, 13);
            this.lblEstados.TabIndex = 0;
            this.lblEstados.Text = "Estados";
            // 
            // cbxEstados
            // 
            this.cbxEstados.FormattingEnabled = true;
            this.cbxEstados.Location = new System.Drawing.Point(143, 29);
            this.cbxEstados.Name = "cbxEstados";
            this.cbxEstados.Size = new System.Drawing.Size(121, 21);
            this.cbxEstados.TabIndex = 1;
            // 
            // dgvEstados
            // 
            this.dgvEstados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEstados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstados.Location = new System.Drawing.Point(95, 65);
            this.dgvEstados.Name = "dgvEstados";
            this.dgvEstados.Size = new System.Drawing.Size(666, 187);
            this.dgvEstados.TabIndex = 2;
            // 
            // btnEstados
            // 
            this.btnEstados.Location = new System.Drawing.Point(361, 258);
            this.btnEstados.Name = "btnEstados";
            this.btnEstados.Size = new System.Drawing.Size(75, 23);
            this.btnEstados.TabIndex = 4;
            this.btnEstados.Text = "Consultar";
            this.btnEstados.UseVisualStyleBackColor = true;
            this.btnEstados.Click += new System.EventHandler(this.button2_Click);
            // 
            // pnlEstados
            // 
            this.pnlEstados.Controls.Add(this.lblNombre);
            this.pnlEstados.Controls.Add(this.txtNombre);
            this.pnlEstados.Controls.Add(this.lblID);
            this.pnlEstados.Controls.Add(this.txtID);
            this.pnlEstados.Location = new System.Drawing.Point(95, 282);
            this.pnlEstados.Name = "pnlEstados";
            this.pnlEstados.Size = new System.Drawing.Size(666, 156);
            this.pnlEstados.TabIndex = 5;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(19, 49);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(69, 46);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(45, 23);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(69, 20);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 0;
            // 
            // chxDetalles
            // 
            this.chxDetalles.AutoSize = true;
            this.chxDetalles.Location = new System.Drawing.Point(681, 28);
            this.chxDetalles.Name = "chxDetalles";
            this.chxDetalles.Size = new System.Drawing.Size(64, 17);
            this.chxDetalles.TabIndex = 6;
            this.chxDetalles.Text = "Detalles";
            this.chxDetalles.UseVisualStyleBackColor = true;
            this.chxDetalles.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // FormEstados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chxDetalles);
            this.Controls.Add(this.pnlEstados);
            this.Controls.Add(this.btnEstados);
            this.Controls.Add(this.dgvEstados);
            this.Controls.Add(this.cbxEstados);
            this.Controls.Add(this.lblEstados);
            this.Name = "FormEstados";
            this.Text = "FormEstados";
            this.Load += new System.EventHandler(this.FormEstados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstados)).EndInit();
            this.pnlEstados.ResumeLayout(false);
            this.pnlEstados.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEstados;
        private System.Windows.Forms.ComboBox cbxEstados;
        private System.Windows.Forms.DataGridView dgvEstados;
        private System.Windows.Forms.Button btnEstados;
        private System.Windows.Forms.Panel pnlEstados;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.CheckBox chxDetalles;
    }
}