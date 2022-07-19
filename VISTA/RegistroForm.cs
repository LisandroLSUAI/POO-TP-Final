using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using CONTROLADORA;
using MODELO;


namespace VISTA
{
	public partial class RegistroForm : Form
	{
		private readonly ControladoraUsuarios userControl = ControladoraUsuarios.obtener_instancia();
		private readonly ControladoraPerfiles profileControl = ControladoraPerfiles.obtener_instancia();
		public RegistroForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
		{

		}

		private void btnRegistrar_Click(object sender, EventArgs e)
		{
			string nombre = txtNombre.Text;
			if (nombre == "")
			{
				ShowError("Completar nombre.");
				return;
			}

			string pass = txtPass.Text;
			if (pass == "")
			{
				ShowError("Completar contraseña");
				return;
			}

			string email = textBoxEmail.Text;
			if (!IsValidEmail(email))
            {
				ShowError("E-mail ingresado es inválido");
				return ;
            }

			int dni = Convert.ToInt32(numericUpDownDNI.Value);
			if (dni <= 0)
            {
				ShowError("DNI ingresado es inválido.");
				return;
            }

			bool isAdminUser = empleadoRbtn.Checked;
			if(isAdminUser && !CheckSuperAdminCredentials())
            {
				ShowError("Las credenciales de Super administrador no son válidas.");
				return;
            }

			Usuario usuario;
			try
			{
				usuario = userControl.Listar_Usuarios().Find(user => user.Nombre == nombre);
			} catch(Exception error)
            {
				ShowError("Error al acceder a la base de datos: " + error.Message);
				return;
            }

			if (usuario == null)
			{
				Perfil perfil;
				if (isAdminUser) {
					perfil = profileControl.Obtener_Perfil_Admin();
			    } else {
					perfil = profileControl.Obtener_Perfil_Cliente();
				}
				Usuario nuevoUsuario = new Usuario
				{
					Nombre = nombre,
					Contraseña = pass,
					Dni = Convert.ToString(dni),
					Email = email,
					Perfil = perfil,
				};

				try
				{
					userControl.Agregar_Usuario(nuevoUsuario);
					DialogResult result = MessageBox.Show("¡Usuario Registrado!");
					if (result == DialogResult.OK)
                    {
						this.DialogResult = DialogResult.OK;
						this.Close();
                    }
				} catch(Exception error)
                {
					ShowError("Error al registrar usuario: " + error.Message);
                }
			}
			else
			{
				ShowError("Ya existe el usuario");
			}
		}

		private void RegistroForm_Load(object sender, EventArgs e)
		{
			txtNombre.Focus();
			numericUpDownDNI.Controls.RemoveAt(0);
		}

		private void ShowError(string msg)
		{
			MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

        private void empleadoRbtn_CheckedChanged(object sender, EventArgs e)
        {
			textBoxSuperAdminPass.ReadOnly = !empleadoRbtn.Checked;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
			this.DialogResult = DialogResult.Cancel;
			this.Close();
        }

		private bool IsValidEmail(string email)
        {
			try
            {
				MailAddress mailAddress = new MailAddress(email);
				return mailAddress.Address == email;
            } catch (Exception)
            {
				return false;
            }
        }

		private bool CheckSuperAdminCredentials()
        {
			string superAdminPass = textBoxSuperAdminPass.Text;
			try 
			{ 
				return userControl.Obtener_SuperAdmin().Contraseña == superAdminPass; 
			} catch(Exception) {
				return false; 
			}
        }
    }
}
