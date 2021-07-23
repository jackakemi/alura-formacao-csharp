using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Logica
{
    public class LacoFor
    {

        public void LacoContador()
        {
            for (int contador = 1; contador <= 10; contador++)
            {
                Console.WriteLine(contador);
            }         
        }

        public void LacoEncadeado1()
        {
            for (int linha = 0; linha < 5; linha++)
            {
                for (int coluna = 0; coluna < 5; coluna++)
                {
                    if (coluna > linha)
                    {
                        break;
                    }
                    Console.Write(coluna + 1);
                }
                Console.WriteLine();
            }
        }

        public void LacoEncadeado2()
        {
            for (int multiplicador = 1; multiplicador <= 10; multiplicador++)
            {
                for (int contador = 0; contador <= 10; contador++)
                {
                    Console.WriteLine(multiplicador + " x " + contador + " = " + multiplicador*contador);
                    Console.WriteLine();
                }

                Console.WriteLine();
            }
        }

        public void LacoEncadeado3()
        {
            for (int linha = 0; linha < 10; linha++)
            {
                for (int coluna = 0; coluna <= linha; coluna++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public void LacoMultiploDe3()
        {
            Console.WriteLine("Os números multiplos de 3 entre 1 e 100 são: ");

            for (int contador = 1; contador < 100; contador++)
            {
                if (contador %3 == 0)
                {                 
                    Console.WriteLine(contador);
                }
            }
        }

        public void LacoFatorial()
        {
            int fatorial = 1;

            for (int i = 1; i <= 10; i++)
            {
                fatorial *= i;
                Console.WriteLine("Fatorial de " + i + " = " + fatorial);
            }
        }

    }
}
