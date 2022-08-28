using System;

namespace md05_CadernoExercicios_01
{
    class Program
    /*
     1. Faça um algoritmo que faça a união de dois vetores de mesmo tamanho e
        mesmo tipo em um terceiro vetor com dobro do tamanho.

     */
    {
        static void Main(string[] args)
        {
            /* double[] v = new double[3];
             Console.WriteLine("Digite um número:");
             v[0] = Convert.ToDouble(Console.ReadLine());
             v[1] = v[0] *2;
             v[2] = v[1] * 2;
             Console.WriteLine("\nVetor 1 - {0}\nVetor 2 - {1}\nVetor 3 - {2}", v[0].ToString("0.0"),
                 v[1].ToString("0.0"),v[2].ToString("0.0"));
            */
            double[] v = new double[3];
            Console.WriteLine("Digite um número para o primeiro Vetor:");
            v[0] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite um número para o Segundo Vetor:");
            v[1] = Convert.ToDouble(Console.ReadLine());
            v[2] = (v[0] + v[1]) * 2;
            Console.WriteLine("\nVetor 1 - {0}\nVetor 2 - {1}\nVetor 3 - {2}", v[0].ToString("0.0"),
                v[1].ToString("0.0"), v[2].ToString("0.0"));
        }
    }
}
