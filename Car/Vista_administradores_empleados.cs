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
    public partial class Vista_administradores_empleados : Form
    {

        public Vista_administradores_empleados()
        {
            InitializeComponent();
        }

        int posY = 0;
        int posX = 0;
        private void ListarRegistroEmpleados()
        {
            RegistroAdmon mostrar1 = new RegistroAdmon();
            dgadminemple.DataSource = mostrar1.mostrarRegistroAdmon();
        }



        private void Vista_administradores_empleados_Load(object sender, EventArgs e)
        {
            ListarRegistroEmpleados();
        }

        private void panelvistaadmon_MouseMove(object sender, MouseEventArgs e)
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

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelvistaadmon_Paint(object sender, PaintEventArgs e)
        {

        }

      
    }
}
