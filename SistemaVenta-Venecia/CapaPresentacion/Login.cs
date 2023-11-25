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

namespace CapaPresentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        private void IbtnIngresar_Click(object sender, EventArgs e)
        {
            List<Usuario> TEST = new CapaNegocio_Usuario().Listar();

            Usuario ousuario = new CapaNegocio_Usuario().Listar().Where(u => u.Documento == txtUsuario.Text && u.Clave == txtContraseña.Text).FirstOrDefault();

            if (ousuario != null)
            {
                FrmAdministrador operacion = new FrmAdministrador();

                operacion.Show();
                this.Hide();

                operacion.FormClosing += CerrarForm;
            }
            else
            {
                MessageBox.Show("No se encontro el usuario en el sistema, verifique su existencia", "Error de busqueda de usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        //Recursividad para que pueda regresarnos al login con las cajas de texto vacias para el siguiente usuario
        private void CerrarForm(object sender, FormClosingEventArgs e)
        {
            txtUsuario.Text = "";
            txtContraseña.Text = "";
            this.Show();
        }

        private void IbtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
