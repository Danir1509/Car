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
    public partial class ReporteReserva : Form
    {
        public ReporteReserva()
        {
            InitializeComponent();
        }

        private void ReporteReserva_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'yalexrentaFinal.reserva' Puede moverla o quitarla según sea necesario.
            this.reservaTableAdapter.Fill(this.yalexrentaFinal.reserva);

            this.reportViewer1.RefreshReport();
        }
    }
}
