using Prati_POO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prati_POO.Models
{
    internal class Calculadora : ICalculadora
    {

        public int Multiplicar(int numero1, int numero2)
        {
            try
            {
                return numero1*numero2;
            }
            catch
            {
                throw new NotImplementedException();
            }
        }

        public int Somar(int numero1, int numero2)
        {
            try
            {
                return numero1 + numero2;
            }
            catch
            {
                throw new NotImplementedException();
            }
        }

        public int Subtrair(int numero1, int numero2)
        {
            try
            {
                return numero1 - numero2;
            }
            catch
            {
                throw new NotImplementedException();
            }
        }
    }
}
