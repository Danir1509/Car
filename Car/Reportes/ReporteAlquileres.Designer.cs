
namespace Car.Reportes
{
    partial class ReporteAlquileres
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
            this.yalexrentaFinal = new Car.yalexrentaFinal();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vehiculoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contratosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alquileresTableAdapter = new Car.yalexrentaFinalTableAdapters.alquileresTableAdapter();
            this.clientesTableAdapter = new Car.yalexrentaFinalTableAdapters.clientesTableAdapter();
            this.vehiculoTableAdapter = new Car.yalexrentaFinalTableAdapters.vehiculoTableAdapter();
            this.contratosTableAdapter = new Car.yalexrentaFinalTableAdapters.contratosTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.alquileresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yalexrentaFinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contratosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // alquileresBindingSource
            // 
            this.alquileresBindingSource.DataMember = "alquileres";
            this.alquileresBindingSource.DataSource = this.yalexrentaFinal;
            // 
            // yalexrentaFinal
            // 
            this.yalexrentaFinal.DataSetName = "yalexrentaFinal";
            this.yalexrentaFinal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "clientes";
            this.clientesBindingSource.DataSource = this.yalexrentaFinal;
            // 
            // vehiculoBindingSource
            // 
            this.vehiculoBindingSource.DataMember = "vehiculo";
            this.vehiculoBindingSource.DataSource = this.yalexrentaFinal;
            // 
            // contratosBindingSource
            // 
            this.contratosBindingSource.DataMember = "contratos";
            this.contratosBindingSource.DataSource = this.yalexrentaFinal;
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
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "alquileres";
            reportDataSource1.Value = this.alquileresBindingSource;
            reportDataSource2.Name = "clientes";
            reportDataSource2.Value = this.clientesBindingSource;
            reportDataSource3.Name = "vehiculo";
            reportDataSource3.Value = this.vehiculoBindingSource;
            reportDataSource4.Name = "contratos";
            reportDataSource4.Value = this.contratosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Car.Reportes.ReporteAlquileres.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // ReporteAlquileres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteAlquileres";
            this.Text = "ReporteAlquileres";
            this.Load += new System.EventHandler(this.ReporteAlquileres_Load);
            ((System.ComponentModel.ISupportInitialize)(this.alquileresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yalexrentaFinal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contratosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private yalexrentaFinal yalexrentaFinal;
        private System.Windows.Forms.BindingSource alquileresBindingSource;
        private yalexrentaFinalTableAdapters.alquileresTableAdapter alquileresTableAdapter;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private yalexrentaFinalTableAdapters.clientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.BindingSource vehiculoBindingSource;
        private yalexrentaFinalTableAdapters.vehiculoTableAdapter vehiculoTableAdapter;
        private System.Windows.Forms.BindingSource contratosBindingSource;
        private yalexrentaFinalTableAdapters.contratosTableAdapter contratosTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}