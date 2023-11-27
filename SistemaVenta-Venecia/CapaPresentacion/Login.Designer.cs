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
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.IbtnIngresar = new FontAwesome.Sharp.IconButton();
            this.IbtnCancelar = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtUsuario.Location = new System.Drawing.Point(149, 176);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(198, 21);
            this.txtUsuario.TabIndex = 1;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtContraseña.Location = new System.Drawing.Point(149, 234);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(198, 21);
            this.txtContraseña.TabIndex = 2;
            // 
            // IbtnIngresar
            // 
            this.IbtnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.IbtnIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IbtnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IbtnIngresar.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold);
            this.IbtnIngresar.ForeColor = System.Drawing.Color.White;
            this.IbtnIngresar.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.IbtnIngresar.IconColor = System.Drawing.Color.White;
            this.IbtnIngresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IbtnIngresar.IconSize = 20;
            this.IbtnIngresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IbtnIngresar.Location = new System.Drawing.Point(99, 285);
            this.IbtnIngresar.Name = "IbtnIngresar";
            this.IbtnIngresar.Size = new System.Drawing.Size(133, 41);
            this.IbtnIngresar.TabIndex = 5;
            this.IbtnIngresar.Text = "INGRESAR";
            this.IbtnIngresar.UseVisualStyleBackColor = false;
            this.IbtnIngresar.Click += new System.EventHandler(this.IbtnIngresar_Click);
            // 
            // IbtnCancelar
            // 
            this.IbtnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.IbtnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IbtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IbtnCancelar.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold);
            this.IbtnCancelar.ForeColor = System.Drawing.Color.White;
            this.IbtnCancelar.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.IbtnCancelar.IconColor = System.Drawing.Color.White;
            this.IbtnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IbtnCancelar.IconSize = 20;
            this.IbtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IbtnCancelar.Location = new System.Drawing.Point(262, 285);
            this.IbtnCancelar.Name = "IbtnCancelar";
            this.IbtnCancelar.Size = new System.Drawing.Size(134, 41);
            this.IbtnCancelar.TabIndex = 6;
            this.IbtnCancelar.Text = "CANCELAR";
            this.IbtnCancelar.UseVisualStyleBackColor = false;
            this.IbtnCancelar.Click += new System.EventHandler(this.IbtnCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(147, 155);
            this.label1.MaximumSize = new System.Drawing.Size(100, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Usuario";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources._385552367_1278618679476958_4822168691831935752_n2;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(451, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(147, 213);
            this.label2.MaximumSize = new System.Drawing.Size(100, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Contraseña";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(481, 387);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IbtnCancelar);
            this.Controls.Add(this.IbtnIngresar);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private FontAwesome.Sharp.IconButton IbtnIngresar;
        private FontAwesome.Sharp.IconButton IbtnCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}