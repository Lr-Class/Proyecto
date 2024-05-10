namespace DCosta
{
    partial class FrmInicioCliente
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
            this.pnlBarraMovimiento = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnVerProductos = new System.Windows.Forms.PictureBox();
            this.btnHacerPedidos = new System.Windows.Forms.PictureBox();
            this.pnlBarraMovimiento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnVerProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHacerPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBarraMovimiento
            // 
            this.pnlBarraMovimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(3)))), ((int)(((byte)(16)))));
            this.pnlBarraMovimiento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlBarraMovimiento.Controls.Add(this.btnMinimizar);
            this.pnlBarraMovimiento.Controls.Add(this.btnCerrar);
            this.pnlBarraMovimiento.Controls.Add(this.lblNombreUsuario);
            this.pnlBarraMovimiento.Controls.Add(this.pictureBox3);
            this.pnlBarraMovimiento.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarraMovimiento.Location = new System.Drawing.Point(4, 4);
            this.pnlBarraMovimiento.Name = "pnlBarraMovimiento";
            this.pnlBarraMovimiento.Size = new System.Drawing.Size(542, 99);
            this.pnlBarraMovimiento.TabIndex = 0;
            this.pnlBarraMovimiento.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlBarraMovimiento_MouseDown);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Image = global::DCosta.Properties.Resources.restar;
            this.btnMinimizar.Location = new System.Drawing.Point(486, 3);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(20, 20);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 10;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Image = global::DCosta.Properties.Resources.boton_x;
            this.btnCerrar.Location = new System.Drawing.Point(512, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(20, 20);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 9;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUsuario.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblNombreUsuario.Location = new System.Drawing.Point(190, 35);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(74, 24);
            this.lblNombreUsuario.TabIndex = 5;
            this.lblNombreUsuario.Text = "label1";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::DCosta.Properties.Resources.usuario;
            this.pictureBox3.Location = new System.Drawing.Point(55, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(115, 93);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::DCosta.Properties.Resources.R;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnVerProductos);
            this.panel2.Controls.Add(this.btnHacerPedidos);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(4, 103);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(40, 20, 40, 20);
            this.panel2.Size = new System.Drawing.Size(542, 247);
            this.panel2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(0)))), ((int)(((byte)(8)))));
            this.label3.Location = new System.Drawing.Point(314, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "↑ Ver Productos ↑";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(0)))), ((int)(((byte)(8)))));
            this.label2.Location = new System.Drawing.Point(51, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "↑ Hacer Pedido ↑";
            // 
            // btnVerProductos
            // 
            this.btnVerProductos.BackColor = System.Drawing.Color.Transparent;
            this.btnVerProductos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnVerProductos.Image = global::DCosta.Properties.Resources.embutidos;
            this.btnVerProductos.Location = new System.Drawing.Point(299, 23);
            this.btnVerProductos.Name = "btnVerProductos";
            this.btnVerProductos.Size = new System.Drawing.Size(200, 163);
            this.btnVerProductos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnVerProductos.TabIndex = 1;
            this.btnVerProductos.TabStop = false;
            this.btnVerProductos.Click += new System.EventHandler(this.btnVerProductos_Click);
            // 
            // btnHacerPedidos
            // 
            this.btnHacerPedidos.BackColor = System.Drawing.Color.Transparent;
            this.btnHacerPedidos.Image = global::DCosta.Properties.Resources.telefono_inteligente;
            this.btnHacerPedidos.Location = new System.Drawing.Point(43, 23);
            this.btnHacerPedidos.Name = "btnHacerPedidos";
            this.btnHacerPedidos.Size = new System.Drawing.Size(200, 163);
            this.btnHacerPedidos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHacerPedidos.TabIndex = 0;
            this.btnHacerPedidos.TabStop = false;
            this.btnHacerPedidos.Click += new System.EventHandler(this.btnHacerPedidos_Click);
            // 
            // FrmInicioCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(550, 354);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlBarraMovimiento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmInicioCliente";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmInicioCliente";
            this.pnlBarraMovimiento.ResumeLayout(false);
            this.pnlBarraMovimiento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnVerProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHacerPedidos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBarraMovimiento;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox btnVerProductos;
        private System.Windows.Forms.PictureBox btnHacerPedidos;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnCerrar;
    }
}