using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car.Reportes
{
    public partial class ReporteAlquileres : Form
    {
        public ReporteAlquileres()
        {
            InitializeComponent();
        }

        private void ReporteAlquileres_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'yalexrentaFinal.contratos' Puede moverla o quitarla según sea necesario.
            this.contratosTableAdapter.Fill(this.yalexrentaFinal.contratos);
            // TODO: esta línea de código carga datos en la tabla 'yalexrentaFinal.vehiculo' Puede moverla o quitarla según sea necesario.
            this.vehiculoTableAdapter.Fill(this.yalexrentaFinal.vehiculo);
            // TODO: esta línea de código carga datos en la tabla 'yalexrentaFinal.clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.Fill(this.yalexrentaFinal.clientes);
            // TODO: esta línea de código carga datos en la tabla 'yalexrentaFinal.alquileres' Puede moverla o quitarla según sea necesario.
            this.alquileresTableAdapter.Fill(this.yalexrentaFinal.alquileres);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
