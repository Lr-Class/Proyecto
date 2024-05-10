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
            this.pnlBarraMovimiento = new System.Windows.Forms.Panel();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnMenu = new System.Windows.Forms.PictureBox();
            this.btnProductoHamburguesa = new System.Windows.Forms.Button();
            this.btnProductoSalchichones = new System.Windows.Forms.Button();
            this.btnProductoMortadela = new System.Windows.Forms.Button();
            this.btnProductoChorizo = new System.Windows.Forms.Button();
            this.btnProductoButifarra = new System.Windows.Forms.Button();
            this.btnProductoSalchichas = new System.Windows.Forms.Button();
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
            this.pnlMenuVertical.Controls.Add(this.btnProductoHamburguesa);
            this.pnlMenuVertical.Controls.Add(this.btnProductoSalchichones);
            this.pnlMenuVertical.Controls.Add(this.btnProductoMortadela);
            this.pnlMenuVertical.Controls.Add(this.btnProductoChorizo);
            this.pnlMenuVertical.Controls.Add(this.btnProductoButifarra);
            this.pnlMenuVertical.Controls.Add(this.btnProductoSalchichas);
            this.pnlMenuVertical.Controls.Add(this.pbDcostaLogo);
            this.pnlMenuVertical.Controls.Add(this.pbDcostaLogoAbajo);
            this.pnlMenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenuVertical.Location = new System.Drawing.Point(0, 0);
            this.pnlMenuVertical.Name = "pnlMenuVertical";
            this.pnlMenuVertical.Size = new System.Drawing.Size(270, 750);
            this.pnlMenuVertical.TabIndex = 0;
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
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(270, 50);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(830, 700);
            this.pnlContenedor.TabIndex = 2;
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.btnMenu.Location = new System.Drawing.Point(6, 9);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(48, 35);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMenu.TabIndex = 0;
            this.btnMenu.TabStop = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnProductoHamburguesa
            // 
            this.btnProductoHamburguesa.FlatAppearance.BorderSize = 0;
            this.btnProductoHamburguesa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnProductoHamburguesa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductoHamburguesa.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductoHamburguesa.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnProductoHamburguesa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductoHamburguesa.Location = new System.Drawing.Point(-3, 509);
            this.btnProductoHamburguesa.Name = "btnProductoHamburguesa";
            this.btnProductoHamburguesa.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnProductoHamburguesa.Size = new System.Drawing.Size(270, 40);
            this.btnProductoHamburguesa.TabIndex = 8;
            this.btnProductoHamburguesa.Text = "Actualizar Producto";
            this.btnProductoHamburguesa.UseVisualStyleBackColor = true;
            // 
            // btnProductoSalchichones
            // 
            this.btnProductoSalchichones.FlatAppearance.BorderSize = 0;
            this.btnProductoSalchichones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnProductoSalchichones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductoSalchichones.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductoSalchichones.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnProductoSalchichones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductoSalchichones.Location = new System.Drawing.Point(0, 463);
            this.btnProductoSalchichones.Name = "btnProductoSalchichones";
            this.btnProductoSalchichones.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnProductoSalchichones.Size = new System.Drawing.Size(270, 40);
            this.btnProductoSalchichones.TabIndex = 7;
            this.btnProductoSalchichones.Text = "Eliminar Producto";
            this.btnProductoSalchichones.UseVisualStyleBackColor = true;
            // 
            // btnProductoMortadela
            // 
            this.btnProductoMortadela.FlatAppearance.BorderSize = 0;
            this.btnProductoMortadela.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnProductoMortadela.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductoMortadela.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductoMortadela.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnProductoMortadela.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductoMortadela.Location = new System.Drawing.Point(0, 417);
            this.btnProductoMortadela.Name = "btnProductoMortadela";
            this.btnProductoMortadela.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnProductoMortadela.Size = new System.Drawing.Size(270, 40);
            this.btnProductoMortadela.TabIndex = 6;
            this.btnProductoMortadela.Text = "Agregar Producto";
            this.btnProductoMortadela.UseVisualStyleBackColor = true;
            // 
            // btnProductoChorizo
            // 
            this.btnProductoChorizo.FlatAppearance.BorderSize = 0;
            this.btnProductoChorizo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnProductoChorizo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductoChorizo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductoChorizo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnProductoChorizo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductoChorizo.Location = new System.Drawing.Point(0, 325);
            this.btnProductoChorizo.Name = "btnProductoChorizo";
            this.btnProductoChorizo.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnProductoChorizo.Size = new System.Drawing.Size(270, 40);
            this.btnProductoChorizo.TabIndex = 4;
            this.btnProductoChorizo.Text = "Actualizar Repartidor";
            this.btnProductoChorizo.UseVisualStyleBackColor = true;
            // 
            // btnProductoButifarra
            // 
            this.btnProductoButifarra.FlatAppearance.BorderSize = 0;
            this.btnProductoButifarra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnProductoButifarra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductoButifarra.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductoButifarra.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnProductoButifarra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductoButifarra.Location = new System.Drawing.Point(0, 279);
            this.btnProductoButifarra.Name = "btnProductoButifarra";
            this.btnProductoButifarra.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnProductoButifarra.Size = new System.Drawing.Size(270, 40);
            this.btnProductoButifarra.TabIndex = 3;
            this.btnProductoButifarra.Text = "Eliminar Repartidor";
            this.btnProductoButifarra.UseVisualStyleBackColor = true;
            // 
            // btnProductoSalchichas
            // 
            this.btnProductoSalchichas.FlatAppearance.BorderSize = 0;
            this.btnProductoSalchichas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnProductoSalchichas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductoSalchichas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductoSalchichas.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnProductoSalchichas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductoSalchichas.Location = new System.Drawing.Point(0, 233);
            this.btnProductoSalchichas.Name = "btnProductoSalchichas";
            this.btnProductoSalchichas.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnProductoSalchichas.Size = new System.Drawing.Size(270, 40);
            this.btnProductoSalchichas.TabIndex = 2;
            this.btnProductoSalchichas.Text = "Agregar Repartidor";
            this.btnProductoSalchichas.UseVisualStyleBackColor = true;
            // 
            // pbDcostaLogo
            // 
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
        private System.Windows.Forms.Button btnProductoHamburguesa;
        private System.Windows.Forms.Button btnProductoSalchichones;
        private System.Windows.Forms.Button btnProductoMortadela;
        private System.Windows.Forms.Button btnProductoChorizo;
        private System.Windows.Forms.Button btnProductoButifarra;
        private System.Windows.Forms.Button btnProductoSalchichas;
        private System.Windows.Forms.Panel pnlContenedor;
    }
}