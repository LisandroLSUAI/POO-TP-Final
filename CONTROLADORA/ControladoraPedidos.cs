using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODELO;

namespace CONTROLADORA
{
    public class ControladoraPedidos
    {
        private static ControladoraPedidos _instancia;

        private ControladoraPedidos() { }

        public static ControladoraPedidos obtener_instancia()
        {
            if (_instancia == null)
            {
                _instancia = new ControladoraPedidos();
            }

            return _instancia;
        }

        public void Agregar_Pedido(Pedido pedido)
        {
            SingletonContexto.obtener_instancia().Contexto.Pedidos.Add(pedido);
            SingletonContexto.obtener_instancia().Contexto.SaveChanges();
        }

        public void Remover_Pedido(Pedido pedido)
        {
            SingletonContexto.obtener_instancia().Contexto.Pedidos.Remove(pedido);
            SingletonContexto.obtener_instancia().Contexto.SaveChanges();
        }

        public List<Pedido> Listar_Pedidos()
        {
            return SingletonContexto.obtener_instancia().Contexto.Pedidos.ToList();
        }
    }
}
