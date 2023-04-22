
namespace Car
{
    partial class Vista_registro_cliente_empleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vista_registro_cliente_empleado));
            this.panelcontenido = new System.Windows.Forms.Panel();
            this.lbltema = new System.Windows.Forms.Label();
            this.txtBuscador = new System.Windows.Forms.TextBox();
            this.dgregisclient = new System.Windows.Forms.DataGridView();
            this.panelvista2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnminimizar = new System.Windows.Forms.Button();
            this.btncerrar = new System.Windows.Forms.Button();
            this.panelcontenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgregisclient)).BeginInit();
            this.panelvista2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelcontenido
            // 
            this.panelcontenido.Controls.Add(this.lbltema);
            this.panelcontenido.Controls.Add(this.txtBuscador);
            this.panelcontenido.Controls.Add(this.dgregisclient);
            this.panelcontenido.Location = new System.Drawing.Point(13, 57);
            this.panelcontenido.Margin = new System.Windows.Forms.Padding(4);
            this.panelcontenido.Name = "panelcontenido";
            this.panelcontenido.Size = new System.Drawing.Size(1067, 511);
            this.panelcontenido.TabIndex = 6;
            // 
            // lbltema
            // 
            this.lbltema.AutoSize = true;
            this.lbltema.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltema.Location = new System.Drawing.Point(341, 47);
            this.lbltema.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltema.Name = "lbltema";
            this.lbltema.Size = new System.Drawing.Size(279, 25);
            this.lbltema.TabIndex = 5;
            this.lbltema.Text = "CLIENTES REGISTRADOS";
            // 
            // txtBuscador
            // 
            this.txtBuscador.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtBuscador.Location = new System.Drawing.Point(801, 67);
            this.txtBuscador.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscador.Name = "txtBuscador";
            this.txtBuscador.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtBuscador.Size = new System.Drawing.Size(216, 22);
            this.txtBuscador.TabIndex = 4;
            this.txtBuscador.Text = "Cliente";
            // 
            // dgregisclient
            // 
            this.dgregisclient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgregisclient.Location = new System.Drawing.Point(16, 110);
            this.dgregisclient.Margin = new System.Windows.Forms.Padding(4);
            this.dgregisclient.Name = "dgregisclient";
            this.dgregisclient.RowHeadersWidth = 51;
            this.dgregisclient.Size = new System.Drawing.Size(1001, 361);
            this.dgregisclient.TabIndex = 3;
            // 
            // panelvista2
            // 
            this.panelvista2.Controls.Add(this.button1);
            this.panelvista2.Controls.Add(this.btnminimizar);
            this.panelvista2.Controls.Add(this.btncerrar);
            this.panelvista2.Location = new System.Drawing.Point(13, 13);
            this.panelvista2.Margin = new System.Windows.Forms.Padding(4);
            this.panelvista2.Name = "panelvista2";
            this.panelvista2.Size = new System.Drawing.Size(1067, 36);
            this.panelvista2.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 36);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnminimizar
            // 
            this.btnminimizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnminimizar.FlatAppearance.BorderSize = 0;
            this.btnminimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnminimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnminimizar.Image")));
            this.btnminimizar.Location = new System.Drawing.Point(959, 0);
            this.btnminimizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnminimizar.Name = "btnminimizar";
            this.btnminimizar.Size = new System.Drawing.Size(59, 36);
            this.btnminimizar.TabIndex = 1;
            this.btnminimizar.UseVisualStyleBackColor = true;
            this.btnminimizar.Click += new System.EventHandler(this.btnminimizar_Click);
            // 
            // btncerrar
            // 
            this.btncerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btncerrar.FlatAppearance.BorderSize = 0;
            this.btncerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncerrar.Image = ((System.Drawing.Image)(resources.GetObject("btncerrar.Image")));
            this.btncerrar.Location = new System.Drawing.Point(1018, 0);
            this.btncerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(49, 36);
            this.btncerrar.TabIndex = 0;
            this.btncerrar.UseVisualStyleBackColor = true;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // Vista_registro_cliente_empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 576);
            this.Controls.Add(this.panelcontenido);
            this.Controls.Add(this.panelvista2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Vista_registro_cliente_empleado";
            this.Text = "Vista_registro_cliente_empleado";
            this.Load += new System.EventHandler(this.Vista_registro_cliente_empleado_Load);
            this.panelcontenido.ResumeLayout(false);
            this.panelcontenido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgregisclient)).EndInit();
            this.panelvista2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelcontenido;
        private System.Windows.Forms.Label lbltema;
        private System.Windows.Forms.TextBox txtBuscador;
        private System.Windows.Forms.DataGridView dgregisclient;
        private System.Windows.Forms.Panel panelvista2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnminimizar;
        private System.Windows.Forms.Button btncerrar;
    }
}