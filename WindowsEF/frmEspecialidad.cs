using System;
using System.Windows.Forms;
using Datos.Admin;
using Datos.Models;

namespace WindowsEF
{
    public partial class frmEspecialidad : Form
    {
        public frmEspecialidad()
        {
            InitializeComponent();
        }

        private void frmEspecialidad_Load(object sender, EventArgs e)
        {
            traerEspecialidades();
        }

        private void traerEspecialidades()
        {
            gridEspecialidades.DataSource = AdmEspecialidad.Listar();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            Especialidad especialidad = new Especialidad() { Nombre = txtNombre.Text };
            int filasAfectadas = AdmEspecialidad.Insertar(especialidad);
            Actualizar(filasAfectadas);
        }

        private void Actualizar(int filas)
        {
            if (filas > 0)
            {
                traerEspecialidades();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Especialidad especialidad = new Especialidad() { Id = Convert.ToInt32(txtId.Text), Nombre = txtNombre.Text };

            int filasAfectadas = AdmEspecialidad.Modificar(especialidad);
            Actualizar(filasAfectadas);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int filasAfectadas = AdmEspecialidad.Eliminar(Convert.ToInt32(txtId.Text));
            Actualizar(filasAfectadas);
        }

    }
}
