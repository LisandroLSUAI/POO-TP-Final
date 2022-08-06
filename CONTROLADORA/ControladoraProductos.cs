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
        public static List<MODELO.Productos> Listar_Productos()
        {
            return MODELO.SingletonContexto.obtener_instancia().Contexto.ProductosSet.ToList();
        }

        public MODELO.Productos Obtener_Producto(int idProducto)
        {
            return MODELO.SingletonContexto.obtener_instancia().Contexto.ProductosSet.Find(idProducto);
        }

        public static void Agregar_Producto(MODELO.Productos producto)
        {
            MODELO.SingletonContexto.obtener_instancia().Contexto.ProductosSet.Add(producto);
            MODELO.SingletonContexto.obtener_instancia().Contexto.SaveChanges();
        }

        public static void Modificar_Producto(MODELO.Productos producto, MODELO.Productos prodNew)
        {
            MODELO.SingletonContexto.obtener_instancia().Contexto.ProductosSet.Remove(producto);
            MODELO.SingletonContexto.obtener_instancia().Contexto.ProductosSet.Add(prodNew);
            MODELO.SingletonContexto.obtener_instancia().Contexto.SaveChanges();
        }

        public static void Eliminar_Producto(MODELO.Productos producto)
        {
            MODELO.SingletonContexto.obtener_instancia().Contexto.ProductosSet.Remove(producto);
            MODELO.SingletonContexto.obtener_instancia().Contexto.SaveChanges();
        }
    }
}
