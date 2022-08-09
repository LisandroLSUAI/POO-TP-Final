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
    public partial class FormAgregarPedido : Form
    {
        private readonly Int32 usuarioId;
        private readonly ControladoraPedidos pedidosControl = ControladoraPedidos.obtener_instancia();
        private readonly List<Producto> prods = ControladoraProductos.obtener_instancia().Listar_Productos();
        public FormAgregarPedido(Int32 usuarioId)
        {
            this.usuarioId = usuarioId;
            InitializeComponent();
        }

        private void FormAgregarPedido_Load(object sender, EventArgs e)
        {
            
            List<String> items = new List<string>();

            prods.ForEach(prod => items.Add(prod.Nombre));
            checkedListBox.Items.AddRange(items.ToArray());
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {

            List<Producto> selectedProds = new List<Producto>();
            foreach (string item in checkedListBox.CheckedItems)
            {
                Producto sProd = prods.Find(prod => prod.Nombre == item);
                if (sProd != null) prods.Add(sProd);
            }

            Pedido pedido = new Pedido();
            pedido.Productos = selectedProds;
            pedido.UsuarioId = usuarioId;
            pedido.Usuario = ControladoraUsuarios.obtener_instancia().Obtener_Usuario(usuarioId);
            pedidosControl.Agregar_Pedido(pedido);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
