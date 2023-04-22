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
    public partial class ReporteContratoempleado : Form
    {
        public ReporteContratoempleado()
        {
            InitializeComponent();
        }

        private void ReporteContratoempleado_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'yalexrentaContratos.contratos' Puede moverla o quitarla según sea necesario.
            this.contratosTableAdapter.Fill(this.yalexrentaContratos.contratos);
            // TODO: esta línea de código carga datos en la tabla 'yalexrentaContratos.vehiculo' Puede moverla o quitarla según sea necesario.
            this.vehiculoTableAdapter.Fill(this.yalexrentaContratos.vehiculo);
            // TODO: esta línea de código carga datos en la tabla 'yalexrentaContratos.clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.Fill(this.yalexrentaContratos.clientes);
            // TODO: esta línea de código carga datos en la tabla 'yalexrentaContratos.alquileres' Puede moverla o quitarla según sea necesario.
            this.alquileresTableAdapter.Fill(this.yalexrentaContratos.alquileres);

            this.reportViewer1.RefreshReport();
        }
    }
}
