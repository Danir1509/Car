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
using Car.Reportes;

namespace Car
{
    public partial class VistaRegistro : Form
    {        


            public VistaRegistro()
            {
                InitializeComponent();
            }
            vehiculo vehi = new vehiculo();
            string Operacion = "";
            public string id_vehiculo;
            private void btnNuevoV_Click(object sender, EventArgs e)
            {
                RegistroVehiculo bt = new RegistroVehiculo();
                bt.Operacion = "insertar";
                bt.listarTipoVehiculo();
                bt.listarTipoTransmision();
                bt.listarCategoria();
                bt.ShowDialog();
            this.Close();
                mostrarVehiculos();
            }

            private void dgTabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {

            }


            private void textBox1_TextChanged(object sender, EventArgs e)
            {
                string dato = "%" + txtBuscar.Text + "%";
                buscarVehiculo(dato);
            }

            private void buscarVehiculo(string dato)
            {
                SqlCommand comando = Conexion.Conectar().CreateCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "select * from vehiculo where id_vehiculo like ('" + txtBuscar.Text + "%')";
                comando.ExecuteNonQuery();
                DataTable vehiculo = new DataTable();
                SqlDataAdapter data = new SqlDataAdapter(comando);
                data.Fill(vehiculo);
                dgTabla.DataSource = vehiculo;
                Conexion.Conectar().Close();
            }

            private void btnEliminar_Click(object sender, EventArgs e)
            {
                string id_vehi = dgTabla.CurrentRow.Cells["id_vehiculo"].Value.ToString();
                if (dgTabla.CurrentRow.Index > 0)
                {
                    if (vehiculo.Eliminar_vehiculo(id_vehi))
                    {
                        MessageBox.Show("Registro Eliminado");
                        VistaRegistro vista = new VistaRegistro();
                        vista.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Eliminacion Erronea vuelva a intentarlo");
                    }

                }
                else
                {
                    MessageBox.Show("Seleccione una fila a eliminar");
                }

            }

            private void btnCerrar_Click(object sender, EventArgs e)
            {
                Administrador admin = new Administrador("nombre");
                admin.Show();
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

            private void btnEditar_Click(object sender, EventArgs e)
            {
                if (dgTabla.SelectedRows.Count > 0)

                {
                    RegistroVehiculo rgVehiculo = new RegistroVehiculo();
                    rgVehiculo.Operacion = "editar";
                    rgVehiculo.listarTipoVehiculo();
                    rgVehiculo.listarTipoTransmision();
                    rgVehiculo.listarCategoria();
                    rgVehiculo.id_vehiculo = dgTabla.CurrentRow.Cells[0].Value.ToString();
                    rgVehiculo.txtPlaca.Text = dgTabla.CurrentRow.Cells[1].Value.ToString();
                    rgVehiculo.txtMarca.Text = dgTabla.CurrentRow.Cells[2].Value.ToString();
                    rgVehiculo.CbVehiculo.Text = dgTabla.CurrentRow.Cells[3].Value.ToString();
                    rgVehiculo.cbTransmision.Text = dgTabla.CurrentRow.Cells[4].Value.ToString();
                    rgVehiculo.cbCategoria.Text = dgTabla.CurrentRow.Cells[5].Value.ToString();
                    rgVehiculo.txtCondicion.Text = dgTabla.CurrentRow.Cells[6].Value.ToString();
                    rgVehiculo.txtCapacidad.Text = dgTabla.CurrentRow.Cells[7].Value.ToString();
                    rgVehiculo.txtCombustible.Text = dgTabla.CurrentRow.Cells[8].Value.ToString();
                    rgVehiculo.txtPrecio.Text = dgTabla.CurrentRow.Cells[9].Value.ToString();
                    rgVehiculo.txtAnio.Text = dgTabla.CurrentRow.Cells[10].Value.ToString();
                    rgVehiculo.txtEstado.Text = dgTabla.CurrentRow.Cells[11].Value.ToString();
                    rgVehiculo.ShowDialog();
                    mostrarVehiculos();
                    
                }
                else
                {
                    MessageBox.Show("Debe seleccionar una fila");
                }
            }

            private void mostrarVehiculos()
            {
                vehiculo vh = new vehiculo();
                dgTabla.DataSource = vh.mostrarVehiculos();

            }

        private void VistaRegistro_Load(object sender, EventArgs e)
        {
            mostrarVehiculos();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            ReporteVehiculo rp = new ReporteVehiculo();
            rp.Show();
        }
    }
    }
