using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using FontAwesome.Sharp;


namespace CapaPresentacion
{
    public partial class FrmAdministrador : Form
    {
        private static Usuario usuarioActual;
        private static IconMenuItem MenuActivo = null;
        private static Form FormularioActivo = null;

        public FrmAdministrador(Usuario obusuario)
        {
            usuarioActual = obusuario;

            InitializeComponent();
        }

        public FrmAdministrador()
        {
        }

        private void IMbtnSalir_Click(object sender, EventArgs e)
        {
            Login operacion = new Login();

            operacion.Show();
            this.Close();
        }

        private void FrmAdministrador_Load(object sender, EventArgs e)
        {
            lblusuario.Text = usuarioActual.NombreCompleto;
        }

        private void AbrirFormulario(IconMenuItem menu, Form formulario)
        {
            if(menu != null)
            {
                MenuActivo.BackColor = Color.White;
            }
            menu.BackColor = Color.White;
            MenuActivo = menu;

            if(FormularioActivo != null)
            {
                FormularioActivo.Close();
            }
            FormularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.BackColor = Color.White;

            contenedor.Controls.Add(formulario);
            formulario.Show();
        }
        private void menuusuarios_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmUsuarios());
        }
        private void IMbtnUsuarios_Click(object sender, EventArgs e)
        {
            
        }
    }
}
