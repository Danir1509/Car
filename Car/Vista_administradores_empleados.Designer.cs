
namespace Car
{
    partial class Vista_administradores_empleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vista_administradores_empleados));
            this.panelcontenido = new System.Windows.Forms.Panel();
            this.lbltemaadmon = new System.Windows.Forms.Label();
            this.txtBuscadorempleados = new System.Windows.Forms.TextBox();
            this.dgadminemple = new System.Windows.Forms.DataGridView();
            this.panelvistaadmon = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnminimizar = new System.Windows.Forms.Button();
            this.btncerrar = new System.Windows.Forms.Button();
            this.panelcontenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgadminemple)).BeginInit();
            this.panelvistaadmon.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelcontenido
            // 
            this.panelcontenido.Controls.Add(this.lbltemaadmon);
            this.panelcontenido.Controls.Add(this.txtBuscadorempleados);
            this.panelcontenido.Controls.Add(this.dgadminemple);
            this.panelcontenido.Location = new System.Drawing.Point(16, 107);
            this.panelcontenido.Margin = new System.Windows.Forms.Padding(4);
            this.panelcontenido.Name = "panelcontenido";
            this.panelcontenido.Size = new System.Drawing.Size(1123, 513);
            this.panelcontenido.TabIndex = 7;
            // 
            // lbltemaadmon
            // 
            this.lbltemaadmon.AutoSize = true;
            this.lbltemaadmon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltemaadmon.Location = new System.Drawing.Point(283, 37);
            this.lbltemaadmon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltemaadmon.Name = "lbltemaadmon";
            this.lbltemaadmon.Size = new System.Drawing.Size(541, 25);
            this.lbltemaadmon.TabIndex = 5;
            this.lbltemaadmon.Text = "ADMINISTRADORES Y EMPLEADOS REGISTRADOS";
            // 
            // txtBuscadorempleados
            // 
            this.txtBuscadorempleados.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtBuscadorempleados.Location = new System.Drawing.Point(903, 100);
            this.txtBuscadorempleados.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscadorempleados.Name = "txtBuscadorempleados";
            this.txtBuscadorempleados.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtBuscadorempleados.Size = new System.Drawing.Size(216, 22);
            this.txtBuscadorempleados.TabIndex = 4;
            this.txtBuscadorempleados.Text = "Empleados";
            // 
            // dgadminemple
            // 
            this.dgadminemple.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgadminemple.Location = new System.Drawing.Point(0, 130);
            this.dgadminemple.Margin = new System.Windows.Forms.Padding(4);
            this.dgadminemple.Name = "dgadminemple";
            this.dgadminemple.RowHeadersWidth = 51;
            this.dgadminemple.Size = new System.Drawing.Size(1131, 378);
            this.dgadminemple.TabIndex = 3;
            // 
            // panelvistaadmon
            // 
            this.panelvistaadmon.Controls.Add(this.button1);
            this.panelvistaadmon.Controls.Add(this.btnminimizar);
            this.panelvistaadmon.Controls.Add(this.btncerrar);
            this.panelvistaadmon.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelvistaadmon.Location = new System.Drawing.Point(0, 0);
            this.panelvistaadmon.Margin = new System.Windows.Forms.Padding(4);
            this.panelvistaadmon.Name = "panelvistaadmon";
            this.panelvistaadmon.Size = new System.Drawing.Size(1154, 36);
            this.panelvistaadmon.TabIndex = 6;
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
            this.btnminimizar.Location = new System.Drawing.Point(1046, 0);
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
            this.btncerrar.Location = new System.Drawing.Point(1105, 0);
            this.btncerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(49, 36);
            this.btncerrar.TabIndex = 0;
            this.btncerrar.UseVisualStyleBackColor = true;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // Vista_administradores_empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 640);
            this.Controls.Add(this.panelcontenido);
            this.Controls.Add(this.panelvistaadmon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Vista_administradores_empleados";
            this.Text = "Vista_administradores_empleados";
            this.Load += new System.EventHandler(this.Vista_administradores_empleados_Load);
            this.panelcontenido.ResumeLayout(false);
            this.panelcontenido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgadminemple)).EndInit();
            this.panelvistaadmon.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelcontenido;
        private System.Windows.Forms.Label lbltemaadmon;
        private System.Windows.Forms.TextBox txtBuscadorempleados;
        private System.Windows.Forms.DataGridView dgadminemple;
        private System.Windows.Forms.Panel panelvistaadmon;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnminimizar;
        private System.Windows.Forms.Button btncerrar;
    }
}