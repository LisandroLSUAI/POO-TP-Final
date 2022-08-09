using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class ControladoraProductos
    {
        private static ControladoraProductos _instancia;

        private ControladoraProductos() { }

        public static ControladoraProductos obtener_instancia()
        {
            if (_instancia == null)
            {
                _instancia = new ControladoraProductos();
            }
            return _instancia;
        }

        //Metodos Productos
        public List<MODELO.Producto> Listar_Productos()
        {
            return MODELO.SingletonContexto.obtener_instancia().Contexto.ProductoSet.ToList();
        }

        public MODELO.Producto Obtener_Producto(int idProducto)
        {
            return MODELO.SingletonContexto.obtener_instancia().Contexto.ProductoSet.Find(idProducto);
        }

        public void Agregar_Producto(MODELO.Producto producto)
        {
            MODELO.SingletonContexto.obtener_instancia().Contexto.ProductoSet.Add(producto);
            MODELO.SingletonContexto.obtener_instancia().Contexto.SaveChanges();
        }

        public void Modificar_Producto(MODELO.Producto producto, MODELO.Producto prodNew)
        {
            MODELO.SingletonContexto.obtener_instancia().Contexto.ProductoSet.Remove(producto);
            MODELO.SingletonContexto.obtener_instancia().Contexto.ProductoSet.Add(prodNew);
            MODELO.SingletonContexto.obtener_instancia().Contexto.SaveChanges();
        }

        public void Eliminar_Producto(MODELO.Producto producto)
        {
            MODELO.SingletonContexto.obtener_instancia().Contexto.ProductoSet.Remove(producto);
            MODELO.SingletonContexto.obtener_instancia().Contexto.SaveChanges();
        }
    }
}
