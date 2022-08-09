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
    public partial class FormModificarUsuario : Form
    {
        private readonly ControladoraUsuarios userControl = ControladoraUsuarios.obtener_instancia();
        private Usuario user;
        public FormModificarUsuario(Usuario user)
        {
            this.user = user;
            InitializeComponent();
            this.AcceptButton = buttonSave;
        }

        private void checkBoxPass_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPass.ReadOnly = !checkBoxPass.Checked;
            textBoxPassRepeat.ReadOnly = !checkBoxPass.Checked;
        }

        private void FormModificarUsuario_Load(object sender, EventArgs e)
        {
            textBoxName.Text = user.Nombre;
            textBoxEmail.Text = user.Email;
            numericUpDownDNI.Controls[0].Visible = false;
            numericUpDownDNI.Value = Convert.ToInt32(user.Dni);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            if(name == null)
            {
                ShowError("Completar el nombre");
                return;
            }

            string email = textBoxEmail.Text;
            if (email == null)
            {
                ShowError("Completar el e-mail");
                return;
            }

            Int32 dni = Convert.ToInt32(numericUpDownDNI.Value);
            if (dni == 0)
            {
                ShowError("DNI inválido");
                return;
            }

            string pass = user.Contraseña;
            if (checkBoxPass.Checked)
            {
                pass = textBoxPass.Text;
                if (pass == null)
                {
                    ShowError("Completar contraseña");
                    return;
                }

                string repeatedPass = textBoxPassRepeat.Text;
                if (pass != repeatedPass)
                {
                    ShowError("Las contraseñas no coinciden");
                    return;
                }
            }

            Usuario newUser = new Usuario
            {
                Nombre = name,
                Email = email,
                Dni = Convert.ToString(dni),
                Perfil = user.Perfil,
                Contraseña = Encrypt.GetSHA256(pass),
            };

            try
            {
                userControl.Modificar_Usuario(user, newUser);
                DialogResult result = MessageBox.Show("Usuario modificado");
                if (result == DialogResult.OK)
                {
                    this.DialogResult = result;
                    this.Close();
                }
            } catch (Exception)
            {
                ShowError("Error al modificar Usuario");
            }
            
        }

        private void ShowError(string msg)
        {
            MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
