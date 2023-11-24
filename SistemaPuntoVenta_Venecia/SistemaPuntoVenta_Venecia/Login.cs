using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaNegocio;
using CapaEntidad;

namespace SistemaPuntoVenta_Venecia
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            List<Usuario> TEST = new CN_Usuario().Listar();
            Usuario osuario = new CN_Usuario().Listar().Where(u => u.Documento == txtdocumento.Text && u.Clave == txtclave.Text).FirstOrDefault();

            FormAdmin form = new FormAdmin();

            form.Show();
            this.Hide();

            form.FormClosing += frm_closing;
        }

        

        private void frm_closing(object sender, FormClosingEventArgs e)
        {
            txtdocumento.Text = "";
            txtclave.Text = "";

            this.Show();
        }

        private void textpassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
