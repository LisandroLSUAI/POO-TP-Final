using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class ControladoraPerfiles
    {
        private static ControladoraPerfiles _instancia;

        private ControladoraPerfiles() { }

        public static ControladoraPerfiles obtener_instancia()
        {
            if (_instancia == null)
            {
                _instancia = new ControladoraPerfiles();
            }
            return _instancia;
        }

        public List<MODELO.Perfil> Listar_Perfiles()
        {
            return MODELO.SingletonContexto.obtener_instancia().Contexto.Perfiles.ToList();
        }

        public void Llenar_Lista_Perfiles(List<MODELO.Perfil> perfiles)
        {
            MODELO.SingletonContexto.obtener_instancia().Contexto.Perfiles.AddRange(perfiles);
            MODELO.SingletonContexto.obtener_instancia().Contexto.SaveChanges();
        }

        public MODELO.Perfil Obtener_Perfil(int CODIGO)
        {
            return MODELO.SingletonContexto.obtener_instancia().Contexto.Perfiles.Find(CODIGO);
        }

        public MODELO.Perfil Obtener_Perfil_SuperAdmin()
        {
            return Obtener_Perfil(MODELO.Perfil.SUPER_ADMIN);
        }

        public MODELO.Perfil Obtener_Perfil_Admin()
        {
            return Obtener_Perfil(MODELO.Perfil.ADMIN);
        }

        public MODELO.Perfil Obtener_Perfil_Cliente()
        {
            return Obtener_Perfil(MODELO.Perfil.CLIENT);
        }
    }
}
