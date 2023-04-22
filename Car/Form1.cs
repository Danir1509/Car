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
    public partial class Form1 : Form
    {
        Cliente cliente = new Cliente();


        public Form1()
        {
            InitializeComponent();
        }



        int posY = 0;
        int posX = 0;
        public string operacion = "insertar";
        internal string id_cliente;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
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
            Administrador loquesea = new Administrador("nombre");
            loquesea.Show();
            this.Close();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (operacion == "insertar")
            {
                try
                {
                    cliente.Nombres = txtnombre.Text;
                    cliente.Apellidos = txtapellido.Text;
                    cliente.Direccion = txtdireccion.Text;
                    cliente.Telefono = txttelefono.Text;
                    cliente.Correo = txtcorreo.Text;
                    cliente.Dui = txtdui.Text;
                    cliente.Licencia = txtlicencia.Text;
                    cliente.Estado = txtestado.Text;

                    cliente.insertarCliente();
                    MessageBox.Show("Datos de Reserva Insertados Correctamente!");
                }
                catch (Exception l)

                {
                    MessageBox.Show("Error! Datos no Fueron insertados." + l);
                }
            }
            else if (operacion == "editar")
            {
                try
                {
                    cliente.Nombres = txtnombre.Text;
                    cliente.Apellidos = txtapellido.Text;
                    cliente.Direccion = txtdireccion.Text;
                    cliente.Telefono = txttelefono.Text;
                    cliente.Correo = txtcorreo.Text;
                    cliente.Dui = txtdui.Text;
                    cliente.Licencia = txtlicencia.Text;
                    cliente.Estado = txtestado.Text;
                    cliente.Id_cliente = Convert.ToInt32(id_cliente);
                    cliente.editarCliente();
                    MessageBox.Show("Datos de Reserva Editados Correctamente!");
                }
                catch (Exception l)
                {
                    MessageBox.Show("Error! Datos no Fueron Editados." + l);
                }
            }



        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            this.txtnombre.Text = "";
            this.txtapellido.Text = "";
            this.txtdireccion.Text = "";
            this.txttelefono.Text = "";
            this.txtcorreo.Text = "";
            this.txtdui.Text = "";
            this.txtlicencia.Text = "";
            this.txtestado.Text = "";
        }

        private void btnRegistrar_Click_1(object sender, EventArgs e)
        {

        }

        private void btnvista_Click(object sender, EventArgs e)
        {
            vista_registro_cliente_admon vista1 = new vista_registro_cliente_admon();
            vista1.Show();

        }

        private void btnregisclient_Click(object sender, EventArgs e)
        {
            Vista_registro_cliente_empleado vista2 = new Vista_registro_cliente_empleado();
            vista2.Show();
        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnregistroadmon_Click(object sender, EventArgs e)
        {
            Registro_de_administrador_R vista3 = new Registro_de_administrador_R();
            vista3.Show();
        }

    }
}
