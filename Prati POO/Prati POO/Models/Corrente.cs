using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prati_POO.Models
{
    internal class Corrente : Conta
    {
        public override void Creditar(decimal valor)
        {
            try
            {
                saldo += valor;
            }
            catch
            {
                throw new NotImplementedException();
            }
            
        }
    }
}
