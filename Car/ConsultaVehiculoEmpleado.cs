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
using System.Data.SqlClient;

namespace Car
{
    public partial class ConsultaVehiculoEmpleado : Form
    {
        public ConsultaVehiculoEmpleado()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        int posY = 0;
        int posX = 0;

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

        private void txtBuscador_TextChanged(object sender, EventArgs e)
        {
            string dato = "%" + txtBuscador.Text + "%";
            buscarVehiculo(dato);
        }

        private void consultaVehiculos()
        {
            vehiculo cv = new vehiculo();
            dgVIEW.DataSource = cv.consultaVehiculos();

        }

        private void dgVIEW_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buscarVehiculo(string dato)
        {
            SqlCommand comando = Conexion.Conectar().CreateCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "Select  placa, marca, tipo_transmision, tipo_vehiculo, categoria, condicion_vehiculo, capacidad, consumo_combus, precio_dia, anio, estado FROM vehiculo where marca like ('" + txtBuscador.Text + "%')";
            comando.ExecuteNonQuery();
            DataTable vehiculo = new DataTable();
            SqlDataAdapter data = new SqlDataAdapter(comando);
            data.Fill(vehiculo);
            dgVIEW.DataSource = vehiculo;
            Conexion.Conectar().Close();
        }

        private void ConsultaVehiculoEmpleado_Load(object sender, EventArgs e)
        {
            consultaVehiculos();
        }
    }
}
