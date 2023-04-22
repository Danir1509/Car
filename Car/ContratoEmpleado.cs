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
    public partial class ContratoEmpleado : Form
    {
        public ContratoEmpleado()
        {
            InitializeComponent();
        }

        int posY = 0;
        int posX = 0;
        private void ContratoEmpleado_MouseMove(object sender, MouseEventArgs e)
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

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Empleados emple = new Empleados("nombre");
            emple.Show();
            this.Close();
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
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

        private void MostrarContrato()
        {
            Contrato mostrar = new Contrato();
            dgContratos.DataSource = mostrar.MostrarContratoEmpleado();
        }

        private void txtbusqueda_TextChanged(object sender, EventArgs e)
        {
            string dato = "%" + txtbusqueda.Text + "%";
            getBuscar(dato);
        }

        private void getBuscar(string dato)
        {

            SqlCommand cmd = Conexion.Conectar().CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT  clientes.nombres As Nombres, clientes.apellidos As Apellidos,  vehiculo.placa as Placa, contratos.Fecha As Fecha_Inicio, alquileres.finalizacion_alquiler As Fecha_Finalizacion, contratos.dias As Dias, contratos.telefono As Telefono, contratos.correo As Correo, contratos.referencia As Referencia, contratos.num_referencia As Numero_Referencia, contratos.precio As Precio, contratos.total_renta As Total_Renta, contratos.tipo_pago As Tipo_Pago, alquileres.estado As Estado FROM contratos INNER JOIN clientes ON clientes.id_cliente = contratos.id_cliente INNER JOIN alquileres ON alquileres.id_alquiler = contratos.id_alquiler INNER JOIN vehiculo ON vehiculo.id_vehiculo = contratos.id_vehiculo Where clientes.nombres like('" + txtbusqueda.Text + "%')  or clientes.apellidos like('" + txtbusqueda.Text + "%') or contratos.correo like('" + txtbusqueda.Text + "%') or vehiculo.placa like('" + txtbusqueda.Text + "%')";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);
            dgContratos.DataSource = dt;

            Conexion.Conectar().Close();

        }

        private void ContratoEmpleado_Load(object sender, EventArgs e)
        {
            MostrarContrato();
        }

        private void btnPdfContratoemple_Click(object sender, EventArgs e)
        {
            ReporteContratoempleado repo = new ReporteContratoempleado();
            repo.Show();
            
        }
    }
}
