﻿namespace CapaPresentacion
{
    partial class FrmAdministrador
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
            this.MenuStripInicio = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.lblusuario = new System.Windows.Forms.Label();
            this.IMbtnUsuarios = new FontAwesome.Sharp.IconMenuItem();
            this.IMbtnMantenimiento = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItem2 = new FontAwesome.Sharp.IconMenuItem();
            this.IMbtnVentas = new FontAwesome.Sharp.IconMenuItem();
            this.IMbtnCompras = new FontAwesome.Sharp.IconMenuItem();
            this.IMbtnProveedores = new FontAwesome.Sharp.IconMenuItem();
            this.IMbtnClientes = new FontAwesome.Sharp.IconMenuItem();
            this.IMbtnReportes = new FontAwesome.Sharp.IconMenuItem();
            this.IMbtnAcercaDe = new FontAwesome.Sharp.IconMenuItem();
            this.IMbtnSalir = new FontAwesome.Sharp.IconMenuItem();
            this.MenuStripInicio.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStripInicio
            // 
            this.MenuStripInicio.AutoSize = false;
            this.MenuStripInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.MenuStripInicio.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.IMbtnUsuarios,
            this.IMbtnMantenimiento,
            this.IMbtnVentas,
            this.IMbtnCompras,
            this.IMbtnProveedores,
            this.IMbtnClientes,
            this.IMbtnReportes,
            this.IMbtnAcercaDe,
            this.IMbtnSalir});
            this.MenuStripInicio.Location = new System.Drawing.Point(0, 0);
            this.MenuStripInicio.Name = "MenuStripInicio";
            this.MenuStripInicio.Size = new System.Drawing.Size(948, 76);
            this.MenuStripInicio.TabIndex = 1;
            this.MenuStripInicio.Text = "menuStrip1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuario:";
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.BackColor = System.Drawing.Color.Transparent;
            this.lblusuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblusuario.Location = new System.Drawing.Point(64, 76);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(49, 13);
            this.lblusuario.TabIndex = 3;
            this.lblusuario.Text = "blusuario";
            // 
            // IMbtnUsuarios
            // 
            this.IMbtnUsuarios.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IMbtnUsuarios.ForeColor = System.Drawing.Color.White;
            this.IMbtnUsuarios.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            this.IMbtnUsuarios.IconColor = System.Drawing.Color.White;
            this.IMbtnUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IMbtnUsuarios.IconSize = 50;
            this.IMbtnUsuarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.IMbtnUsuarios.Name = "IMbtnUsuarios";
            this.IMbtnUsuarios.Size = new System.Drawing.Size(73, 72);
            this.IMbtnUsuarios.Text = "USUARIOS";
            this.IMbtnUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.IMbtnUsuarios.Click += new System.EventHandler(this.IMbtnUsuarios_Click);
            // 
            // IMbtnMantenimiento
            // 
            this.IMbtnMantenimiento.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iconMenuItem1,
            this.iconMenuItem2});
            this.IMbtnMantenimiento.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IMbtnMantenimiento.ForeColor = System.Drawing.Color.White;
            this.IMbtnMantenimiento.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.IMbtnMantenimiento.IconColor = System.Drawing.Color.White;
            this.IMbtnMantenimiento.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IMbtnMantenimiento.IconSize = 50;
            this.IMbtnMantenimiento.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.IMbtnMantenimiento.Name = "IMbtnMantenimiento";
            this.IMbtnMantenimiento.Size = new System.Drawing.Size(114, 72);
            this.IMbtnMantenimiento.Text = "MANTENIMIENTO";
            this.IMbtnMantenimiento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // iconMenuItem1
            // 
            this.iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconMenuItem1.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem1.Name = "iconMenuItem1";
            this.iconMenuItem1.Size = new System.Drawing.Size(124, 22);
            this.iconMenuItem1.Text = "Categoria";
            // 
            // iconMenuItem2
            // 
            this.iconMenuItem2.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconMenuItem2.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem2.Name = "iconMenuItem2";
            this.iconMenuItem2.Size = new System.Drawing.Size(124, 22);
            this.iconMenuItem2.Text = "Producto";
            // 
            // IMbtnVentas
            // 
            this.IMbtnVentas.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold);
            this.IMbtnVentas.ForeColor = System.Drawing.Color.White;
            this.IMbtnVentas.IconChar = FontAwesome.Sharp.IconChar.Tags;
            this.IMbtnVentas.IconColor = System.Drawing.Color.White;
            this.IMbtnVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IMbtnVentas.IconSize = 50;
            this.IMbtnVentas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.IMbtnVentas.Name = "IMbtnVentas";
            this.IMbtnVentas.Size = new System.Drawing.Size(62, 72);
            this.IMbtnVentas.Text = "VENTAS";
            this.IMbtnVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // IMbtnCompras
            // 
            this.IMbtnCompras.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold);
            this.IMbtnCompras.ForeColor = System.Drawing.Color.White;
            this.IMbtnCompras.IconChar = FontAwesome.Sharp.IconChar.DollyFlatbed;
            this.IMbtnCompras.IconColor = System.Drawing.Color.White;
            this.IMbtnCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IMbtnCompras.IconSize = 50;
            this.IMbtnCompras.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.IMbtnCompras.Name = "IMbtnCompras";
            this.IMbtnCompras.Size = new System.Drawing.Size(73, 72);
            this.IMbtnCompras.Text = "COMPRAS";
            this.IMbtnCompras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // IMbtnProveedores
            // 
            this.IMbtnProveedores.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold);
            this.IMbtnProveedores.ForeColor = System.Drawing.Color.White;
            this.IMbtnProveedores.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.IMbtnProveedores.IconColor = System.Drawing.Color.White;
            this.IMbtnProveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IMbtnProveedores.IconSize = 50;
            this.IMbtnProveedores.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.IMbtnProveedores.Name = "IMbtnProveedores";
            this.IMbtnProveedores.Size = new System.Drawing.Size(95, 72);
            this.IMbtnProveedores.Text = "PROVEEDORES";
            this.IMbtnProveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // IMbtnClientes
            // 
            this.IMbtnClientes.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold);
            this.IMbtnClientes.ForeColor = System.Drawing.Color.White;
            this.IMbtnClientes.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            this.IMbtnClientes.IconColor = System.Drawing.Color.White;
            this.IMbtnClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IMbtnClientes.IconSize = 50;
            this.IMbtnClientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.IMbtnClientes.Name = "IMbtnClientes";
            this.IMbtnClientes.Size = new System.Drawing.Size(68, 72);
            this.IMbtnClientes.Text = "CLIENTES";
            this.IMbtnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // IMbtnReportes
            // 
            this.IMbtnReportes.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold);
            this.IMbtnReportes.ForeColor = System.Drawing.Color.White;
            this.IMbtnReportes.IconChar = FontAwesome.Sharp.IconChar.BarChart;
            this.IMbtnReportes.IconColor = System.Drawing.Color.White;
            this.IMbtnReportes.IconFont = FontAwesome.Sharp.IconFont.Regular;
            this.IMbtnReportes.IconSize = 50;
            this.IMbtnReportes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.IMbtnReportes.Name = "IMbtnReportes";
            this.IMbtnReportes.Size = new System.Drawing.Size(72, 72);
            this.IMbtnReportes.Text = "REPORTES";
            this.IMbtnReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // IMbtnAcercaDe
            // 
            this.IMbtnAcercaDe.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold);
            this.IMbtnAcercaDe.ForeColor = System.Drawing.Color.White;
            this.IMbtnAcercaDe.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            this.IMbtnAcercaDe.IconColor = System.Drawing.Color.White;
            this.IMbtnAcercaDe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IMbtnAcercaDe.IconSize = 50;
            this.IMbtnAcercaDe.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.IMbtnAcercaDe.Name = "IMbtnAcercaDe";
            this.IMbtnAcercaDe.Size = new System.Drawing.Size(79, 72);
            this.IMbtnAcercaDe.Text = "ACERCA DE";
            this.IMbtnAcercaDe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // IMbtnSalir
            // 
            this.IMbtnSalir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.IMbtnSalir.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold);
            this.IMbtnSalir.ForeColor = System.Drawing.Color.White;
            this.IMbtnSalir.IconChar = FontAwesome.Sharp.IconChar.ArrowRightFromBracket;
            this.IMbtnSalir.IconColor = System.Drawing.Color.White;
            this.IMbtnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IMbtnSalir.IconSize = 50;
            this.IMbtnSalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.IMbtnSalir.Name = "IMbtnSalir";
            this.IMbtnSalir.Size = new System.Drawing.Size(62, 72);
            this.IMbtnSalir.Text = "SALIR";
            this.IMbtnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.IMbtnSalir.Click += new System.EventHandler(this.IMbtnSalir_Click);
            // 
            // FrmAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(948, 670);
            this.Controls.Add(this.lblusuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MenuStripInicio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmAdministrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.FrmAdministrador_Load);
            this.MenuStripInicio.ResumeLayout(false);
            this.MenuStripInicio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStripInicio;
        private FontAwesome.Sharp.IconMenuItem IMbtnSalir;
        private FontAwesome.Sharp.IconMenuItem IMbtnUsuarios;
        private FontAwesome.Sharp.IconMenuItem IMbtnMantenimiento;
        private FontAwesome.Sharp.IconMenuItem IMbtnVentas;
        private FontAwesome.Sharp.IconMenuItem IMbtnCompras;
        private FontAwesome.Sharp.IconMenuItem IMbtnProveedores;
        private FontAwesome.Sharp.IconMenuItem IMbtnClientes;
        private FontAwesome.Sharp.IconMenuItem IMbtnReportes;
        private FontAwesome.Sharp.IconMenuItem IMbtnAcercaDe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblusuario;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem2;
    }
}

