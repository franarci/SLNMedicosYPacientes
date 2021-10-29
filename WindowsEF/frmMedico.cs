using Datos.Admin;
using Datos.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsEF
{
    public partial class frmMedico : Form
    {
        public frmMedico()
        {
            InitializeComponent();
        }

        private void frmMedico_Load(object sender, EventArgs e)
        {
            traerMedicos();
            llenarCombo(cbEspecialidad);
            llenarCombo(cbFiltroEspecialidad);
        }

        private void llenarCombo(ComboBox combo)
        {
            List<Especialidad> especialidades = AdmEspecialidad.Listar();
            if (combo.Name == "cbFiltroEspecialidad")
            {
                especialidades.Insert(0, new Especialidad() { Id = 0, Nombre = "[Todas]" });
            }

            combo.DataSource = especialidades;
            combo.DisplayMember = "Nombre";
            combo.ValueMember = "Id";
        }

        private void traerMedicos()
        {

            gridMedicos.DataSource = AdmMedico.Listar();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            Medico medico = new Medico() { Nombre = txtNombre.Text, Apellido = txtApellido.Text, EspecialidadId = Convert.ToInt32(cbEspecialidad.SelectedValue), Matricula = Convert.ToInt32(txtMatricula.Text) };
            int filasAfectadas = AdmMedico.Insertar(medico);
            Actualizar(filasAfectadas);
        }

        private void Actualizar(int filas)
        {
            if (filas> 0)
            {
                traerMedicos();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Medico medico = new Medico() {MedicoId = Convert.ToInt32(txtId.Text), Nombre=txtNombre.Text, Apellido=txtApellido.Text, Matricula=Convert.ToInt32(txtMatricula.Text), EspecialidadId= Convert.ToInt32(cbEspecialidad.SelectedValue) };

            int filasAfectadas = AdmMedico.Modificar(medico);
            Actualizar(filasAfectadas);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int filasAfectadas = AdmMedico.Eliminar(Convert.ToInt32(txtId.Text));
            Actualizar(filasAfectadas);
        }

        private void cbFiltroEspecialidad_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int especialidad = Convert.ToInt32(cbFiltroEspecialidad.SelectedValue);

            if (especialidad == 0)
            {
                traerMedicos();
            }
            else
            {
                gridMedicos.DataSource = AdmMedico.Listar(Convert.ToInt32(cbFiltroEspecialidad.SelectedValue));
            }
        }
    }
}
