namespace DCosta
{
    partial class FrmAdministrador
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
            this.pnlMenuVertical = new System.Windows.Forms.Panel();
            this.lblNombreAdmin = new System.Windows.Forms.Label();
            this.pnlBarraMovimiento = new System.Windows.Forms.Panel();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnMenu = new System.Windows.Forms.PictureBox();
            this.btnActualizarProducto = new System.Windows.Forms.Button();
            this.btnEliminarProducto = new System.Windows.Forms.Button();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.btnActualizarRepartidor = new System.Windows.Forms.Button();
            this.btnEliminarRepartidor = new System.Windows.Forms.Button();
            this.btnAgregarRepartidor = new System.Windows.Forms.Button();
            this.pbDcostaLogo = new System.Windows.Forms.PictureBox();
            this.pbDcostaLogoAbajo = new System.Windows.Forms.PictureBox();
            this.pnlMenuVertical.SuspendLayout();
            this.pnlBarraMovimiento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDcostaLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDcostaLogoAbajo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenuVertical
            // 
            this.pnlMenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(3)))), ((int)(((byte)(16)))));
            this.pnlMenuVertical.Controls.Add(this.lblNombreAdmin);
            this.pnlMenuVertical.Controls.Add(this.btnActualizarProducto);
            this.pnlMenuVertical.Controls.Add(this.btnEliminarProducto);
            this.pnlMenuVertical.Controls.Add(this.btnAgregarProducto);
            this.pnlMenuVertical.Controls.Add(this.btnActualizarRepartidor);
            this.pnlMenuVertical.Controls.Add(this.btnEliminarRepartidor);
            this.pnlMenuVertical.Controls.Add(this.btnAgregarRepartidor);
            this.pnlMenuVertical.Controls.Add(this.pbDcostaLogo);
            this.pnlMenuVertical.Controls.Add(this.pbDcostaLogoAbajo);
            this.pnlMenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenuVertical.Location = new System.Drawing.Point(0, 0);
            this.pnlMenuVertical.Name = "pnlMenuVertical";
            this.pnlMenuVertical.Size = new System.Drawing.Size(270, 750);
            this.pnlMenuVertical.TabIndex = 0;
            // 
            // lblNombreAdmin
            // 
            this.lblNombreAdmin.AutoSize = true;
            this.lblNombreAdmin.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreAdmin.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblNombreAdmin.Location = new System.Drawing.Point(91, 219);
            this.lblNombreAdmin.Name = "lblNombreAdmin";
            this.lblNombreAdmin.Size = new System.Drawing.Size(69, 23);
            this.lblNombreAdmin.TabIndex = 9;
            this.lblNombreAdmin.Text = "label1";
            // 
            // pnlBarraMovimiento
            // 
            this.pnlBarraMovimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(184)))), ((int)(((byte)(0)))));
            this.pnlBarraMovimiento.Controls.Add(this.btnMaximizar);
            this.pnlBarraMovimiento.Controls.Add(this.btnRestaurar);
            this.pnlBarraMovimiento.Controls.Add(this.btnMinimizar);
            this.pnlBarraMovimiento.Controls.Add(this.btnCerrar);
            this.pnlBarraMovimiento.Controls.Add(this.btnMenu);
            this.pnlBarraMovimiento.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarraMovimiento.Location = new System.Drawing.Point(270, 0);
            this.pnlBarraMovimiento.Name = "pnlBarraMovimiento";
            this.pnlBarraMovimiento.Size = new System.Drawing.Size(830, 50);
            this.pnlBarraMovimiento.TabIndex = 1;
            this.pnlBarraMovimiento.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlBarraMovimiento_MouseDown);
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.BackgroundImage = global::DCosta.Properties.Resources.R;
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(270, 50);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(830, 700);
            this.pnlContenedor.TabIndex = 2;
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.Image = global::DCosta.Properties.Resources.maximizar__1_;
            this.btnMaximizar.Location = new System.Drawing.Point(772, 3);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(20, 20);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximizar.TabIndex = 14;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.Image = global::DCosta.Properties.Resources.restaurar_abajo__1_;
            this.btnRestaurar.Location = new System.Drawing.Point(772, 3);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(20, 20);
            this.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRestaurar.TabIndex = 13;
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.Visible = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Image = global::DCosta.Properties.Resources.pngwing_com__1_;
            this.btnMinimizar.Location = new System.Drawing.Point(746, 3);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(20, 20);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 12;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Image = global::DCosta.Properties.Resources.pngwing_com;
            this.btnCerrar.Location = new System.Drawing.Point(798, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(20, 20);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 11;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Image = global::DCosta.Properties.Resources.menu;
            this.btnMenu.Location = new System.Drawing.Point(6, 9);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(48, 35);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMenu.TabIndex = 0;
            this.btnMenu.TabStop = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnActualizarProducto
            // 
            this.btnActualizarProducto.FlatAppearance.BorderSize = 0;
            this.btnActualizarProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnActualizarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarProducto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarProducto.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnActualizarProducto.Image = global::DCosta.Properties.Resources.entrega;
            this.btnActualizarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizarProducto.Location = new System.Drawing.Point(-3, 572);
            this.btnActualizarProducto.Name = "btnActualizarProducto";
            this.btnActualizarProducto.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnActualizarProducto.Size = new System.Drawing.Size(270, 40);
            this.btnActualizarProducto.TabIndex = 8;
            this.btnActualizarProducto.Text = "Actualizar Producto";
            this.btnActualizarProducto.UseVisualStyleBackColor = true;
            this.btnActualizarProducto.Click += new System.EventHandler(this.btnActualizarProducto_Click);
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.FlatAppearance.BorderSize = 0;
            this.btnEliminarProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnEliminarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarProducto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarProducto.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEliminarProducto.Image = global::DCosta.Properties.Resources.controlar;
            this.btnEliminarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarProducto.Location = new System.Drawing.Point(0, 526);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnEliminarProducto.Size = new System.Drawing.Size(270, 40);
            this.btnEliminarProducto.TabIndex = 7;
            this.btnEliminarProducto.Text = "Eliminar Producto";
            this.btnEliminarProducto.UseVisualStyleBackColor = true;
            this.btnEliminarProducto.Click += new System.EventHandler(this.btnEliminarProducto_Click);
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.FlatAppearance.BorderSize = 0;
            this.btnAgregarProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnAgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarProducto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProducto.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAgregarProducto.Image = global::DCosta.Properties.Resources.nuevo_producto;
            this.btnAgregarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarProducto.Location = new System.Drawing.Point(0, 480);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnAgregarProducto.Size = new System.Drawing.Size(270, 40);
            this.btnAgregarProducto.TabIndex = 6;
            this.btnAgregarProducto.Text = "Agregar Producto";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // btnActualizarRepartidor
            // 
            this.btnActualizarRepartidor.FlatAppearance.BorderSize = 0;
            this.btnActualizarRepartidor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnActualizarRepartidor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarRepartidor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarRepartidor.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnActualizarRepartidor.Image = global::DCosta.Properties.Resources.mensajero;
            this.btnActualizarRepartidor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizarRepartidor.Location = new System.Drawing.Point(0, 388);
            this.btnActualizarRepartidor.Name = "btnActualizarRepartidor";
            this.btnActualizarRepartidor.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnActualizarRepartidor.Size = new System.Drawing.Size(270, 40);
            this.btnActualizarRepartidor.TabIndex = 4;
            this.btnActualizarRepartidor.Text = "Actualizar Repartidor";
            this.btnActualizarRepartidor.UseVisualStyleBackColor = true;
            this.btnActualizarRepartidor.Click += new System.EventHandler(this.btnActualizarRepartidor_Click);
            // 
            // btnEliminarRepartidor
            // 
            this.btnEliminarRepartidor.FlatAppearance.BorderSize = 0;
            this.btnEliminarRepartidor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnEliminarRepartidor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarRepartidor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarRepartidor.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEliminarRepartidor.Image = global::DCosta.Properties.Resources.repartidor__1_;
            this.btnEliminarRepartidor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarRepartidor.Location = new System.Drawing.Point(0, 342);
            this.btnEliminarRepartidor.Name = "btnEliminarRepartidor";
            this.btnEliminarRepartidor.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnEliminarRepartidor.Size = new System.Drawing.Size(270, 40);
            this.btnEliminarRepartidor.TabIndex = 3;
            this.btnEliminarRepartidor.Text = "Eliminar Repartidor";
            this.btnEliminarRepartidor.UseVisualStyleBackColor = true;
            this.btnEliminarRepartidor.Click += new System.EventHandler(this.btnEliminarRepartidor_Click);
            // 
            // btnAgregarRepartidor
            // 
            this.btnAgregarRepartidor.FlatAppearance.BorderSize = 0;
            this.btnAgregarRepartidor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnAgregarRepartidor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarRepartidor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarRepartidor.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAgregarRepartidor.Image = global::DCosta.Properties.Resources.repartidor;
            this.btnAgregarRepartidor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarRepartidor.Location = new System.Drawing.Point(0, 296);
            this.btnAgregarRepartidor.Name = "btnAgregarRepartidor";
            this.btnAgregarRepartidor.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnAgregarRepartidor.Size = new System.Drawing.Size(270, 40);
            this.btnAgregarRepartidor.TabIndex = 2;
            this.btnAgregarRepartidor.Text = "Agregar Repartidor";
            this.btnAgregarRepartidor.UseVisualStyleBackColor = true;
            this.btnAgregarRepartidor.Click += new System.EventHandler(this.btnAgregarRepartidor_Click);
            // 
            // pbDcostaLogo
            // 
            this.pbDcostaLogo.Image = global::DCosta.Properties.Resources.Logo_D_costa;
            this.pbDcostaLogo.Location = new System.Drawing.Point(0, 24);
            this.pbDcostaLogo.Name = "pbDcostaLogo";
            this.pbDcostaLogo.Size = new System.Drawing.Size(264, 126);
            this.pbDcostaLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDcostaLogo.TabIndex = 1;
            this.pbDcostaLogo.TabStop = false;
            // 
            // pbDcostaLogoAbajo
            // 
            this.pbDcostaLogoAbajo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pbDcostaLogoAbajo.Image = global::DCosta.Properties.Resources.Logo_D_costa;
            this.pbDcostaLogoAbajo.Location = new System.Drawing.Point(0, 700);
            this.pbDcostaLogoAbajo.Name = "pbDcostaLogoAbajo";
            this.pbDcostaLogoAbajo.Size = new System.Drawing.Size(60, 50);
            this.pbDcostaLogoAbajo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDcostaLogoAbajo.TabIndex = 0;
            this.pbDcostaLogoAbajo.TabStop = false;
            this.pbDcostaLogoAbajo.Visible = false;
            // 
            // FrmAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(1100, 750);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.pnlBarraMovimiento);
            this.Controls.Add(this.pnlMenuVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAdministrador";
            this.Text = "FrmProductos";
            this.pnlMenuVertical.ResumeLayout(false);
            this.pnlMenuVertical.PerformLayout();
            this.pnlBarraMovimiento.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDcostaLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDcostaLogoAbajo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenuVertical;
        private System.Windows.Forms.Panel pnlBarraMovimiento;
        private System.Windows.Forms.PictureBox btnMenu;
        private System.Windows.Forms.PictureBox pbDcostaLogo;
        private System.Windows.Forms.PictureBox pbDcostaLogoAbajo;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.PictureBox btnRestaurar;
        private System.Windows.Forms.Button btnActualizarProducto;
        private System.Windows.Forms.Button btnEliminarProducto;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.Button btnActualizarRepartidor;
        private System.Windows.Forms.Button btnEliminarRepartidor;
        private System.Windows.Forms.Button btnAgregarRepartidor;
        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.Label lblNombreAdmin;
    }
}