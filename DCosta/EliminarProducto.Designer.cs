namespace DCosta
{
    partial class EliminarProducto
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscarCedulaRepartidor = new System.Windows.Forms.TextBox();
            this.btnBuscarRepartidor = new System.Windows.Forms.Button();
            this.btnEliminarRepartidor = new System.Windows.Forms.Button();
            this.lstProductos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del Producto:";
            // 
            // txtBuscarCedulaRepartidor
            // 
            this.txtBuscarCedulaRepartidor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarCedulaRepartidor.Location = new System.Drawing.Point(250, 42);
            this.txtBuscarCedulaRepartidor.Name = "txtBuscarCedulaRepartidor";
            this.txtBuscarCedulaRepartidor.Size = new System.Drawing.Size(227, 27);
            this.txtBuscarCedulaRepartidor.TabIndex = 1;
            // 
            // btnBuscarRepartidor
            // 
            this.btnBuscarRepartidor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarRepartidor.Location = new System.Drawing.Point(551, 39);
            this.btnBuscarRepartidor.Name = "btnBuscarRepartidor";
            this.btnBuscarRepartidor.Size = new System.Drawing.Size(108, 33);
            this.btnBuscarRepartidor.TabIndex = 2;
            this.btnBuscarRepartidor.Text = "Buscar";
            this.btnBuscarRepartidor.UseVisualStyleBackColor = true;
            // 
            // btnEliminarRepartidor
            // 
            this.btnEliminarRepartidor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarRepartidor.Location = new System.Drawing.Point(676, 636);
            this.btnEliminarRepartidor.Name = "btnEliminarRepartidor";
            this.btnEliminarRepartidor.Size = new System.Drawing.Size(121, 37);
            this.btnEliminarRepartidor.TabIndex = 3;
            this.btnEliminarRepartidor.Text = "Eliminar";
            this.btnEliminarRepartidor.UseVisualStyleBackColor = true;
            // 
            // lstProductos
            // 
            this.lstProductos.FormattingEnabled = true;
            this.lstProductos.Location = new System.Drawing.Point(54, 114);
            this.lstProductos.Name = "lstProductos";
            this.lstProductos.Size = new System.Drawing.Size(722, 472);
            this.lstProductos.TabIndex = 7;
            // 
            // FrmEliminarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(219)))), ((int)(((byte)(183)))));
            this.ClientSize = new System.Drawing.Size(830, 700);
            this.Controls.Add(this.lstProductos);
            this.Controls.Add(this.btnEliminarRepartidor);
            this.Controls.Add(this.btnBuscarRepartidor);
            this.Controls.Add(this.txtBuscarCedulaRepartidor);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEliminarProducto";
            this.Text = "FrmEliminarRepartidor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscarCedulaRepartidor;
        private System.Windows.Forms.Button btnBuscarRepartidor;
        private System.Windows.Forms.Button btnEliminarRepartidor;
        private System.Windows.Forms.ListBox lstProductos;
    }
}