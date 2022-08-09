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

namespace VISTA
{
    public partial class MenuPrincipal : Form
    {
        MODELO.Usuario usuario = null;
        public MenuPrincipal(MODELO.Usuario usr)
        {
            InitializeComponent();
            usuario = usr;
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            FormGestionarUsuarios form = new FormGestionarUsuarios(usuario.Id);
            form.Show();
            this.Close();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            ABMProductos productos = new ABMProductos();
            productos.ShowDialog();
            this.Close();
        }
    }
}
