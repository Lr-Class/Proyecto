namespace DCosta
{
    partial class FrmPedidos
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPedidos));
            this.pnlArriba = new System.Windows.Forms.Panel();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.btnPedidoCarnicos = new System.Windows.Forms.Button();
            this.btnPedidoBebidas = new System.Windows.Forms.Button();
            this.btnPedidoComplementarios = new System.Windows.Forms.Button();
            this.btnPedidosGuardar = new System.Windows.Forms.Button();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.lblLine1 = new System.Windows.Forms.Label();
            this.lblLine2 = new System.Windows.Forms.Label();
            this.lblLine3 = new System.Windows.Forms.Label();
            this.pnlGuardarPedido = new System.Windows.Forms.Panel();
            this.pnlBebidas = new System.Windows.Forms.Panel();
            this.flpComplementarios = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.pnlArriba.SuspendLayout();
            this.pnlPrincipal.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlArriba
            // 
            this.pnlArriba.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(3)))), ((int)(((byte)(16)))));
            this.pnlArriba.Controls.Add(this.lblLine3);
            this.pnlArriba.Controls.Add(this.lblLine2);
            this.pnlArriba.Controls.Add(this.lblLine1);
            this.pnlArriba.Controls.Add(this.btnPedidosGuardar);
            this.pnlArriba.Controls.Add(this.btnPedidoComplementarios);
            this.pnlArriba.Controls.Add(this.btnPedidoBebidas);
            this.pnlArriba.Controls.Add(this.btnPedidoCarnicos);
            this.pnlArriba.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlArriba.Location = new System.Drawing.Point(5, 5);
            this.pnlArriba.Margin = new System.Windows.Forms.Padding(0);
            this.pnlArriba.Name = "pnlArriba";
            this.pnlArriba.Size = new System.Drawing.Size(1017, 150);
            this.pnlArriba.TabIndex = 0;
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(219)))), ((int)(((byte)(183)))));
            this.pnlPrincipal.Controls.Add(this.panel1);
            this.pnlPrincipal.Controls.Add(this.flpComplementarios);
            this.pnlPrincipal.Controls.Add(this.pnlBebidas);
            this.pnlPrincipal.Controls.Add(this.pnlGuardarPedido);
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrincipal.Location = new System.Drawing.Point(5, 155);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(1017, 509);
            this.pnlPrincipal.TabIndex = 1;
            // 
            // btnPedidoCarnicos
            // 
            this.btnPedidoCarnicos.BackColor = System.Drawing.Color.Transparent;
            this.btnPedidoCarnicos.FlatAppearance.BorderSize = 0;
            this.btnPedidoCarnicos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPedidoCarnicos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPedidoCarnicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPedidoCarnicos.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedidoCarnicos.ForeColor = System.Drawing.Color.White;
            this.btnPedidoCarnicos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPedidoCarnicos.ImageIndex = 0;
            this.btnPedidoCarnicos.ImageList = this.imageList;
            this.btnPedidoCarnicos.Location = new System.Drawing.Point(40, 22);
            this.btnPedidoCarnicos.Margin = new System.Windows.Forms.Padding(0);
            this.btnPedidoCarnicos.Name = "btnPedidoCarnicos";
            this.btnPedidoCarnicos.Size = new System.Drawing.Size(150, 104);
            this.btnPedidoCarnicos.TabIndex = 0;
            this.btnPedidoCarnicos.Text = "Carnicos";
            this.btnPedidoCarnicos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPedidoCarnicos.UseVisualStyleBackColor = false;
            // 
            // btnPedidoBebidas
            // 
            this.btnPedidoBebidas.BackColor = System.Drawing.Color.Transparent;
            this.btnPedidoBebidas.FlatAppearance.BorderSize = 0;
            this.btnPedidoBebidas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPedidoBebidas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPedidoBebidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPedidoBebidas.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedidoBebidas.ForeColor = System.Drawing.Color.White;
            this.btnPedidoBebidas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPedidoBebidas.ImageIndex = 0;
            this.btnPedidoBebidas.ImageList = this.imageList;
            this.btnPedidoBebidas.Location = new System.Drawing.Point(580, 22);
            this.btnPedidoBebidas.Margin = new System.Windows.Forms.Padding(0);
            this.btnPedidoBebidas.Name = "btnPedidoBebidas";
            this.btnPedidoBebidas.Size = new System.Drawing.Size(150, 104);
            this.btnPedidoBebidas.TabIndex = 1;
            this.btnPedidoBebidas.Text = "Bebidas";
            this.btnPedidoBebidas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPedidoBebidas.UseVisualStyleBackColor = false;
            // 
            // btnPedidoComplementarios
            // 
            this.btnPedidoComplementarios.BackColor = System.Drawing.Color.Transparent;
            this.btnPedidoComplementarios.FlatAppearance.BorderSize = 0;
            this.btnPedidoComplementarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPedidoComplementarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPedidoComplementarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPedidoComplementarios.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedidoComplementarios.ForeColor = System.Drawing.Color.White;
            this.btnPedidoComplementarios.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPedidoComplementarios.ImageIndex = 0;
            this.btnPedidoComplementarios.ImageList = this.imageList;
            this.btnPedidoComplementarios.Location = new System.Drawing.Point(290, 22);
            this.btnPedidoComplementarios.Margin = new System.Windows.Forms.Padding(0);
            this.btnPedidoComplementarios.Name = "btnPedidoComplementarios";
            this.btnPedidoComplementarios.Size = new System.Drawing.Size(190, 104);
            this.btnPedidoComplementarios.TabIndex = 2;
            this.btnPedidoComplementarios.Text = "Complementarios";
            this.btnPedidoComplementarios.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPedidoComplementarios.UseVisualStyleBackColor = false;
            // 
            // btnPedidosGuardar
            // 
            this.btnPedidosGuardar.BackColor = System.Drawing.Color.Transparent;
            this.btnPedidosGuardar.FlatAppearance.BorderSize = 0;
            this.btnPedidosGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPedidosGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPedidosGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPedidosGuardar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedidosGuardar.ForeColor = System.Drawing.Color.White;
            this.btnPedidosGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPedidosGuardar.ImageIndex = 0;
            this.btnPedidosGuardar.ImageList = this.imageList;
            this.btnPedidosGuardar.Location = new System.Drawing.Point(830, 22);
            this.btnPedidosGuardar.Margin = new System.Windows.Forms.Padding(0);
            this.btnPedidosGuardar.Name = "btnPedidosGuardar";
            this.btnPedidosGuardar.Size = new System.Drawing.Size(150, 104);
            this.btnPedidosGuardar.TabIndex = 3;
            this.btnPedidosGuardar.Text = "Guardar";
            this.btnPedidosGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPedidosGuardar.UseVisualStyleBackColor = false;
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "p1.png");
            this.imageList.Images.SetKeyName(1, "p2.png");
            this.imageList.Images.SetKeyName(2, "p3.png");
            // 
            // lblLine1
            // 
            this.lblLine1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.lblLine1.Location = new System.Drawing.Point(156, 50);
            this.lblLine1.Name = "lblLine1";
            this.lblLine1.Size = new System.Drawing.Size(191, 5);
            this.lblLine1.TabIndex = 4;
            // 
            // lblLine2
            // 
            this.lblLine2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.lblLine2.Location = new System.Drawing.Point(426, 50);
            this.lblLine2.Name = "lblLine2";
            this.lblLine2.Size = new System.Drawing.Size(191, 5);
            this.lblLine2.TabIndex = 5;
            // 
            // lblLine3
            // 
            this.lblLine3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.lblLine3.Location = new System.Drawing.Point(689, 50);
            this.lblLine3.Name = "lblLine3";
            this.lblLine3.Size = new System.Drawing.Size(180, 5);
            this.lblLine3.TabIndex = 6;
            // 
            // pnlGuardarPedido
            // 
            this.pnlGuardarPedido.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlGuardarPedido.Location = new System.Drawing.Point(1000, 0);
            this.pnlGuardarPedido.Margin = new System.Windows.Forms.Padding(0);
            this.pnlGuardarPedido.Name = "pnlGuardarPedido";
            this.pnlGuardarPedido.Size = new System.Drawing.Size(17, 509);
            this.pnlGuardarPedido.TabIndex = 0;
            // 
            // pnlBebidas
            // 
            this.pnlBebidas.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlBebidas.Location = new System.Drawing.Point(980, 0);
            this.pnlBebidas.Margin = new System.Windows.Forms.Padding(0);
            this.pnlBebidas.Name = "pnlBebidas";
            this.pnlBebidas.Size = new System.Drawing.Size(20, 509);
            this.pnlBebidas.TabIndex = 1;
            // 
            // flpComplementarios
            // 
            this.flpComplementarios.AutoScroll = true;
            this.flpComplementarios.Dock = System.Windows.Forms.DockStyle.Right;
            this.flpComplementarios.Location = new System.Drawing.Point(958, 0);
            this.flpComplementarios.Margin = new System.Windows.Forms.Padding(0);
            this.flpComplementarios.Name = "flpComplementarios";
            this.flpComplementarios.Size = new System.Drawing.Size(22, 509);
            this.flpComplementarios.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnMostrar);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(958, 509);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Producto:";
            // 
            // comboBox1
            // 
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Salchichas",
            "Butifarras",
            "Chorizos",
            "Jamon",
            "Mortadela",
            "Salchichones",
            "Hamburguesa",
            "Tocineta"});
            this.comboBox1.Location = new System.Drawing.Point(129, 15);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(156, 29);
            this.comboBox1.TabIndex = 1;
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnMostrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnMostrar.FlatAppearance.BorderSize = 10;
            this.btnMostrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.btnMostrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnMostrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.Location = new System.Drawing.Point(305, 15);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(93, 29);
            this.btnMostrar.TabIndex = 2;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = false;
            // 
            // FrmPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(1027, 669);
            this.Controls.Add(this.pnlPrincipal);
            this.Controls.Add(this.pnlArriba);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPedidos";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "FrmPedidos";
            this.pnlArriba.ResumeLayout(false);
            this.pnlPrincipal.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlArriba;
        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.Button btnPedidoCarnicos;
        private System.Windows.Forms.Button btnPedidosGuardar;
        private System.Windows.Forms.Button btnPedidoComplementarios;
        private System.Windows.Forms.Button btnPedidoBebidas;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.Label lblLine3;
        private System.Windows.Forms.Label lblLine2;
        private System.Windows.Forms.Label lblLine1;
        private System.Windows.Forms.Panel pnlBebidas;
        private System.Windows.Forms.Panel pnlGuardarPedido;
        private System.Windows.Forms.FlowLayoutPanel flpComplementarios;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
    }
}