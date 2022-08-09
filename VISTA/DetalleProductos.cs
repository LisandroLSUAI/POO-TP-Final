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
    public partial class DetalleProductos : Form
    {
        string accion = "";
        private MODELO.Producto producto;
        private CONTROLADORA.ControladoraProductos productControl = CONTROLADORA.ControladoraProductos.obtener_instancia();
        public DetalleProductos()
        {
            InitializeComponent();
            txtIdProducto.Text = "";
            txtIdProducto.ReadOnly = false;
            txtNombreProducto.Text = "";
        }

        public DetalleProductos(int idProducto, string accion)
        {
            InitializeComponent();

            this.accion = accion;

            //conectar a la BD y trae los datos del producto
            producto = CONTROLADORA.ControladoraProductos.obtener_instancia().Obtener_Producto(idProducto);

            txtIdProducto.Text = producto.Id.ToString();
            txtIdProducto.ReadOnly = true;

            txtNombreProducto.Text = producto.Nombre;        }
        
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string prodName = txtNombreProducto.Text;
            int prodId = Convert.ToInt32(txtIdProducto.Text);
            MODELO.Producto newProd = new MODELO.Producto();
            newProd.Nombre = prodName;
            newProd.Id = prodId;
            
            MODELO.Producto selectedProd = productControl.Listar_Productos().Find(prod => prod.Id == prodId);


            //conectarse a la BD y Modificar segun txt

            if (accion == "")
            {
                if (selectedProd != null)
                {
                    ShowError("El producto con el nombre ingresado ya existe.");
                    return;
                }
                productControl.Agregar_Producto(newProd);
                this.DialogResult = DialogResult.OK;
                this.Close();
                return;
            }

            productControl.Modificar_Producto(selectedProd, newProd);
            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void ShowError(string msg)
        {
            MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
