using System;
using System.Windows.Forms;
using Car.Reportes;

namespace Car
{
    public partial class Empleados : Form
    {
        public Empleados(String nombre)
        {
            InitializeComponent();
            lblMensajeEmpleado.Text = "Bienvenido/a  " + nombre;
        }

        private void Empleados_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            Login log = new Login();
            log.Show();
        }

        private void btnMaxi_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnMinim_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMantenimiento_Click(object sender, EventArgs e)
        {
            if (!panelMantenimi.Visible)
                panelMantenimi.Visible = true;
            else
                panelMantenimi.Visible = false;
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            if (!panelReportes.Visible)
                panelReportes.Visible = true;
            else
                panelReportes.Visible = false;
        }

        private void btnAcercade_Click(object sender, EventArgs e)
        {
            if (!panelAcercaDe.Visible)
                panelAcercaDe.Visible = true;
            else
                panelAcercaDe.Visible = false;
        }

        private void btnConsultaContratos_Click(object sender, EventArgs e)
        {
            ContratoEmpleado emple = new ContratoEmpleado();
            emple.Show();
            this.Hide();
        }

        private void btnConsultaCliente_Click(object sender, EventArgs e)
        {
            Vista_administradores_empleados vista1 = new Vista_administradores_empleados();
            vista1.Show();
        }

        private void btnConsultaEmple_Click(object sender, EventArgs e)
        {
            Vista_administradores_empleados vistacinco = new Vista_administradores_empleados();
            vistacinco.Show();
        }

        private void btnConsultaAlquiler_Click(object sender, EventArgs e)
        {
            ConsulaAlquilerE alquiler = new ConsulaAlquilerE();
            alquiler.Show();
        }

        private void btnConsultaReservas_Click(object sender, EventArgs e)
        {
            ConsultarReservaE reserva = new ConsultarReservaE();
            reserva.Show();
        }

        private void btnListAlquileres_Click(object sender, EventArgs e)
        {
            ReporteAlquileres ralqui = new ReporteAlquileres();
            ralqui.Show();
        }

        private void btnListReservas_Click(object sender, EventArgs e)
        {
            ReporteReserva rreserva = new ReporteReserva();
            rreserva.Show();
        }
    }
}
