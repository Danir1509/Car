using Car.Clases;
using Car.Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car
{
    public partial class ConsultaEntrega : Form
    {
        public ConsultaEntrega()
        {
            InitializeComponent();
        }
        Entrega entrega = new Entrega();
        private void ConsultaEntrega_Load(object sender, EventArgs e)
        {

            MostrarEntrega();
        }

        private void MostrarEntrega()
        {
            dgEntrega.DataSource = entrega.MostrarEntrega();

            DataGridViewImageColumn imageEntre = (DataGridViewImageColumn)dgEntrega.Columns["imagenestado_entrega"];
            imageEntre.ImageLayout = DataGridViewImageCellLayout.Stretch;
            DataGridViewImageColumn imageDevo= (DataGridViewImageColumn)dgEntrega.Columns["imagenestado_devolucion"];
            imageDevo.ImageLayout = DataGridViewImageCellLayout.Stretch;

            AjustarAlturaFilas();
        }

        private void AjustarAlturaFilas()
        {
            foreach (DataGridViewRow row in dgEntrega.Rows)
            {
                row.Height = 100; // Altura deseada (ajústala según tus necesidades)
            }
        }

        private void btnNuevaEntrega_Click(object sender, EventArgs e)
        {
            RegistroEntregas bt = new RegistroEntregas();
            bt.Show();
            this.Close();
        }

        private void btnEditarEntrega_Click(object sender, EventArgs e)
        {
            if (dgEntrega.SelectedRows.Count > 0)
            {
                RegistroEntregas regis = new RegistroEntregas();
                regis.operacion = "editar";
                regis.ListarClientes();
                regis.ListarEmpleado();
                regis.ListarContratos();
                regis.ListarVehiculo();
                regis.id_entrega = dgEntrega.CurrentRow.Cells[0].Value.ToString();
                regis.txtKilo.Text = dgEntrega.CurrentRow.Cells[1].Value.ToString();
                regis.txtEntregades.Text = dgEntrega.CurrentRow.Cells[2].Value.ToString();
                regis.txtDevodes.Text = dgEntrega.CurrentRow.Cells[3].Value.ToString();

                DataGridViewCell celda1 = dgEntrega.CurrentRow.Cells[4];
                byte[] arregloBytes1 = (byte[])celda1.Value;
                Image imagen1;
                using (MemoryStream ms1 = new MemoryStream(arregloBytes1))
                {
                    imagen1 = Image.FromStream(ms1);
                }
                regis.pbImgEntrega.Image = imagen1;

                DataGridViewCell celda2 = dgEntrega.CurrentRow.Cells[5];
                byte[] arregloBytes2 = (byte[])celda2.Value;
                Image imagen2;
                using (MemoryStream ms2 = new MemoryStream(arregloBytes2))
                {
                    imagen2 = Image.FromStream(ms2);
                }
                regis.pcImagenDevo.Image = imagen2;

                DataTable origenDatos2 = ((DataTable)dgEntrega.DataSource).Copy();
                int filaActual2 = dgEntrega.CurrentRow.Index;
                origenDatos2.Rows[filaActual2][5] = arregloBytes2;
                dgEntrega.DataSource = origenDatos2;
                dgEntrega.Refresh();


                regis.dtpFechaentrega.Text = dgEntrega.CurrentRow.Cells[6].Value.ToString();
                regis.dtpFechaentrega.Text = dgEntrega.CurrentRow.Cells[7].Value.ToString();
                regis.cbIdCliente.Text = dgEntrega.CurrentRow.Cells[8].Value.ToString();
                regis.cbEmpleado.Text = dgEntrega.CurrentRow.Cells[9].Value.ToString();
                regis.cbVehiculo.Text = dgEntrega.CurrentRow.Cells[10].Value.ToString();
                regis.cbContrato.Text = dgEntrega.CurrentRow.Cells[11].Value.ToString();

                regis.ShowDialog();
                
                MostrarEntrega();
                this.Close();

            }
            else
            {
                MessageBox.Show("---- Selecciones una fila para editarla -----");
            }
        }

        private void btnEliminarEntrega_Click(object sender, EventArgs e)
        {
            if (dgEntrega.CurrentRow.Index > 0)
            {
                entrega.Id_entrega = Convert.ToInt32(dgEntrega.CurrentRow.Cells[0].Value);
                entrega.EliminarEntrgeas();
                MessageBox.Show("Registro Eliminado");
                MostrarEntrega();
            }
            else
            {
                MessageBox.Show("---- Selecciones una fila para Eliminarla -----");
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Administrador mostrar = new Administrador("nombre");
            mostrar.Show();
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnPdfEntrega_Click(object sender, EventArgs e)
        {
            ReporteEntrega report = new ReporteEntrega();
            report.Show();
        }

        int posY = 0;
        int posX = 0;
        private void panel2ConsultaEntrega_MouseMove(object sender, MouseEventArgs e)
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
