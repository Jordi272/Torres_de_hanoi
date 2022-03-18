using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Hanoi objetoHanoi = new Hanoi();

            Pila Ini = new Pila();
            Pila Aux = new Pila();
            Pila Final = new Pila();

            Disco d1 = new Disco(1);
            Disco d2 = new Disco(2);
            Disco d3 = new Disco(3);
            Disco d4 = new Disco(4);

            Ini.push(d4);
            Ini.push(d3);
            Ini.push(d2);
            Ini.push(d1);


            String numero;
            numero = Console.ReadLine();
            if (Int32.Parse(numero) == 1)
            {
                Console.WriteLine("----------------------");
                Console.WriteLine("MOVIMIENTOS ITERATIVOS");
                Console.WriteLine("----------------------");

                int iterativoResultado = objetoHanoi.iterativo(4, Ini, Final, Aux);
                Console.WriteLine("RESULTADO ITERATIVO --> " + iterativoResultado);

             
            }
            else
            {
                Console.WriteLine("Pulse 1");
            }
            Console.ReadKey();


        }
    }
}
