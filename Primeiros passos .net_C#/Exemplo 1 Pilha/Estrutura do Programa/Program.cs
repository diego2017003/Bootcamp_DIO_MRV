using System;

namespace Estrutura_do_Programa
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Pilha();
            p.Empilha(1);
            p.Empilha(10);
            p.Empilha(100);
            Console.WriteLine(p.Desempilha());
            Console.WriteLine(p.Desempilha());
            Console.WriteLine(p.Desempilha());
        }
    }
}
