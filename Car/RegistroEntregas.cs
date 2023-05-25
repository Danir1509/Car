using Car.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car
{
    public partial class RegistroEntregas : Form
    {
        public RegistroEntregas()
        {
            InitializeComponent();
        }

        public string operacion = "insertar";
        internal string id_entrega;

        Entrega entrega = new Entrega();
        ConsultaEntrega entre = new ConsultaEntrega();

        private void RegistroEntregas_Load(object sender, EventArgs e)
        {
            ListarClientes();
            ListarVehiculo();
            ListarEmpleado();
            ListarContratos();
        }

        public void ListarClientes()
        {
            Entrega mostrar = new Entrega();
            cbIdCliente.DataSource = mostrar.NombreCliente();
            cbIdCliente.DisplayMember = "nombres";
            cbIdCliente.ValueMember = "id_cliente";
        }
        public void ListarEmpleado()
        {
            Entrega mostrar = new Entrega();
            cbEmpleado.DataSource = mostrar.NombreEmpleado();
            cbEmpleado.DisplayMember = "nombre";
            cbEmpleado.ValueMember = "id_empleado";
        }

        public void ListarContratos()
        {
            Entrega mostrar = new Entrega();
            cbContrato.DataSource = mostrar.IdContrato();
            cbContrato.DisplayMember = "id_contrato";
            cbContrato.ValueMember = "id_contrato";
        }

        public void ListarVehiculo()
        {
            Contrato mostrar = new Contrato();
            cbVehiculo.DataSource = mostrar.PlacaVehiculo();
            cbVehiculo.DisplayMember = "placa";
            cbVehiculo.ValueMember = "id_vehiculo";
        }

        private void btnGuardarEntrega_Click(object sender, EventArgs e)
        {
            if (operacion == "insertar")
            {

                try
                {

                    ImageConverter converter = new ImageConverter();

                    byte[] imagenEntregaBytes = (byte[])converter.ConvertTo(pbImgEntrega.Image, typeof(byte[]));
                    byte[] imagenDevoBytes = (byte[])converter.ConvertTo(pcImagenDevo.Image, typeof(byte[]));

                    entrega.Fecha_entrega = dtpFechaentrega.Value.ToString("yyyy-MM-dd");
                    entrega.Fecha_devolucion = dtpFechaDevo.Value.ToString("yyyy-MM-dd");
                    entrega.Id_cliente = Convert.ToInt32(cbIdCliente.SelectedValue);
                    entrega.Id_contrato = Convert.ToInt32(cbContrato.SelectedValue);
                    entrega.Id_empleado = Convert.ToInt32(cbEmpleado.SelectedValue);
                    entrega.Id_vehiculo = Convert.ToInt32(cbVehiculo.SelectedValue);
                    entrega.Kilometraje = txtKilo.Text;
                    entrega.Descripestado_entrgea = txtEntregades.Text;
                    entrega.Descripestado_devolucion = txtDevodes.Text;
                    entrega.Imagenestado_entrega = imagenEntregaBytes;
                    entrega.Imagenestado_devolucion = imagenDevoBytes;

                    entrega.InsertarEntrega();

                    MessageBox.Show("Datos de Contrato insertados correctamente");

                    entre.Show();
                    this.Close();
                }
                catch (Exception l)
                {
                    MessageBox.Show("No se  insertaron los datos del contrato" + l);
                }
            }
            else if (operacion == "editar")
            {

                try
                {

                    ImageConverter converter = new ImageConverter();

                    byte[] imagenEntregaBytes = (byte[])converter.ConvertTo(pbImgEntrega.Image, typeof(byte[]));
                    byte[] imagenDevoBytes = (byte[])converter.ConvertTo(pcImagenDevo.Image, typeof(byte[]));

                    entrega.Id_entrega = Convert.ToInt32(id_entrega);
                    entrega.Fecha_entrega = dtpFechaentrega.Value.ToString("yyyy-MM-dd");
                    entrega.Fecha_devolucion = dtpFechaDevo.Value.ToString("yyyy-MM-dd");
                    entrega.Id_cliente = Convert.ToInt32(cbIdCliente.SelectedValue);
                    entrega.Id_contrato = Convert.ToInt32(cbContrato.SelectedValue);
                    entrega.Id_empleado = Convert.ToInt32(cbEmpleado.SelectedValue);
                    entrega.Id_vehiculo = Convert.ToInt32(cbVehiculo.SelectedValue);
                    entrega.Kilometraje = txtKilo.Text;
                    entrega.Descripestado_entrgea = txtEntregades.Text;
                    entrega.Descripestado_devolucion = txtDevodes.Text;
                    entrega.Imagenestado_entrega = imagenEntregaBytes;
                    entrega.Imagenestado_devolucion = imagenDevoBytes;

                    entrega.EditarEntrega();

                    MessageBox.Show("Datos de Entrega Actualizados correctamente");

                    entre.Show();
                    this.Close();
                }
                catch (Exception l)
                {
                    MessageBox.Show("No se  Actualizaron los datos del contrato" + l);
                }

            }
        }

        private void btnImgEntrega_Click(object sender, EventArgs e)
        {
            OpenFileDialog fo = new OpenFileDialog();
            DialogResult rs = fo.ShowDialog();
            if (rs == DialogResult.OK)
            {

                pbImgEntrega.Image = Image.FromFile(fo.FileName);
            }
        }

        private void btnImgDevo_Click(object sender, EventArgs e)
        {
            OpenFileDialog fo = new OpenFileDialog();
            DialogResult rs = fo.ShowDialog();
            if (rs == DialogResult.OK)
            {

                pcImagenDevo.Image = Image.FromFile(fo.FileName);
            }
        }
    }
}
