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
        private MODELO.Productos producto;
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

            txtNombreProducto.Text = producto.Nombre;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            MODELO.Productos prod = new MODELO.Productos();
            prod.Id = Convert.ToInt32(txtIdProducto.Text);
            prod.Nombre = txtNombreProducto.Text;
            
            //conectarse a la BD y Modificar segun txt
            switch (accion)
            {
                case "modificar":
                    CONTROLADORA.ControladoraProductos.Modificar_Producto(producto, prod);
                    break;
                case "eliminar":
                    CONTROLADORA.ControladoraProductos.Eliminar_Producto(prod);
                    break;
                case "":
                    CONTROLADORA.ControladoraProductos.Agregar_Producto(producto);
                    break;                
            }
                        
            this.Close();
        }
    }
}
