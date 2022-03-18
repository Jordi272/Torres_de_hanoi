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
            
            Hanoi Hanoi = new Hanoi();

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


            Pila Inir = new Pila();
            Pila Auxr = new Pila();
            Pila Finalr = new Pila();

 
            Disco d1r = new Disco(1);
            Disco d2r = new Disco(2);
            Disco d3r = new Disco(3);
            Disco d4r = new Disco(4);

            Inir.push(d4r);
            Inir.push(d3r);
            Inir.push(d2r);
            Inir.push(d1r);

            Console.WriteLine("Seleccione un algoritmo:" + Environment.NewLine);
            Console.WriteLine("1 para iterativo");
            Console.WriteLine("Otro número para recursivo");

            String numeroIntroducido;
            numeroIntroducido = Console.ReadLine();
            if (Int32.Parse(numeroIntroducido) == 1)
            {
                Console.WriteLine("ALGORITMO ITERARITVO");

                int iterativo = Hanoi.iterativo(4,Ini, Final, Aux);
                Console.WriteLine("El núemro de moviemientos es: " + iterativo);
              
            }
            else
            {
                Console.WriteLine("ALGORITMO RECURSIVO");

                int recursivoResultado = Hanoi.recursivo(4, Inir, Finalr, Auxr);
                Console.WriteLine("El núemro de moviemientos es: " + recursivoResultado);
             
            }
            Console.ReadKey();
        }
    }
}
