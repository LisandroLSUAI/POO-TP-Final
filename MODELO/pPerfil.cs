using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public partial class Perfil
    {
        public override string ToString()
        {
            return this.Nombre;
        }

        public const int SUPER_ADMIN = 2;
        public const int ADMIN = 3;
        public const int CLIENT = 1;
    }
}
