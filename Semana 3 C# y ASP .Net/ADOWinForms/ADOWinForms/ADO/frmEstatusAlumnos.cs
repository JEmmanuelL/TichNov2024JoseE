using ADOWinForms.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADOWinForms.ADO
{
    public partial class frmEstatusAlumnos : Form
    {
        public frmEstatusAlumnos()
        {
            InitializeComponent();
        }

        private void frmEstatusAlumnos_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        public void CargarDatos()
        {
            ADOEstatusAlumno onjCRUD = new ADOEstatusAlumno();
            cbxEstatus.DataSource = onjCRUD.Consultar();
            cbxEstatus.ValueMember = "id";
            cbxEstatus.DisplayMember = "nombre";
            //ADOEstatusAlumno onjCRUD = new ADOEstatusAlumno();
            List<EstatusAlumno> dataEstatus = onjCRUD.Consultar();
            dvgEstatus.DataSource = dataEstatus;
            pnlEstatus.Visible = false;
            btnAgregar.Enabled = true;
            btnActualizar.Enabled = true;
            btnEliminar.Enabled = true;
        }

        public void TxbxInput()
        {
            EstatusAlumno objEstado = (EstatusAlumno)cbxEstatus.SelectedItem;

            txbxClave.Text = objEstado.clave;
            txbxNombre.Text = objEstado.nombre;
            btnAgregar.Enabled = false;
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            pnlEstatus.Visible = true;
            btnCompletarAcc.Text = "Guardar";
            btnAgregar.Enabled = false;
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;

            txbxClave.Text = null;
            txbxNombre.Text = null;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            pnlEstatus.Visible = true;
            btnCompletarAcc.Text = "Actualizar";
            TxbxInput();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            pnlEstatus.Visible = true;
            btnCompletarAcc.Text = "Eliminar";
            TxbxInput();
            txbxClave.Enabled = false;
            txbxNombre.Enabled = false;

        }

        private void btnCompletarAcc_Click(object sender, EventArgs e)
        {
            try
            {
                EstatusAlumno objEstado = (EstatusAlumno)cbxEstatus.SelectedItem;

                EstatusAlumno dataAlum = new EstatusAlumno
                {
                    id = objEstado.id,
                    clave = txbxClave.Text,
                    nombre = txbxNombre.Text,
                };

                ADOEstatusAlumno objCrud = new ADOEstatusAlumno();
                switch (btnCompletarAcc.Text)
                {
                    case "Guardar":
                       
                        if (objCrud.Agregar(dataAlum) != 0)
                        {
                            CargarDatos();
                        }
                        else
                        {
                            throw new Exception("Ocurrio un error al intentar agregar");
                        }
                        break;
                    case "Actualizar":
                        objCrud.Actualizar(dataAlum);
                        CargarDatos();
                        break;
                    case "Eliminar":
                        objCrud.Eliminar(dataAlum.id);
                        CargarDatos();
                        break;
                    default:
                        throw new Exception("No se ha encontrado la tabla");
                        break;
                }
            }
            catch (Exception er)
            {
                MessageBox.Show("\nOcurrió un error inesperado los detalles son: " + er.Message + "\n");
            }

        }

        private void btnCancelarAcc_Click(object sender, EventArgs e)
        {
            CargarDatos();
           
        }
    }
}
