﻿using System;
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
    public partial class ReporteEntrega : Form
    {
        public ReporteEntrega()
        {
            InitializeComponent();
        }

        private void ReporteEntrega_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'yalexrentaDataSet4.entrega' Puede moverla o quitarla según sea necesario.
            this.entregaTableAdapter.Fill(this.yalexrentaDataSet4.entrega);

            this.reportViewer1.RefreshReport();
        }
    }
}
