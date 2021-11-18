using System;

namespace SequenciaPares
{
    class Program
    {
        static void Main(string[] args)
        {

            int nInicial;
            int nInserido;

            Console.Write("Digite um número natural positivo: ");

            nInicial = 0;

            nInserido = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Números Pares entre {nInicial} e {nInserido}.");

            while(nInicial <= nInserido  )
            {
                if(nInicial % 2 == 0)
                {
                    Console.Write($" {nInicial} ");
                }
                nInicial = nInicial +1;
            }
        }
    }
}
