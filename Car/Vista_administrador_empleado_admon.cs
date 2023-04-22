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
    public partial class Vista_administrador_empleado_admon : Form
    {

        public Vista_administrador_empleado_admon()
        {
            InitializeComponent();
        }
        int posY = 0;
        int posX = 0;

        RegistroAdmon registroAdmon = new RegistroAdmon();
        string operacion2 = "";
        public string id_empleado;
        private void lbltema_Click(object sender, EventArgs e)
        {

        }

        private void Vista_administrador_empleado_admon_Load(object sender, EventArgs e)
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

        private void btnNuevoADMINISTRADOR_Click(object sender, EventArgs e)
        {
            Registro_de_administrador_R vistaregistro = new Registro_de_administrador_R();
            vistaregistro.operacion2 = "insertar";
            vistaregistro.ShowDialog();
            ListarRegistroEmpleados();

        }
        private void ListarRegistroEmpleados()
        {
            RegistroAdmon mostrar1 = new RegistroAdmon();
            dgregistroadmon.DataSource = mostrar1.mostrarRegistroAdmon();
        }

        private void btnEliminaradmon_Click(object sender, EventArgs e)
        {
            if (dgregistroadmon.SelectedRows.Count > 0)
            {
                MessageBox.Show("Esta seguro que quiere eliminar el registro?");
                registroAdmon.Id_empleado = Convert.ToInt32(dgregistroadmon.CurrentRow.Cells[0].Value);
                registroAdmon.eliminarRegistroAdmon();
                MessageBox.Show("Se elimino satisfactoriamente");
                ListarRegistroEmpleados();

            }
            else
            {
                MessageBox.Show("Selecione una fila");
            }
        }

        private void btnEditaradmon_Click(object sender, EventArgs e)
        {
            if (dgregistroadmon.SelectedRows.Count > 0)
            {
                Registro_de_administrador_R editRegistro = new Registro_de_administrador_R();
                editRegistro.operacion2 = "editar";
                editRegistro.id_empleado = dgregistroadmon.CurrentRow.Cells[0].Value.ToString();
                editRegistro.txtnombreregis.Text = dgregistroadmon.CurrentRow.Cells[1].Value.ToString();
                editRegistro.txtUsuario.Text = dgregistroadmon.CurrentRow.Cells[2].Value.ToString();
                editRegistro.txtcontrasena.Text = dgregistroadmon.CurrentRow.Cells[3].Value.ToString();
                editRegistro.txtcargo.Text = dgregistroadmon.CurrentRow.Cells[4].Value.ToString();
                editRegistro.ShowDialog();
                ListarRegistroEmpleados();

            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila");
            }
        }

        private void panelvistaadmon_Paint(object sender, PaintEventArgs e)
        {

        }

      
    }
}

