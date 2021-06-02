using System;

namespace ExemploClasseObjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Ponto p1 = new Ponto();
            Ponto p2 = new Ponto(2, 4);
            p1.calcularDistancia(p2);

            Ponto3D p3 = new Ponto3D();
            Ponto3D p4 = new Ponto3D(2, 2, 2);
           
            p3.calcularDistancia3D(p4);

            Console.WriteLine("P3 X = {0:N}",p3.getX());

            float divisao = 0;
            Console.WriteLine("Antes do calculo {0:N}", divisao);
            p3.dividirXPorY(ref divisao);
            Console.WriteLine("Apos do calculo {0:N}", divisao);//representação de infinito para ponto flutuante 

            divisao = 0;
            Console.WriteLine("Antes do calculo {0:N}", divisao);
            p4.dividirXPorY(ref divisao);
            Console.WriteLine("Apos do calculo {0:N}", divisao);
        }
    }
}
