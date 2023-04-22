
namespace Car
{
    partial class ContratoEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContratoEmpleado));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.dgContratos = new System.Windows.Forms.DataGridView();
            this.lblBuscador = new System.Windows.Forms.Label();
            this.txtbusqueda = new System.Windows.Forms.TextBox();
            this.btnPdfContratoemple = new System.Windows.Forms.Button();
            this.lblContrato = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgContratos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnMinimizar);
            this.panel2.Controls.Add(this.btnCerrar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1122, 48);
            this.panel2.TabIndex = 100;
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(946, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(85, 48);
            this.btnMinimizar.TabIndex = 1;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1031, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(91, 48);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // dgContratos
            // 
            this.dgContratos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgContratos.Location = new System.Drawing.Point(12, 217);
            this.dgContratos.Name = "dgContratos";
            this.dgContratos.RowHeadersWidth = 51;
            this.dgContratos.RowTemplate.Height = 24;
            this.dgContratos.Size = new System.Drawing.Size(1063, 484);
            this.dgContratos.TabIndex = 91;
            // 
            // lblBuscador
            // 
            this.lblBuscador.AutoSize = true;
            this.lblBuscador.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscador.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblBuscador.Location = new System.Drawing.Point(250, 167);
            this.lblBuscador.Name = "lblBuscador";
            this.lblBuscador.Size = new System.Drawing.Size(85, 27);
            this.lblBuscador.TabIndex = 99;
            this.lblBuscador.Text = "Buscar:";
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.Location = new System.Drawing.Point(341, 172);
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.Size = new System.Drawing.Size(294, 22);
            this.txtbusqueda.TabIndex = 98;
            this.txtbusqueda.TextChanged += new System.EventHandler(this.txtbusqueda_TextChanged);
            // 
            // btnPdfContratoemple
            // 
            this.btnPdfContratoemple.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnPdfContratoemple.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPdfContratoemple.Font = new System.Drawing.Font("Berlin Sans FB Demi", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnPdfContratoemple.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnPdfContratoemple.Image = ((System.Drawing.Image)(resources.GetObject("btnPdfContratoemple.Image")));
            this.btnPdfContratoemple.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPdfContratoemple.Location = new System.Drawing.Point(12, 126);
            this.btnPdfContratoemple.Name = "btnPdfContratoemple";
            this.btnPdfContratoemple.Size = new System.Drawing.Size(116, 68);
            this.btnPdfContratoemple.TabIndex = 96;
            this.btnPdfContratoemple.Text = " PDF";
            this.btnPdfContratoemple.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPdfContratoemple.UseVisualStyleBackColor = false;
            this.btnPdfContratoemple.Click += new System.EventHandler(this.btnPdfContratoemple_Click);
            // 
            // lblContrato
            // 
            this.lblContrato.AutoSize = true;
            this.lblContrato.BackColor = System.Drawing.Color.Snow;
            this.lblContrato.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblContrato.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContrato.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblContrato.Location = new System.Drawing.Point(280, 80);
            this.lblContrato.Name = "lblContrato";
            this.lblContrato.Size = new System.Drawing.Size(340, 37);
            this.lblContrato.TabIndex = 92;
            this.lblContrato.Text = " Contratos Registrados";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(723, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(304, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 97;
            this.pictureBox1.TabStop = false;
            // 
            // ContratoEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 728);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgContratos);
            this.Controls.Add(this.lblBuscador);
            this.Controls.Add(this.txtbusqueda);
            this.Controls.Add(this.btnPdfContratoemple);
            this.Controls.Add(this.lblContrato);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ContratoEmpleado";
            this.Text = "ContratoEmpleado";
            this.Load += new System.EventHandler(this.ContratoEmpleado_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ContratoEmpleado_MouseMove);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgContratos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DataGridView dgContratos;
        private System.Windows.Forms.Label lblBuscador;
        private System.Windows.Forms.TextBox txtbusqueda;
        private System.Windows.Forms.Button btnPdfContratoemple;
        private System.Windows.Forms.Label lblContrato;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}