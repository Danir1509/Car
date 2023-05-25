using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text;

namespace Car
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public void logear(string usuario, string contrasena)
        {
            try
            {
                Conexion.Conectar();
                SqlCommand cmd = new SqlCommand("SELECT nombre, rol FROM empleado WHERE usuario = @usuario AND contrasena = @pas", Conexion.Conectar());
                cmd.Parameters.AddWithValue("usuario", usuario);

                using (SHA256 sha256 = SHA256.Create())
                {
                    byte[] bytes = Encoding.UTF8.GetBytes(contrasena);
                    byte[] hashBytes = sha256.ComputeHash(bytes);
                    string contrasenaSHA256 = BitConverter.ToString(hashBytes).Replace("-", "").ToLower();

                    cmd.Parameters.AddWithValue("pas", contrasenaSHA256);
                }

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    this.Hide();
                    if (dt.Rows[0][1].ToString() == "admin")
                    {
                        new Administrador(dt.Rows[0][0].ToString()).Show();
                    }
                    else if (dt.Rows[0][1].ToString() == "empleado")
                    {
                        new Empleados(dt.Rows[0][0].ToString()).Show();
                    }
                }
                else
                {
                    MessageBox.Show("Usuario y/o Contraseña Incorrecta");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                Conexion.Conectar().Close();
            }
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            logear(this.txtUser.Text, this.txtPass.Text);


            /*Conexion.Conectar();
            MessageBox.Show("Conexion realizada con exito");*/
        }

        private void pbMostrar_Click(object sender, EventArgs e)
        {
            //Mandamos img ocultar al frente
            pbOcultar.BringToFront();

            //Mostramos la contraseña
            txtPass.PasswordChar = '\0';
        }

        private void pbOcultar_Click(object sender, EventArgs e)
        {
            //Mandamos img mostrar al frente
            pbMostrar.BringToFront();
            //Oculamos la contraseña
            txtPass.PasswordChar = '*';
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinim_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        int posY = 0;
        int posX = 0;
        private void panelTituloLogin_MouseMove(object sender, MouseEventArgs e)
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

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
