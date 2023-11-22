namespace SistemaPuntoVenta_Venecia
{
    partial class FormAdmin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
            this.MenStripUser = new System.Windows.Forms.MenuStrip();
            this.IMenItemUsuarios = new FontAwesome.Sharp.IconMenuItem();
            this.IMenItemMantenimiento = new FontAwesome.Sharp.IconMenuItem();
            this.IMenItemVentas = new FontAwesome.Sharp.IconMenuItem();
            this.IMenItemCompras = new FontAwesome.Sharp.IconMenuItem();
            this.IMenItemClientes = new FontAwesome.Sharp.IconMenuItem();
            this.IMenItemProveedores = new FontAwesome.Sharp.IconMenuItem();
            this.IMenItemReportes = new FontAwesome.Sharp.IconMenuItem();
            this.IMenItemAcercaDe = new FontAwesome.Sharp.IconMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenStripTitulo = new System.Windows.Forms.MenuStrip();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MenStripUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MenStripUser
            // 
            this.MenStripUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.MenStripUser.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenStripUser.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.IMenItemUsuarios,
            this.IMenItemMantenimiento,
            this.IMenItemVentas,
            this.IMenItemCompras,
            this.IMenItemClientes,
            this.IMenItemProveedores,
            this.IMenItemReportes,
            this.IMenItemAcercaDe,
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.MenStripUser.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.MenStripUser.Location = new System.Drawing.Point(0, 48);
            this.MenStripUser.Name = "MenStripUser";
            this.MenStripUser.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.MenStripUser.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.MenStripUser.Size = new System.Drawing.Size(1234, 84);
            this.MenStripUser.TabIndex = 0;
            this.MenStripUser.Text = "menuStrip1";
            this.MenStripUser.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenStripUser_ItemClicked);
            // 
            // IMenItemUsuarios
            // 
            this.IMenItemUsuarios.AutoSize = false;
            this.IMenItemUsuarios.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IMenItemUsuarios.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.IMenItemUsuarios.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            this.IMenItemUsuarios.IconColor = System.Drawing.SystemColors.MenuHighlight;
            this.IMenItemUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IMenItemUsuarios.IconSize = 50;
            this.IMenItemUsuarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.IMenItemUsuarios.Name = "IMenItemUsuarios";
            this.IMenItemUsuarios.Size = new System.Drawing.Size(150, 80);
            this.IMenItemUsuarios.Text = "USUARIOS";
            this.IMenItemUsuarios.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.IMenItemUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // IMenItemMantenimiento
            // 
            this.IMenItemMantenimiento.AutoSize = false;
            this.IMenItemMantenimiento.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IMenItemMantenimiento.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.IMenItemMantenimiento.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.IMenItemMantenimiento.IconColor = System.Drawing.SystemColors.MenuHighlight;
            this.IMenItemMantenimiento.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IMenItemMantenimiento.IconSize = 50;
            this.IMenItemMantenimiento.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.IMenItemMantenimiento.Name = "IMenItemMantenimiento";
            this.IMenItemMantenimiento.Size = new System.Drawing.Size(150, 80);
            this.IMenItemMantenimiento.Text = "MANTENIMIENTO";
            this.IMenItemMantenimiento.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.IMenItemMantenimiento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // IMenItemVentas
            // 
            this.IMenItemVentas.AutoSize = false;
            this.IMenItemVentas.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IMenItemVentas.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.IMenItemVentas.IconChar = FontAwesome.Sharp.IconChar.Tags;
            this.IMenItemVentas.IconColor = System.Drawing.SystemColors.MenuHighlight;
            this.IMenItemVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IMenItemVentas.IconSize = 50;
            this.IMenItemVentas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.IMenItemVentas.Name = "IMenItemVentas";
            this.IMenItemVentas.Size = new System.Drawing.Size(150, 80);
            this.IMenItemVentas.Text = "VENTAS";
            this.IMenItemVentas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.IMenItemVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // IMenItemCompras
            // 
            this.IMenItemCompras.AutoSize = false;
            this.IMenItemCompras.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IMenItemCompras.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.IMenItemCompras.IconChar = FontAwesome.Sharp.IconChar.DollyFlatbed;
            this.IMenItemCompras.IconColor = System.Drawing.SystemColors.MenuHighlight;
            this.IMenItemCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IMenItemCompras.IconSize = 50;
            this.IMenItemCompras.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.IMenItemCompras.Name = "IMenItemCompras";
            this.IMenItemCompras.Size = new System.Drawing.Size(150, 80);
            this.IMenItemCompras.Text = "COMPRAS";
            this.IMenItemCompras.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.IMenItemCompras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // IMenItemClientes
            // 
            this.IMenItemClientes.AutoSize = false;
            this.IMenItemClientes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IMenItemClientes.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.IMenItemClientes.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            this.IMenItemClientes.IconColor = System.Drawing.SystemColors.MenuHighlight;
            this.IMenItemClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IMenItemClientes.IconSize = 50;
            this.IMenItemClientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.IMenItemClientes.Name = "IMenItemClientes";
            this.IMenItemClientes.Size = new System.Drawing.Size(122, 80);
            this.IMenItemClientes.Text = "CLIENTES";
            this.IMenItemClientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.IMenItemClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // IMenItemProveedores
            // 
            this.IMenItemProveedores.AutoSize = false;
            this.IMenItemProveedores.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IMenItemProveedores.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.IMenItemProveedores.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.IMenItemProveedores.IconColor = System.Drawing.SystemColors.MenuHighlight;
            this.IMenItemProveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IMenItemProveedores.IconSize = 50;
            this.IMenItemProveedores.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.IMenItemProveedores.Name = "IMenItemProveedores";
            this.IMenItemProveedores.Size = new System.Drawing.Size(150, 80);
            this.IMenItemProveedores.Text = "PROVEEDORES";
            this.IMenItemProveedores.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.IMenItemProveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // IMenItemReportes
            // 
            this.IMenItemReportes.AutoSize = false;
            this.IMenItemReportes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IMenItemReportes.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.IMenItemReportes.IconChar = FontAwesome.Sharp.IconChar.BarChart;
            this.IMenItemReportes.IconColor = System.Drawing.SystemColors.MenuHighlight;
            this.IMenItemReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IMenItemReportes.IconSize = 50;
            this.IMenItemReportes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.IMenItemReportes.Name = "IMenItemReportes";
            this.IMenItemReportes.Size = new System.Drawing.Size(150, 80);
            this.IMenItemReportes.Text = "REPORTES";
            this.IMenItemReportes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.IMenItemReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // IMenItemAcercaDe
            // 
            this.IMenItemAcercaDe.AutoSize = false;
            this.IMenItemAcercaDe.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IMenItemAcercaDe.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.IMenItemAcercaDe.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            this.IMenItemAcercaDe.IconColor = System.Drawing.Color.CornflowerBlue;
            this.IMenItemAcercaDe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IMenItemAcercaDe.IconSize = 50;
            this.IMenItemAcercaDe.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.IMenItemAcercaDe.Name = "IMenItemAcercaDe";
            this.IMenItemAcercaDe.Size = new System.Drawing.Size(122, 80);
            this.IMenItemAcercaDe.Text = "ACERCA DE ";
            this.IMenItemAcercaDe.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.IMenItemAcercaDe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.IMenItemAcercaDe.Click += new System.EventHandler(this.IMenItemAcercaDe_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 80);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(12, 80);
            // 
            // MenStripTitulo
            // 
            this.MenStripTitulo.AutoSize = false;
            this.MenStripTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.MenStripTitulo.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenStripTitulo.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenStripTitulo.Location = new System.Drawing.Point(0, 0);
            this.MenStripTitulo.Name = "MenStripTitulo";
            this.MenStripTitulo.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.MenStripTitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MenStripTitulo.Size = new System.Drawing.Size(1234, 48);
            this.MenStripTitulo.TabIndex = 1;
            this.MenStripTitulo.Text = "menuStrip2";
            this.MenStripTitulo.UseWaitCursor = true;
            this.MenStripTitulo.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenStripTitulo_ItemClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(746, 727);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(488, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1234, 857);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.MenStripUser);
            this.Controls.Add(this.MenStripTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.MenStripUser;
            this.Name = "FormAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venecia (Administrador)";
            this.MenStripUser.ResumeLayout(false);
            this.MenStripUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenStripUser;
        private System.Windows.Forms.MenuStrip MenStripTitulo;
        private FontAwesome.Sharp.IconMenuItem IMenItemUsuarios;
        private FontAwesome.Sharp.IconMenuItem IMenItemMantenimiento;
        private FontAwesome.Sharp.IconMenuItem IMenItemVentas;
        private FontAwesome.Sharp.IconMenuItem IMenItemCompras;
        private FontAwesome.Sharp.IconMenuItem IMenItemClientes;
        private FontAwesome.Sharp.IconMenuItem IMenItemProveedores;
        private FontAwesome.Sharp.IconMenuItem IMenItemReportes;
        private FontAwesome.Sharp.IconMenuItem IMenItemAcercaDe;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

