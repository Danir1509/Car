
namespace Car
{
    partial class ConsulaAlquilerE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsulaAlquilerE));
            this.panelTituloConsultaAlquileres = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMinim = new System.Windows.Forms.Button();
            this.btnMaxi = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvAlquiler = new System.Windows.Forms.DataGridView();
            this.panelTituloConsultaAlquileres.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlquiler)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTituloConsultaAlquileres
            // 
            this.panelTituloConsultaAlquileres.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panelTituloConsultaAlquileres.Controls.Add(this.label2);
            this.panelTituloConsultaAlquileres.Controls.Add(this.btnMinim);
            this.panelTituloConsultaAlquileres.Controls.Add(this.btnMaxi);
            this.panelTituloConsultaAlquileres.Controls.Add(this.btnCerrar);
            this.panelTituloConsultaAlquileres.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTituloConsultaAlquileres.Location = new System.Drawing.Point(0, 0);
            this.panelTituloConsultaAlquileres.Margin = new System.Windows.Forms.Padding(4);
            this.panelTituloConsultaAlquileres.Name = "panelTituloConsultaAlquileres";
            this.panelTituloConsultaAlquileres.Size = new System.Drawing.Size(903, 34);
            this.panelTituloConsultaAlquileres.TabIndex = 69;
            this.panelTituloConsultaAlquileres.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTituloConsultaAlquileres_MouseMove);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 20);
            this.label2.TabIndex = 78;
            this.label2.Text = "Consulta Alquileres";
            // 
            // btnMinim
            // 
            this.btnMinim.BackColor = System.Drawing.Color.Transparent;
            this.btnMinim.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinim.FlatAppearance.BorderSize = 0;
            this.btnMinim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinim.Image = ((System.Drawing.Image)(resources.GetObject("btnMinim.Image")));
            this.btnMinim.Location = new System.Drawing.Point(729, 0);
            this.btnMinim.Margin = new System.Windows.Forms.Padding(4);
            this.btnMinim.Name = "btnMinim";
            this.btnMinim.Size = new System.Drawing.Size(63, 34);
            this.btnMinim.TabIndex = 7;
            this.btnMinim.UseVisualStyleBackColor = false;
            this.btnMinim.Click += new System.EventHandler(this.btnMinim_Click);
            // 
            // btnMaxi
            // 
            this.btnMaxi.BackColor = System.Drawing.Color.Transparent;
            this.btnMaxi.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaxi.FlatAppearance.BorderSize = 0;
            this.btnMaxi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaxi.Image = ((System.Drawing.Image)(resources.GetObject("btnMaxi.Image")));
            this.btnMaxi.Location = new System.Drawing.Point(792, 0);
            this.btnMaxi.Margin = new System.Windows.Forms.Padding(4);
            this.btnMaxi.Name = "btnMaxi";
            this.btnMaxi.Size = new System.Drawing.Size(59, 34);
            this.btnMaxi.TabIndex = 9;
            this.btnMaxi.UseVisualStyleBackColor = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(851, 0);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(52, 34);
            this.btnCerrar.TabIndex = 7;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(287, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 17);
            this.label1.TabIndex = 70;
            this.label1.Text = "Registros de Alquileres";
            // 
            // dgvAlquiler
            // 
            this.dgvAlquiler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlquiler.Location = new System.Drawing.Point(16, 166);
            this.dgvAlquiler.Name = "dgvAlquiler";
            this.dgvAlquiler.RowHeadersWidth = 51;
            this.dgvAlquiler.RowTemplate.Height = 24;
            this.dgvAlquiler.Size = new System.Drawing.Size(853, 424);
            this.dgvAlquiler.TabIndex = 71;
            // 
            // ConsulaAlquilerE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 621);
            this.Controls.Add(this.dgvAlquiler);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelTituloConsultaAlquileres);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsulaAlquilerE";
            this.Text = "ConsulaAlquilerE";
            this.Load += new System.EventHandler(this.ConsulaAlquilerE_Load);
            this.panelTituloConsultaAlquileres.ResumeLayout(false);
            this.panelTituloConsultaAlquileres.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlquiler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTituloConsultaAlquileres;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMinim;
        private System.Windows.Forms.Button btnMaxi;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvAlquiler;
    }
}