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
    public partial class RegistroVehiculo : Form
    {
        vehiculo vehiculo = new vehiculo();

        public RegistroVehiculo()
        {
            InitializeComponent();
        }
        public string Operacion = "insertar";
        public void listarTipoVehiculo()
        {
            vehiculo tipovehiculo = new vehiculo();
            CbVehiculo.DataSource = tipovehiculo.listarTipoVehiculo();
            CbVehiculo.DisplayMember = "tipo_vehiculo";
            CbVehiculo.ValueMember = "tipo_vehiculo";

        }

        public void listarTipoTransmision()
        {
            vehiculo tipovehiculo = new vehiculo();
            cbTransmision.DataSource = tipovehiculo.listarTipoTransmision();
            cbTransmision.DisplayMember = "tipo_transmision";
            cbTransmision.ValueMember = "tipo_transmision";

        }

        public void listarCategoria()
        {
            vehiculo tipovehiculo = new vehiculo();
            cbCategoria.DataSource = tipovehiculo.listarCategoria();
            cbCategoria.DisplayMember = "categoria";
            cbCategoria.ValueMember = "categoria";

        }
        private void RegistroVehiculo_Load(object sender, EventArgs e)
        {

            listarTipoVehiculo();
            listarTipoTransmision();
            listarCategoria();
            
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            if (Operacion == "insertar")
            {
                try
                {
                    vehiculo.Placa = txtPlaca.Text;
                    vehiculo.Marca = txtMarca.Text;
                    vehiculo.Tipo_vehiculo = CbVehiculo.Text;
                    vehiculo.Tipo_transmision = cbTransmision.Text;
                    vehiculo.Categoria = cbCategoria.Text;
                    vehiculo.Condicion_vehiculo = txtCondicion.Text;
                    vehiculo.Capacidad = txtCapacidad.Text;
                    vehiculo.Consumo_combus = txtCombustible.Text;
                    vehiculo.Precio_dia = txtPrecio.Text;
                    vehiculo.Anio = txtAnio.Text;
                    vehiculo.Estado = txtEstado.Text;

                    vehiculo.insertarVehiculo();
                    MessageBox.Show("Vehiculo insertado correctamente");
                }
                catch (Exception v)
                {
                    MessageBox.Show("No se insertaron los datos" + v);
                }

            }
            else
                if (Operacion == "editar")
            {
                try
                {
                    vehiculo.Placa = txtPlaca.Text;
                    vehiculo.Marca = txtMarca.Text;
                    vehiculo.Tipo_vehiculo = CbVehiculo.Text;
                    vehiculo.Tipo_transmision = cbTransmision.Text;
                    vehiculo.Categoria = cbCategoria.Text;
                    vehiculo.Condicion_vehiculo = txtCondicion.Text;
                    vehiculo.Capacidad = txtCapacidad.Text;
                    vehiculo.Consumo_combus = txtCombustible.Text;
                    vehiculo.Precio_dia = txtPrecio.Text;
                    vehiculo.Anio = txtAnio.Text;
                    vehiculo.Estado = txtEstado.Text;
                    vehiculo.Id_vehiculo = Convert.ToInt32(id_vehiculo);


                    vehiculo.editarVehiculo();
                    MessageBox.Show("Vehiculo editado correctamente");
                }
                catch (Exception v)
                {
                    MessageBox.Show("No se editaron los datos" + v);
                }

            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            Administrador admin = new Administrador("nombre");
            admin.Show();
            
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        int posY = 0;
        int posX = 0;
        internal object id_vehiculo;

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

       
    }
}
