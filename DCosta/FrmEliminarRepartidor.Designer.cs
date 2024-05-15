namespace DCosta
{
    partial class FrmEliminarRepartidor
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
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.btnEliminarRepartidor = new System.Windows.Forms.Button();
            this.lstRepartidores = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Documento del Repartidor:";
            // 
            // txtBuscarCedulaRepartidor
            // 
            this.txtBuscarCedulaRepartidor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarCedulaRepartidor.Location = new System.Drawing.Point(298, 42);
            this.txtBuscarCedulaRepartidor.Name = "txtBuscarCedulaRepartidor";
            this.txtBuscarCedulaRepartidor.Size = new System.Drawing.Size(231, 27);
            this.txtBuscarCedulaRepartidor.TabIndex = 1;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.Location = new System.Drawing.Point(573, 39);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(108, 33);
            this.btnFiltrar.TabIndex = 4;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            // 
            // btnEliminarRepartidor
            // 
            this.btnEliminarRepartidor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarRepartidor.Location = new System.Drawing.Point(657, 629);
            this.btnEliminarRepartidor.Name = "btnEliminarRepartidor";
            this.btnEliminarRepartidor.Size = new System.Drawing.Size(130, 39);
            this.btnEliminarRepartidor.TabIndex = 5;
            this.btnEliminarRepartidor.Text = "Eliminar";
            this.btnEliminarRepartidor.UseVisualStyleBackColor = true;
            // 
            // lstRepartidores
            // 
            this.lstRepartidores.FormattingEnabled = true;
            this.lstRepartidores.Location = new System.Drawing.Point(48, 121);
            this.lstRepartidores.Name = "lstRepartidores";
            this.lstRepartidores.Size = new System.Drawing.Size(722, 472);
            this.lstRepartidores.TabIndex = 6;
            // 
            // FrmEliminarRepartidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(219)))), ((int)(((byte)(183)))));
            this.ClientSize = new System.Drawing.Size(830, 700);
            this.Controls.Add(this.lstRepartidores);
            this.Controls.Add(this.btnEliminarRepartidor);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.txtBuscarCedulaRepartidor);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEliminarRepartidor";
            this.Text = "FrmEliminarRepartidor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscarCedulaRepartidor;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Button btnEliminarRepartidor;
        private System.Windows.Forms.ListBox lstRepartidores;
    }
}