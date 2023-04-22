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
    public partial class ReporteVehiculo : Form
    {
        public ReporteVehiculo()
        {
            InitializeComponent();
        }

        private void ReporteVehiculo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'yalexrentaFinal.vehiculo' Puede moverla o quitarla según sea necesario.
            this.vehiculoTableAdapter.Fill(this.yalexrentaFinal.vehiculo);

            this.reportViewer1.RefreshReport();
        }
    }
}
