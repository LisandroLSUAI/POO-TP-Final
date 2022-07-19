using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VISTA
{
	public partial class Bienvenido : Form
	{
		public Bienvenido()
		{
			InitializeComponent();
		}

		private void btnIngresar_Click(object sender, EventArgs e)
		{
			Login Login = new Login();
			Login.Show();
		}

		private void btnRegistrar_Click(object sender, EventArgs e)
		{
			RegistroForm registroForm = new RegistroForm();
			registroForm.Show();
		}
	}
}
