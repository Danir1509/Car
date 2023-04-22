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
using Car.Reportes;
namespace Car
{
    public partial class vista_registro_cliente_admon : Form
    {

        public vista_registro_cliente_admon()
        {
            InitializeComponent();
        }
        int posY = 0;
        int posX = 0;

        Cliente cliente = new Cliente();
        string operacion = "";
        public string id_cliente;
        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Administrador admin = new Administrador("nombre");
            admin.Show();
            this.Close();
        }
        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {

        }



        private void dgclientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtBuscador_TextChanged(object sender, EventArgs e)
        {
            String dato = "%" + txtBuscador.Text + "%";
            buscarReserva(dato);
        }

        private void buscarReserva(string dato)
        {
            SqlCommand comando = Conexion.Conectar().CreateCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "select * from reserva where id_reserva like ('" + txtBuscador.Text + "%') ";
            comando.ExecuteNonQuery();
            DataTable reserva = new DataTable();
            SqlDataAdapter data = new SqlDataAdapter(comando);
            data.Fill(reserva);
            dgclientes.DataSource = reserva;
            Conexion.Conectar().Close();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            Form1 cliente = new Form1();
            cliente.operacion = "insertar";
            cliente.ShowDialog();
            this.Close();
            ListarCliente();

        }
        private void ListarCliente()
        {
            Cliente mostrar = new Cliente();
            dgclientes.DataSource = mostrar.mostrarClientes();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (dgclientes.SelectedRows.Count > 0)
            {
                MessageBox.Show("Esta seguro que quiere eliminar el registro?");
                cliente.Id_cliente = Convert.ToInt32(dgclientes.CurrentRow.Cells[0].Value);
                cliente.eliminarCliente();
                MessageBox.Show("Se elimino satisfactoriamente");
                     ListarCliente();
            

            }
            else
            {
                MessageBox.Show("Seleccione una fila");
            }
        }

        private void form2_Load(object sender, EventArgs e)
        {
            ListarCliente();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgclientes.SelectedRows.Count > 0)
            {
                Form1 editcliente = new Form1();
                editcliente.operacion = "editar";
                editcliente.id_cliente = dgclientes.CurrentRow.Cells[0].Value.ToString();
                editcliente.txtnombre.Text = dgclientes.CurrentRow.Cells[1].Value.ToString();
                editcliente.txtapellido.Text = dgclientes.CurrentRow.Cells[2].Value.ToString();
                editcliente.txtdireccion.Text = dgclientes.CurrentRow.Cells[3].Value.ToString();
                editcliente.txttelefono.Text = dgclientes.CurrentRow.Cells[4].Value.ToString();
                editcliente.txtcorreo.Text = dgclientes.CurrentRow.Cells[5].Value.ToString();
                editcliente.txtdui.Text = dgclientes.CurrentRow.Cells[6].Value.ToString();
                editcliente.txtlicencia.Text = dgclientes.CurrentRow.Cells[7].Value.ToString();
                editcliente.txtestado.Text = dgclientes.CurrentRow.Cells[8].Value.ToString();
                editcliente.ShowDialog();
                this.Close();
                ListarCliente();


            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila");
            }
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

        private void panelvista2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btngenerar_Click(object sender, EventArgs e)
        {
            ReporteClientes reportee = new ReporteClientes();
            reportee.Show();
        }
    }
}

