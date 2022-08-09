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
        public ABMProductos()
        {
            InitializeComponent();

            LlenaGrilla();
        }

        private void dgListaProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DetalleProductos dp = new DetalleProductos();
            dp.ShowDialog();
            LlenaGrilla();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Int32 id;
            try
            {
                id = Convert.ToInt32(dgListaProductos.SelectedRows[0].Cells[0].Value);
            }catch(Exception) 
            {
                ShowError("No seleccionaste un producto.");
                return;
            }

            DetalleProductos dp = new DetalleProductos(id, "modificar");
            dp.ShowDialog();
            LlenaGrilla();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Int32 id;
            try
            {
                id = Convert.ToInt32(dgListaProductos.SelectedRows[0].Cells[0].Value);
            }
            catch (Exception)
            {
                ShowError("No seleccionaste un producto.");
                return;
            }

            ControladoraProductos prodControl = ControladoraProductos.obtener_instancia();
            MODELO.Producto prod = prodControl.Obtener_Producto(id);
            prodControl.Eliminar_Producto(prod);
            LlenaGrilla();
        }

        private void LlenaGrilla()
        {
            List<MODELO.Producto> ListaProductos = ControladoraProductos.obtener_instancia().Listar_Productos();
            dgListaProductos.DataSource = ListaProductos;
            dgListaProductos.ReadOnly = true;
        }

        private void ShowError(string msg)
        {
            MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
