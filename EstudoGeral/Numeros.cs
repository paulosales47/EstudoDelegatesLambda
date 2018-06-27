using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoGeral
{
    public class Numeros
    {
        public int[] ListaNumeros { get; set; }
        
        public Numeros()
        {
            ListaNumeros = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
        }
        
        public static bool FiltroPar(int numero)
        {
            return numero % 2 == 0;
        }

        public bool FiltroImpar(int numero)
        {
            return numero % 2 == 1;
        }
        
        public void ImprimeListaNumeros(int[] lista, Filtro filtro)
        {
            foreach (var numero in lista)   
            {
                if(filtro(numero))
                    Console.WriteLine(numero);
            }
            Console.WriteLine("\n----------\n");
        }


    }
}
