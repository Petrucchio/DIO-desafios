using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propriedades_metodos_e_consturtores.Models
{
    internal static class IntExtensions
    {
        public static bool ehPar(this int numero)
        {
            return numero % 2 == 0;
        }
    }
}
