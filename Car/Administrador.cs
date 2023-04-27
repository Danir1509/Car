using System;
using System.Drawing;
using System.Windows.Forms;
using Car.Reportes;

namespace Car
{
    public partial class Administrador : Form
    {
        public Administrador(string nombre)
        {
            InitializeComponent();
            lblMensajeAdmin.Text = "Bienvenido/a  " + nombre;
        }


        Panel p = new Panel();
        private void btnMouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            MenuAdminPanel.Controls.Add(p);
            p.BackColor = Color.FromArgb(35, 112, 247);
            p.Size = new Size(181, 5);
            p.Location = new Point(btn.Location.X, btn.Location.Y + 49);
        }

        private void btnMouseLeave(object sender, EventArgs e)
        {
            MenuAdminPanel.Controls.Remove(p);
        }

        private void lblAdministrado_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Administrador_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void btnReserva_Click(object sender, EventArgs e)
        {
            if (!panelReserva.Visible)
                panelReserva.Visible = true;
            else
                panelReserva.Visible = false;
        }

        private void btnAlquileres_Click(object sender, EventArgs e)
        {
            if (!panelAlquileres.Visible)
                panelAlquileres.Visible = true;
            else
                panelAlquileres.Visible = false;
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            if (!panelClientes.Visible)
                panelClientes.Visible = true;
            else
                panelClientes.Visible = false;
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            if (!panelEmpleados.Visible)
                panelEmpleados.Visible = true;
            else
                panelEmpleados.Visible = false;
        }

        private void bnMantenimiento_Click(object sender, EventArgs e)
        {

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

        private void btnMantenimiento_Click(object sender, EventArgs e)
        {
            if (!panelMantenimi.Visible)
                panelMantenimi.Visible = true;
            else
                panelMantenimi.Visible = false;
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

        int posY = 0;
        int posX = 0;
        private void panelTituloAdmin_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                posX = e.X;
                posY = e.Y;
            }
            else
            {
                Left = Left + (e.X - posX);
                Top = Top + (e.Y - posY);
            }
        }

        private void btnRegistroAlquiler_Click(object sender, EventArgs e)
        {
            Registro_Alquiler alquiler = new Registro_Alquiler();
            alquiler.Show();
            this.Close();
        }

        private void btnConsultaAlquiler_Click(object sender, EventArgs e)
        {
            ConsultaAlquileres consualqui = new ConsultaAlquileres();
            consualqui.Show();
            this.Close();
        }

        private void btnConsultaReservas_Click(object sender, EventArgs e)
        {
            ConsultaReservas consureserva = new ConsultaReservas();
            consureserva.Show();
            this.Close();
        }

        private void btnRegistroReserva_Click(object sender, EventArgs e)
        {
            RegistroReservas reserva = new RegistroReservas();
            reserva.Show();
            this.Close();
        }

        private void btnConsultaContratos_Click(object sender, EventArgs e)
        {
            ContratoDetalle contrato = new ContratoDetalle();
            contrato.Show();
            this.Close();
        }

        private void btnConsultaVehiculos_Click(object sender, EventArgs e)
        {
            VistaRegistro r = new VistaRegistro();
            r.Show();
            this.Close();
        }

        private void btnConsultaCliente_Click(object sender, EventArgs e)
        {
            vista_registro_cliente_admon vistacuatro = new vista_registro_cliente_admon();
            vistacuatro.Show();
            this.Close();
        }

        private void btnRegistroCliente_Click(object sender, EventArgs e)
        {
            Form1 vistauno = new Form1();
            vistauno.Show();
            this.Close();
        }

        private void btnRegistroAdministrador_Click(object sender, EventArgs e)
        {
            Registro_de_administrador_R vistados = new Registro_de_administrador_R();
            vistados.Show();
            this.Close();

        }

        private void btnConsultaEmple_Click(object sender, EventArgs e)
        {
            Vista_administrador_empleado_admon vistatres = new Vista_administrador_empleado_admon();
            vistatres.Show();
            this.Close();
        }

        private void btnRegistroEmpleado_Click(object sender, EventArgs e)
        {
            Registro_de_administrador_R vistados = new Registro_de_administrador_R();
            vistados.Show();
            this.Close();
        }

        private void btnListCliente_Click(object sender, EventArgs e)
        {
            ReporteClientes report = new ReporteClientes();
            report.Show();
        }

        private void bntListaEmpleados_Click(object sender, EventArgs e)
        {
            ReporteEmpleados_Administradores vis = new ReporteEmpleados_Administradores();
            vis.Show();
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

        private void btnVersion_Click(object sender, EventArgs e)
        {
            VersionApp versionA = new VersionApp();
            versionA.Show();
        }

        private void btnAutores_Click(object sender, EventArgs e)
        {
            AutoresApp autoresA = new AutoresApp();
            autoresA.Show();
        }

        private void btnRegistroContrato_Click(object sender, EventArgs e)
        {
            RegistroContrato contra = new RegistroContrato();
            contra.Show();
            this.Close();
        }

        private void btnListContratos_Click(object sender, EventArgs e)
        {
            ReporteContrato repo = new ReporteContrato();
            repo.Show();
        }

        private void btnRegistroVehiculo_Click(object sender, EventArgs e)
        {
            RegistroVehiculo vehi = new RegistroVehiculo();
            vehi.Show();
            this.Close();
        }

        private void btnListVehiculos_Click(object sender, EventArgs e)
        {
            ReporteVehiculo vehi = new ReporteVehiculo();
            vehi.Show();
           
        }
    }
}
