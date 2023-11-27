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
using CapaNegocio;
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
            List<Permiso> ListaPermiso = new CN_Permiso().Listar(usuarioActual.IdUsuario);

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

        private void iconMenuItem1_Click(object sender, EventArgs e)
        {
            AbrirFormulario(IMbtnMantenimiento, new frmCategoria());
        }
        private void submenuproducto_Click(object sender, EventArgs e)
        {
            AbrirFormulario(IMbtnMantenimiento, new frmProducto());
        }

        private void submenuregistrarventa_Click(object sender, EventArgs e)
        {
           AbrirFormulario(IMbtnVentas, new frmVentas());
        }

        private void submenuverdetalleventa_Click(object sender, EventArgs e)
        {
            AbrirFormulario(IMbtnVentas, new frmDetalleVenta());
        }

        private void submenuregistrarcompra_Click(object sender, EventArgs e)
        {
            AbrirFormulario(IMbtnCompras, new frmCompras());
        }

        private void submenuverdetallecompra_Click(object sender, EventArgs e)
        {
            AbrirFormulario(IMbtnCompras, new frmCompras());
        }

        private void IMbtnClientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmClientes());
        }

        private void IMbtnProveedores_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmProveedores());
        }

        private void IMbtnReportes_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmReportes());
        }

        private void contenedor_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
