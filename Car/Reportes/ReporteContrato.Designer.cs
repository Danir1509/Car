﻿
namespace Car.Reportes
{
    partial class ReporteContrato
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
            this.contratosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yalexrentaContratos = new Car.yalexrentaContratos();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vehiculoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alquileresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.contratosTableAdapter = new Car.yalexrentaContratosTableAdapters.contratosTableAdapter();
            this.clientesTableAdapter = new Car.yalexrentaContratosTableAdapters.clientesTableAdapter();
            this.vehiculoTableAdapter = new Car.yalexrentaContratosTableAdapters.vehiculoTableAdapter();
            this.vehiculoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.yalexrentaContratosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alquileresTableAdapter = new Car.yalexrentaContratosTableAdapters.alquileresTableAdapter();
            this.yalexrentaFinal = new Car.yalexrentaFinal();
            this.contratosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.contratosTableAdapter1 = new Car.yalexrentaFinalTableAdapters.contratosTableAdapter();
            this.yalexrentaAlquileres = new Car.yalexrentaAlquileres();
            this.alquileresBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.alquileresTableAdapter1 = new Car.yalexrentaAlquileresTableAdapters.alquileresTableAdapter();
            this.contratosBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.contratosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yalexrentaContratos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alquileresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yalexrentaContratosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yalexrentaFinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contratosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yalexrentaAlquileres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alquileresBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contratosBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // contratosBindingSource
            // 
            this.contratosBindingSource.DataMember = "contratos";
            this.contratosBindingSource.DataSource = this.yalexrentaContratos;
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
            // alquileresBindingSource
            // 
            this.alquileresBindingSource.DataMember = "alquileres";
            this.alquileresBindingSource.DataSource = this.yalexrentaContratos;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Contratos";
            reportDataSource1.Value = this.contratosBindingSource;
            reportDataSource2.Name = "Clientes";
            reportDataSource2.Value = this.clientesBindingSource;
            reportDataSource3.Name = "Vehiculo";
            reportDataSource3.Value = this.vehiculoBindingSource;
            reportDataSource4.Name = "Alquileres";
            reportDataSource4.Value = this.alquileresBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Car.Reportes.ReporteContrato.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(950, 632);
            this.reportViewer1.TabIndex = 0;
            // 
            // contratosTableAdapter
            // 
            this.contratosTableAdapter.ClearBeforeFill = true;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // vehiculoTableAdapter
            // 
            this.vehiculoTableAdapter.ClearBeforeFill = true;
            // 
            // vehiculoBindingSource1
            // 
            this.vehiculoBindingSource1.DataMember = "vehiculo";
            this.vehiculoBindingSource1.DataSource = this.yalexrentaContratos;
            // 
            // yalexrentaContratosBindingSource
            // 
            this.yalexrentaContratosBindingSource.DataSource = this.yalexrentaContratos;
            this.yalexrentaContratosBindingSource.Position = 0;
            // 
            // alquileresTableAdapter
            // 
            this.alquileresTableAdapter.ClearBeforeFill = true;
            // 
            // yalexrentaFinal
            // 
            this.yalexrentaFinal.DataSetName = "yalexrentaFinal";
            this.yalexrentaFinal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contratosBindingSource1
            // 
            this.contratosBindingSource1.DataMember = "contratos";
            this.contratosBindingSource1.DataSource = this.yalexrentaFinal;
            // 
            // contratosTableAdapter1
            // 
            this.contratosTableAdapter1.ClearBeforeFill = true;
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
            // contratosBindingSource2
            // 
            this.contratosBindingSource2.DataMember = "contratos";
            this.contratosBindingSource2.DataSource = this.yalexrentaContratos;
            // 
            // ReporteContrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 632);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteContrato";
            this.Text = "ReporteContrato";
            this.Load += new System.EventHandler(this.ReporteContrato_Load);
            ((System.ComponentModel.ISupportInitialize)(this.contratosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yalexrentaContratos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alquileresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yalexrentaContratosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yalexrentaFinal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contratosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yalexrentaAlquileres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alquileresBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contratosBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private yalexrentaContratos yalexrentaContratos;
        private System.Windows.Forms.BindingSource contratosBindingSource;
        private yalexrentaContratosTableAdapters.contratosTableAdapter contratosTableAdapter;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private yalexrentaContratosTableAdapters.clientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.BindingSource vehiculoBindingSource;
        private yalexrentaContratosTableAdapters.vehiculoTableAdapter vehiculoTableAdapter;
        private System.Windows.Forms.BindingSource vehiculoBindingSource1;
        private System.Windows.Forms.BindingSource yalexrentaContratosBindingSource;
        private System.Windows.Forms.BindingSource alquileresBindingSource;
        private yalexrentaContratosTableAdapters.alquileresTableAdapter alquileresTableAdapter;
        private yalexrentaFinal yalexrentaFinal;
        private System.Windows.Forms.BindingSource contratosBindingSource1;
        private yalexrentaFinalTableAdapters.contratosTableAdapter contratosTableAdapter1;
        private yalexrentaAlquileres yalexrentaAlquileres;
        private System.Windows.Forms.BindingSource alquileresBindingSource1;
        private yalexrentaAlquileresTableAdapters.alquileresTableAdapter alquileresTableAdapter1;
        private System.Windows.Forms.BindingSource contratosBindingSource2;
    }
}