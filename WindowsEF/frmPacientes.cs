using System;
using System.Windows.Forms;


namespace WindowsEF
{
    public partial class frmPacientes : Form
    {
        public frmPacientes()
        {
            InitializeComponent();
        }

        private void frmPacientes_Load(object sender, EventArgs e)
        {
            traerPacientes();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            Paciente paciente = new Paciente() { Nombre = "Ana", Apellido = "Fernandez", FechaNacimiento = new DateTime(2001, 1, 1), NroHistoriaClinica = 1111, MedicoId = 2 };

            int filasAfectadas = AdmPaciente.Insertar(paciente);
            if (filasAfectadas > 0)
            {
                traerPacientes();
            }
        }
        private void traerPacientes()
        {
            gridPacientes.DataSource = AdmPaciente.Listar();
        }
    }
}
