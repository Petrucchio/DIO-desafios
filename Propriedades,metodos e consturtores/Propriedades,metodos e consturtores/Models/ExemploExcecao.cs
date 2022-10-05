using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propriedades_metodos_e_consturtores.Models
{
    internal class ExemploExcecao
    {
        public void Metodo1()
        {
            try
            {
                Metodo2();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exceção tratada "+ ex.Message);
            }
            
        }
        public void Metodo2()
        {
            Metodo3();
        } 
        public void Metodo3()
        {
            
            Metodo4();
        }
        public void Metodo4()
        {
            throw new Exception("Ocorreu um erro");
        }
    }
}
