using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CONTROLADORA;
using MODELO;

namespace VISTA
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

		private void button1_Click(object sender, EventArgs e)
		{
            string nombre = usuarioTxt.Text;
            string pass = passTxt.Text;

            ControladoraUsuarios controladora = ControladoraUsuarios.obtener_instancia();

            Usuario usuario;
            try
            {
                usuario = controladora.Listar_Usuarios().Find(user => user.Nombre == nombre && user.Contraseña == pass);
            } catch(Exception error)
            {
                ShowError("Error al ingresar a la base de datos: " + error.Message);
                return;
            }

            if (usuario != null)
			{
                FormGestionarUsuarios form = new FormGestionarUsuarios(usuario.Id);
                form.Show();
                this.Close();
            } else
			{
                ShowError("Credenciales Incorrectas");
			}
        }

        private void ShowError(string msg)
		{
			MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
