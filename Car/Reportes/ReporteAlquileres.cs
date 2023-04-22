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

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
