using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prati_POO.Interfaces
{
    internal interface ICalculadora
    {
        int Somar(int numero1, int numero2);
        int Subtrair(int numero1, int numero2);
        int Multiplicar(int numero1, int numero2);
        int Dividir(int numero1, int numero2)
        {
            return numero1 / numero2;
        }
    }
}
