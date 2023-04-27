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
    public partial class Registro_de_administrador_R : Form
    {
        RegistroAdmon registroAdmon = new RegistroAdmon();
        public Registro_de_administrador_R()
        {
            InitializeComponent();
        }

        private void Registro_de_administrador_R_Load(object sender, EventArgs e)
        {

        }
        int posY = 0;
        int posX = 0;
        public string operacion2 = "insertar";
        internal string id_empleado;
        private void panelvistauno_MouseMove(object sender, MouseEventArgs e)
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
            Administrador admin = new Administrador("nombre");
            admin.Show();
            this.Close();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnRegistrarRegistro_Click(object sender, EventArgs e)
        {
            if (operacion2 == "insertar")
            {
                try
                {
                    registroAdmon.Nombre = txtnombreregis.Text;
                    registroAdmon.Usuario = txtUsuario.Text;
                    registroAdmon.Contrasena = txtcontrasena.Text;
                    registroAdmon.Tipo_empleado = txtcargo.Text;
                    registroAdmon.insertarRegistroEmpleados();
                    MessageBox.Show("Datos de Registro de Administrados y Empleado Insertados Correctamente.");
                    

                  

                }
                catch (Exception l)
                {
                    MessageBox.Show("Error! Datos Nofueron Insertados" + l);
                }
            }
            else if (operacion2 == "editar")
            {
                try
                {
                    registroAdmon.Nombre = txtnombreregis.Text;
                    registroAdmon.Usuario = txtUsuario.Text;
                    registroAdmon.Contrasena = txtcontrasena.Text;
                    registroAdmon.Tipo_empleado = txtcargo.Text;
                    registroAdmon.Id_empleado = Convert.ToInt32(id_empleado);
                    registroAdmon.editarRegistroAdmon();
                    MessageBox.Show("Datos de Registro de Administrados y Empleado Editados Correctamente.");
                }
                catch (Exception l)
                {
                    MessageBox.Show("Error! Datos no Fueron Editados." + l);
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtnombreregis.Text = "";
            this.txtUsuario.Text = "";
            this.txtcontrasena.Text = "";
            this.txtcargo.Text = "";
        }

        private void btnvistaregistro_Click(object sender, EventArgs e)
        {
            Vista_administrador_empleado_admon vista5 = new Vista_administrador_empleado_admon();
            vista5.Show();
        }

        private void panelvistauno_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnregisemple_Click(object sender, EventArgs e)
        {
            Vista_administradores_empleados vista6 = new Vista_administradores_empleados();
            vista6.Show();


        }

        private void panelvistauno_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void Registro_de_administrador_R_Load_1(object sender, EventArgs e)
        {
            
        }
    }
}
