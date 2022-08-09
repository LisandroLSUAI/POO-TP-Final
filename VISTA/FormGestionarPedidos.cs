using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MODELO;
using CONTROLADORA;

namespace VISTA
{
    public partial class FormGestionarPedidos : Form
    {

        private ControladoraUsuarios usuarios = ControladoraUsuarios.obtener_instancia();
        private Usuario usuario;
        public FormGestionarPedidos(Usuario usuario)
        {
            this.usuario = usuario;
            InitializeComponent();
        }

        private void FormGestionarPedidos_Load(object sender, EventArgs e)
        {
            
        }

        private void ShowError(string msg)
        {
            MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
