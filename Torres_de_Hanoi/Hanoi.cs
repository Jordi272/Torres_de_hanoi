using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Hanoi
    {
        /*TODO: Implementar métodos*/
        public void mover_disco(Pila a, Pila b)
        {
            
            if (a.isEmpty() && b.Top != 0)
            {
                Disco disco = b.pop();
                a.push(disco);               
                Console.WriteLine("Disco movido: " + disco.Valor);



            }
            else if (b.isEmpty() && !a.isEmpty())
            {
                Disco disco = a.pop();
                b.push(disco);
                Console.WriteLine("Disco movido " + disco.Valor);

            }
            else
            {               
                if (a.Top > b.Top)
                {                   
                    Disco disco = b.pop();
                    a.push(disco);
                    Console.WriteLine("Disco movido " + disco.Valor);
                }
                else
                {                   
                    Disco disco = a.pop();
                    b.push(disco);
                    Console.WriteLine("Disco movido " + disco.Valor);
                }
            }



        }


       



    }
}

