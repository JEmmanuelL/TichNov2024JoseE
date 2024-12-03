using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HolaMundoWindowsForm
{
    public partial class FormEstados : Form
    {
        public FormEstados()
        {
            InitializeComponent();
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormEstados_Load(object sender, EventArgs e)
        {
            CRUDEstados objCrudEstado = new CRUDEstados();
            List<Estado> estado = objCrudEstado.Consultar();
            cbxEstados.DataSource = estado;
            cbxEstados.ValueMember = "id";
            cbxEstados.DisplayMember = "nombre";

            dgvEstados.DataSource = estado;
            pnlEstados.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //int id = Convert.ToInt16(cbxEstados.SelectedValue);
            //Estado estado = (Estado) cbxEstados.SelectedItem;

            // MessageBox.Show($"id: {estado.id} nombre: {estado.nombre}");

            //MessageBox.Show(id.ToString());

            Estado objEstado =(Estado)cbxEstados.SelectedItem;

            txtID.Text = objEstado.id.ToString();
            txtNombre.Text = objEstado.nombre;

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            pnlEstados.Visible =chxDetalles.Checked;
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
