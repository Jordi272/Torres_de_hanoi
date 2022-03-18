using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Hanoi
    {      
        public void mover_disco(Pila a, Pila b)
        {          
            if (a.isEmpty() && b.Top != 0)
            {
                Disco disco = b.pop();
                a.push(disco);
                Console.WriteLine("Disco movido " + disco.Valor);



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
        

        public int iterativo(int n, Pila ini, Pila fin, Pila aux)
        {
            bool solucion = true;

            if (n % 2 != 0)
            {
                while (solucion)
                {
                    mover_disco(ini, fin);
                    incrementar_movimientos();

                    if (fin.Size == n)
                    {
                        solucion = false;
                        break;
                    }
                    mover_disco(ini, aux);
                    incrementar_movimientos();
                    if (fin.Size == n)
                    {
                        solucion = false;
                        break;
                    }
                    mover_disco(aux, fin);
                    incrementar_movimientos();
                    if (fin.Size == n)
                    {
                        solucion = false;
                        break;
                    }


                }//fin mientras

            }//fin si 

            if (n % 2 == 0)
            {
                while (solucion)
                {
                    mover_disco(ini, aux);
                    incrementar_movimientos();
                    if (fin.Size == n)
                    {
                        solucion = false;
                        break;
                    }
                    mover_disco(ini, fin);
                    incrementar_movimientos();
                    if (fin.Size == n)
                    {
                        solucion = false;
                        break;
                    }
                    mover_disco(aux, fin);
                    incrementar_movimientos();
                    if (fin.Size == n)
                    {
                        solucion = false;
                        break;
                    }


                }
            }
            return incrementar_movimientos();
        }

        public int contador = 0;
        public int recursivo(int n, Pila ini, Pila fin, Pila aux)
        {
            

            if (n == 1)
            {
                mover_disco(ini, fin);
                contador++;
            }
            else
            {

                recursivo(n - 1, ini, aux, fin);
                mover_disco(ini, fin);
                contador++;
                recursivo(n - 1, aux, fin, ini);

            }
            return contador;
        }

        public int movimientos = 0;
        public int incrementar_movimientos()
        {
            return movimientos++;
        }
    }
}

