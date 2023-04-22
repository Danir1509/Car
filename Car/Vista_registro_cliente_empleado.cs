using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Car.Clases;
namespace Car
{
    public partial class Vista_registro_cliente_empleado : Form
    {
        public Vista_registro_cliente_empleado()
        {
            InitializeComponent();
        }

        int posY = 0;
        int posX = 0;
        private void ListarCliente()
        {
            Cliente mostrar = new Cliente();
            dgregisclient.DataSource = mostrar.mostrarClientes();
        }
        private void panelcontenido_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Vista_registro_cliente_empleado_Load(object sender, EventArgs e)
        {
            ListarCliente();
        }

        private void panelvista2_MouseMove(object sender, MouseEventArgs e)
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

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelvista2_Paint(object sender, PaintEventArgs e)
        {

        }

      
    }
}

