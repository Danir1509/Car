
namespace Car.Reportes
{
    partial class ReporteContratoempleado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.alquileresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yalexrentaContratos = new Car.yalexrentaContratos();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vehiculoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contratosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.alquileresTableAdapter = new Car.yalexrentaContratosTableAdapters.alquileresTableAdapter();
            this.clientesTableAdapter = new Car.yalexrentaContratosTableAdapters.clientesTableAdapter();
            this.vehiculoTableAdapter = new Car.yalexrentaContratosTableAdapters.vehiculoTableAdapter();
            this.contratosTableAdapter = new Car.yalexrentaContratosTableAdapters.contratosTableAdapter();
            this.yalexrentaAlquileres = new Car.yalexrentaAlquileres();
            this.alquileresBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.alquileresTableAdapter1 = new Car.yalexrentaAlquileresTableAdapters.alquileresTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.alquileresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yalexrentaContratos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contratosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yalexrentaAlquileres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alquileresBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // alquileresBindingSource
            // 
            this.alquileresBindingSource.DataMember = "alquileres";
            this.alquileresBindingSource.DataSource = this.yalexrentaContratos;
            // 
            // yalexrentaContratos
            // 
            this.yalexrentaContratos.DataSetName = "yalexrentaContratos";
            this.yalexrentaContratos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "clientes";
            this.clientesBindingSource.DataSource = this.yalexrentaContratos;
            // 
            // vehiculoBindingSource
            // 
            this.vehiculoBindingSource.DataMember = "vehiculo";
            this.vehiculoBindingSource.DataSource = this.yalexrentaContratos;
            // 
            // contratosBindingSource
            // 
            this.contratosBindingSource.DataMember = "contratos";
            this.contratosBindingSource.DataSource = this.yalexrentaContratos;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Alquileres";
            reportDataSource1.Value = this.alquileresBindingSource1;
            reportDataSource2.Name = "Clientes";
            reportDataSource2.Value = this.clientesBindingSource;
            reportDataSource3.Name = "Vehiculos";
            reportDataSource3.Value = this.vehiculoBindingSource;
            reportDataSource4.Name = "Contrato";
            reportDataSource4.Value = this.contratosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Car.Reportes.ReporteContratoempleado.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // alquileresTableAdapter
            // 
            this.alquileresTableAdapter.ClearBeforeFill = true;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // vehiculoTableAdapter
            // 
            this.vehiculoTableAdapter.ClearBeforeFill = true;
            // 
            // contratosTableAdapter
            // 
            this.contratosTableAdapter.ClearBeforeFill = true;
            // 
            // yalexrentaAlquileres
            // 
            this.yalexrentaAlquileres.DataSetName = "yalexrentaAlquileres";
            this.yalexrentaAlquileres.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // alquileresBindingSource1
            // 
            this.alquileresBindingSource1.DataMember = "alquileres";
            this.alquileresBindingSource1.DataSource = this.yalexrentaAlquileres;
            // 
            // alquileresTableAdapter1
            // 
            this.alquileresTableAdapter1.ClearBeforeFill = true;
            // 
            // ReporteContratoempleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteContratoempleado";
            this.Text = "ReporteContratoempleado";
            this.Load += new System.EventHandler(this.ReporteContratoempleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.alquileresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yalexrentaContratos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contratosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yalexrentaAlquileres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alquileresBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private yalexrentaContratos yalexrentaContratos;
        private System.Windows.Forms.BindingSource alquileresBindingSource;
        private yalexrentaContratosTableAdapters.alquileresTableAdapter alquileresTableAdapter;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private yalexrentaContratosTableAdapters.clientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.BindingSource vehiculoBindingSource;
        private yalexrentaContratosTableAdapters.vehiculoTableAdapter vehiculoTableAdapter;
        private System.Windows.Forms.BindingSource contratosBindingSource;
        private yalexrentaContratosTableAdapters.contratosTableAdapter contratosTableAdapter;
        private yalexrentaAlquileres yalexrentaAlquileres;
        private System.Windows.Forms.BindingSource alquileresBindingSource1;
        private yalexrentaAlquileresTableAdapters.alquileresTableAdapter alquileresTableAdapter1;
    }
}