
namespace Car
{
    partial class vista_registro_cliente_admon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(vista_registro_cliente_admon));
            this.panelcontenido = new System.Windows.Forms.Panel();
            this.lbltema = new System.Windows.Forms.Label();
            this.txtBuscador = new System.Windows.Forms.TextBox();
            this.dgclientes = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevoCliente = new System.Windows.Forms.Button();
            this.panelvista2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnminimizar = new System.Windows.Forms.Button();
            this.btncerrar = new System.Windows.Forms.Button();
            this.panelcontenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgclientes)).BeginInit();
            this.panelvista2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelcontenido
            // 
            this.panelcontenido.Controls.Add(this.lbltema);
            this.panelcontenido.Controls.Add(this.txtBuscador);
            this.panelcontenido.Controls.Add(this.dgclientes);
            this.panelcontenido.Controls.Add(this.btnEliminar);
            this.panelcontenido.Controls.Add(this.btnEditar);
            this.panelcontenido.Controls.Add(this.btnNuevoCliente);
            this.panelcontenido.Location = new System.Drawing.Point(16, 127);
            this.panelcontenido.Margin = new System.Windows.Forms.Padding(4);
            this.panelcontenido.Name = "panelcontenido";
            this.panelcontenido.Size = new System.Drawing.Size(1096, 496);
            this.panelcontenido.TabIndex = 5;
            // 
            // lbltema
            // 
            this.lbltema.AutoSize = true;
            this.lbltema.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltema.Location = new System.Drawing.Point(217, 28);
            this.lbltema.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltema.Name = "lbltema";
            this.lbltema.Size = new System.Drawing.Size(279, 25);
            this.lbltema.TabIndex = 5;
            this.lbltema.Text = "CLIENTES REGISTRADOS";
            // 
            // txtBuscador
            // 
            this.txtBuscador.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtBuscador.Location = new System.Drawing.Point(548, 31);
            this.txtBuscador.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscador.Name = "txtBuscador";
            this.txtBuscador.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtBuscador.Size = new System.Drawing.Size(216, 22);
            this.txtBuscador.TabIndex = 4;
            this.txtBuscador.Text = "Cliente";
            // 
            // dgclientes
            // 
            this.dgclientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgclientes.Location = new System.Drawing.Point(16, 71);
            this.dgclientes.Margin = new System.Windows.Forms.Padding(4);
            this.dgclientes.Name = "dgclientes";
            this.dgclientes.RowHeadersWidth = 51;
            this.dgclientes.Size = new System.Drawing.Size(972, 357);
            this.dgclientes.TabIndex = 3;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Blue;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(992, 121);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 43);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Blue;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(992, 71);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(100, 42);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevoCliente
            // 
            this.btnNuevoCliente.BackColor = System.Drawing.Color.Blue;
            this.btnNuevoCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoCliente.ForeColor = System.Drawing.Color.White;
            this.btnNuevoCliente.Location = new System.Drawing.Point(16, 23);
            this.btnNuevoCliente.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevoCliente.Name = "btnNuevoCliente";
            this.btnNuevoCliente.Size = new System.Drawing.Size(179, 41);
            this.btnNuevoCliente.TabIndex = 0;
            this.btnNuevoCliente.Text = "+ Nuevo Cliente";
            this.btnNuevoCliente.UseMnemonic = false;
            this.btnNuevoCliente.UseVisualStyleBackColor = false;
            this.btnNuevoCliente.Click += new System.EventHandler(this.btnNuevoCliente_Click);
            // 
            // panelvista2
            // 
            this.panelvista2.Controls.Add(this.button1);
            this.panelvista2.Controls.Add(this.btnminimizar);
            this.panelvista2.Controls.Add(this.btncerrar);
            this.panelvista2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelvista2.Location = new System.Drawing.Point(0, 0);
            this.panelvista2.Margin = new System.Windows.Forms.Padding(4);
            this.panelvista2.Name = "panelvista2";
            this.panelvista2.Size = new System.Drawing.Size(1121, 36);
            this.panelvista2.TabIndex = 4;
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
            this.btnminimizar.Location = new System.Drawing.Point(1013, 0);
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
            this.btncerrar.Location = new System.Drawing.Point(1072, 0);
            this.btncerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(49, 36);
            this.btncerrar.TabIndex = 0;
            this.btncerrar.UseVisualStyleBackColor = true;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // vista_registro_cliente_admon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 636);
            this.Controls.Add(this.panelcontenido);
            this.Controls.Add(this.panelvista2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "vista_registro_cliente_admon";
            this.Text = "vista_registro_cliente_admon";
            this.Load += new System.EventHandler(this.form2_Load);
            this.panelcontenido.ResumeLayout(false);
            this.panelcontenido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgclientes)).EndInit();
            this.panelvista2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelcontenido;
        private System.Windows.Forms.Label lbltema;
        private System.Windows.Forms.TextBox txtBuscador;
        private System.Windows.Forms.DataGridView dgclientes;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevoCliente;
        private System.Windows.Forms.Panel panelvista2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnminimizar;
        private System.Windows.Forms.Button btncerrar;
    }
}