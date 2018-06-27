using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoGeral
{
    class Program
    {
        static void Main(string[] args)
        {
            var entidade = new Numeros();

            Filtro f = n => n % 3 == 0;

            entidade.ImprimeListaNumeros(entidade.ListaNumeros, f);
                
            Console.ReadKey();
        }
    }
}
