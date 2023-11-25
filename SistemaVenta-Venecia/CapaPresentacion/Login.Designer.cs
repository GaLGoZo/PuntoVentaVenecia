namespace CapaPresentacion
{
    partial class Login
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.IbtnIngresar = new FontAwesome.Sharp.IconButton();
            this.IbtnCancelar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(211, 265);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtUsuario.Location = new System.Drawing.Point(284, 81);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(190, 21);
            this.txtUsuario.TabIndex = 1;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtContraseña.Location = new System.Drawing.Point(284, 163);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(190, 21);
            this.txtContraseña.TabIndex = 2;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(280, 39);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(94, 23);
            this.lblUsuario.TabIndex = 3;
            this.lblUsuario.Text = "USUARIO";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.ForeColor = System.Drawing.Color.White;
            this.lblContraseña.Location = new System.Drawing.Point(280, 121);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(123, 23);
            this.lblContraseña.TabIndex = 4;
            this.lblContraseña.Text = "CONTRSEÑA";
            // 
            // IbtnIngresar
            // 
            this.IbtnIngresar.BackColor = System.Drawing.Color.MediumBlue;
            this.IbtnIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IbtnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IbtnIngresar.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold);
            this.IbtnIngresar.ForeColor = System.Drawing.Color.White;
            this.IbtnIngresar.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.IbtnIngresar.IconColor = System.Drawing.Color.White;
            this.IbtnIngresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IbtnIngresar.IconSize = 20;
            this.IbtnIngresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IbtnIngresar.Location = new System.Drawing.Point(227, 230);
            this.IbtnIngresar.Name = "IbtnIngresar";
            this.IbtnIngresar.Size = new System.Drawing.Size(129, 23);
            this.IbtnIngresar.TabIndex = 5;
            this.IbtnIngresar.Text = "INGRESAR";
            this.IbtnIngresar.UseVisualStyleBackColor = false;
            this.IbtnIngresar.Click += new System.EventHandler(this.IbtnIngresar_Click);
            // 
            // IbtnCancelar
            // 
            this.IbtnCancelar.BackColor = System.Drawing.Color.Red;
            this.IbtnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IbtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IbtnCancelar.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold);
            this.IbtnCancelar.ForeColor = System.Drawing.Color.White;
            this.IbtnCancelar.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.IbtnCancelar.IconColor = System.Drawing.Color.White;
            this.IbtnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IbtnCancelar.IconSize = 20;
            this.IbtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IbtnCancelar.Location = new System.Drawing.Point(398, 230);
            this.IbtnCancelar.Name = "IbtnCancelar";
            this.IbtnCancelar.Size = new System.Drawing.Size(130, 23);
            this.IbtnCancelar.TabIndex = 6;
            this.IbtnCancelar.Text = "CANCELAR";
            this.IbtnCancelar.UseVisualStyleBackColor = false;
            this.IbtnCancelar.Click += new System.EventHandler(this.IbtnCancelar_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(549, 265);
            this.Controls.Add(this.IbtnCancelar);
            this.Controls.Add(this.IbtnIngresar);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblContraseña;
        private FontAwesome.Sharp.IconButton IbtnIngresar;
        private FontAwesome.Sharp.IconButton IbtnCancelar;
    }
}