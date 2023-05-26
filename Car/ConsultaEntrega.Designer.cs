
namespace Car
{
    partial class ConsultaEntrega
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaEntrega));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.dgEntrega = new System.Windows.Forms.DataGridView();
            this.lblBuscador = new System.Windows.Forms.Label();
            this.btnNuevaEntrega = new System.Windows.Forms.Button();
            this.btnEditarEntrega = new System.Windows.Forms.Button();
            this.txtbusqueda = new System.Windows.Forms.TextBox();
            this.lblContrato = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEliminarEntrega = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEntrega)).BeginInit();
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
            this.panel2.Size = new System.Drawing.Size(1460, 48);
            this.panel2.TabIndex = 99;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(1284, 0);
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
            this.btnCerrar.Location = new System.Drawing.Point(1369, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(91, 48);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // dgEntrega
            // 
            this.dgEntrega.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEntrega.Location = new System.Drawing.Point(4, 220);
            this.dgEntrega.Name = "dgEntrega";
            this.dgEntrega.RowHeadersWidth = 51;
            this.dgEntrega.RowTemplate.Height = 24;
            this.dgEntrega.Size = new System.Drawing.Size(1261, 454);
            this.dgEntrega.TabIndex = 91;
            // 
            // lblBuscador
            // 
            this.lblBuscador.AutoSize = true;
            this.lblBuscador.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscador.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblBuscador.Location = new System.Drawing.Point(714, 178);
            this.lblBuscador.Name = "lblBuscador";
            this.lblBuscador.Size = new System.Drawing.Size(85, 27);
            this.lblBuscador.TabIndex = 98;
            this.lblBuscador.Text = "Buscar:";
            // 
            // btnNuevaEntrega
            // 
            this.btnNuevaEntrega.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnNuevaEntrega.Font = new System.Drawing.Font("Berlin Sans FB Demi", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnNuevaEntrega.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnNuevaEntrega.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevaEntrega.Image")));
            this.btnNuevaEntrega.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevaEntrega.Location = new System.Drawing.Point(4, 141);
            this.btnNuevaEntrega.Name = "btnNuevaEntrega";
            this.btnNuevaEntrega.Size = new System.Drawing.Size(285, 64);
            this.btnNuevaEntrega.TabIndex = 93;
            this.btnNuevaEntrega.Text = "Nueva Entrega";
            this.btnNuevaEntrega.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevaEntrega.UseVisualStyleBackColor = false;
            this.btnNuevaEntrega.Click += new System.EventHandler(this.btnNuevaEntrega_Click);
            // 
            // btnEditarEntrega
            // 
            this.btnEditarEntrega.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnEditarEntrega.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEditarEntrega.Font = new System.Drawing.Font("Berlin Sans FB Demi", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnEditarEntrega.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnEditarEntrega.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarEntrega.Image")));
            this.btnEditarEntrega.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarEntrega.Location = new System.Drawing.Point(1272, 220);
            this.btnEditarEntrega.Name = "btnEditarEntrega";
            this.btnEditarEntrega.Size = new System.Drawing.Size(164, 57);
            this.btnEditarEntrega.TabIndex = 94;
            this.btnEditarEntrega.Text = "Editar";
            this.btnEditarEntrega.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarEntrega.UseVisualStyleBackColor = false;
            this.btnEditarEntrega.Click += new System.EventHandler(this.btnEditarEntrega_Click);
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.Location = new System.Drawing.Point(805, 183);
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.Size = new System.Drawing.Size(294, 22);
            this.txtbusqueda.TabIndex = 97;
            // 
            // lblContrato
            // 
            this.lblContrato.AutoSize = true;
            this.lblContrato.BackColor = System.Drawing.Color.Snow;
            this.lblContrato.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblContrato.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContrato.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblContrato.Location = new System.Drawing.Point(459, 97);
            this.lblContrato.Name = "lblContrato";
            this.lblContrato.Size = new System.Drawing.Size(314, 37);
            this.lblContrato.TabIndex = 92;
            this.lblContrato.Text = "Entregas Registradas";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1144, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(304, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 96;
            this.pictureBox1.TabStop = false;
            // 
            // btnEliminarEntrega
            // 
            this.btnEliminarEntrega.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnEliminarEntrega.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEliminarEntrega.Font = new System.Drawing.Font("Berlin Sans FB Demi", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnEliminarEntrega.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnEliminarEntrega.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarEntrega.Image")));
            this.btnEliminarEntrega.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarEntrega.Location = new System.Drawing.Point(1272, 283);
            this.btnEliminarEntrega.Name = "btnEliminarEntrega";
            this.btnEliminarEntrega.Size = new System.Drawing.Size(164, 55);
            this.btnEliminarEntrega.TabIndex = 95;
            this.btnEliminarEntrega.Text = "Eliminar";
            this.btnEliminarEntrega.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarEntrega.UseVisualStyleBackColor = false;
            this.btnEliminarEntrega.Click += new System.EventHandler(this.btnEliminarEntrega_Click);
            // 
            // ConsultaEntrega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1460, 721);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgEntrega);
            this.Controls.Add(this.lblBuscador);
            this.Controls.Add(this.btnNuevaEntrega);
            this.Controls.Add(this.btnEditarEntrega);
            this.Controls.Add(this.txtbusqueda);
            this.Controls.Add(this.lblContrato);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnEliminarEntrega);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsultaEntrega";
            this.Text = "ConsultaEntrega";
            this.Load += new System.EventHandler(this.ConsultaEntrega_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgEntrega)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DataGridView dgEntrega;
        private System.Windows.Forms.Label lblBuscador;
        private System.Windows.Forms.Button btnNuevaEntrega;
        private System.Windows.Forms.Button btnEditarEntrega;
        private System.Windows.Forms.TextBox txtbusqueda;
        private System.Windows.Forms.Label lblContrato;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnEliminarEntrega;
    }
}