
namespace Car.Reportes
{
    partial class ReporteEntrega
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.yalexrentaDataSet4 = new Car.yalexrentaDataSet4();
            this.entregaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.entregaTableAdapter = new Car.yalexrentaDataSet4TableAdapters.entregaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.yalexrentaDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entregaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Entrega";
            reportDataSource1.Value = this.entregaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Car.Reportes.ReporteEntregas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1315, 725);
            this.reportViewer1.TabIndex = 0;
            // 
            // yalexrentaDataSet4
            // 
            this.yalexrentaDataSet4.DataSetName = "yalexrentaDataSet4";
            this.yalexrentaDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // entregaBindingSource
            // 
            this.entregaBindingSource.DataMember = "entrega";
            this.entregaBindingSource.DataSource = this.yalexrentaDataSet4;
            // 
            // entregaTableAdapter
            // 
            this.entregaTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteEntrega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1315, 725);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteEntrega";
            this.Text = "ReporteEntrega";
            this.Load += new System.EventHandler(this.ReporteEntrega_Load);
            ((System.ComponentModel.ISupportInitialize)(this.yalexrentaDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entregaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private yalexrentaDataSet4 yalexrentaDataSet4;
        private System.Windows.Forms.BindingSource entregaBindingSource;
        private yalexrentaDataSet4TableAdapters.entregaTableAdapter entregaTableAdapter;
    }
}