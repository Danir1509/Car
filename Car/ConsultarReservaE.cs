using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Car.Clases;

namespace Car
{
    public partial class ConsultarReservaE : Form
    {
        public ConsultarReservaE()
        {
            InitializeComponent();
        }

        private void ConsultarReservaE_Load(object sender, EventArgs e)
        {
            ListarReservas();
        }

        private void ListarReservas()
        {
            Reserva mostrar = new Reserva();
            dgvReserva.DataSource = mostrar.ListarReservas();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void btnMinim_Click(object sender, EventArgs e)
        {

        }
        int posY = 0;
        int posX = 0;
        private void panelTituloConsultaReservaE_MouseMove(object sender, MouseEventArgs e)
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
    }
}
