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
    public partial class ABMProductos : Form
    {
        int id = 0;
        public ABMProductos()
        {
            InitializeComponent();

            LlenaGrilla();
        }

        private void dgListaProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id = Convert.ToInt32(dgListaProductos.SelectedRows[0].Cells[0].Value);
            }
            catch (Exception)
            {

            }
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DetalleProductos dp = new DetalleProductos();
            dp.ShowDialog();
            LlenaGrilla();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            DetalleProductos dp = new DetalleProductos(id, "modificar");
            dp.ShowDialog();
            LlenaGrilla();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DetalleProductos dp = new DetalleProductos(id, "eliminar");
            dp.ShowDialog();
            LlenaGrilla();
        }

        private void LlenaGrilla()
        {
            List<MODELO.Productos> ListaProductos = ControladoraProductos.Listar_Productos();
            dgListaProductos.DataSource = ListaProductos;
            dgListaProductos.ReadOnly = true;
        }
    }
}
