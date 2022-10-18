using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prati_POO.Models
{
    internal class ContaCorrente
    {
        public int Numero { get; set; }
        private decimal _Saldo { get; set; }

        public void Sacar(decimal valor)
        {
            if(_Saldo >= valor)
            {
                _Saldo -= valor;
                Console.WriteLine("saque efetuado com sucesso");
                ExibirSaldo();
            }
            else
            {
                Console.WriteLine("Saldo insuficiente");
                ExibirSaldo();
            }
            
        }

        public void ExibirSaldo()
        {
            Console.WriteLine($"Seu saldo atual é: {_Saldo}");
        }

        public ContaCorrente(int numero, decimal saldo)
        {
            Numero = numero;
            _Saldo = saldo;
        }
    }
}
