using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista10Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            //Questão 01
            Console.WriteLine("Questão 01\n");
            Console.Write("1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20,\n21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40.\n");
            Console.Write("\n1, 2, 3, 4, 5, 6, 7, 8, 9, 10,");
            Console.Write("\n11, 12, 13, 14, 15, 16, 17, 18, 19, 20,");
            Console.Write("\n21, 22, 23, 24, 25, 26, 27, 28, 29, 30,");
            Console.Write("\n31, 32, 33, 34, 35, 36, 37, 38, 39, 40.\n");

            //Questão 02
            Console.WriteLine("\n \nQuestão 02");
            Console.WriteLine("\nA) Aparece x = 2");
            Console.WriteLine("\nB) Aparece O valor de X + X é 4");
            Console.WriteLine("\nC) Aparece X =");
            Console.WriteLine("\nD) Aparece 5 = 5");


            //Questão 03 
            Console.WriteLine("\n \nQuestão 03");
            Console.WriteLine("\nImprime os asteriscos com quantidade em ordem crescente e quebra de linha");

            //Questão 04
            Console.WriteLine("\n \nQuestão 04");
            Console.WriteLine("\nEscreve 4 asteriscos, escreve  mais 5 e quebra a linha, escreve mais 6 e quebra a linha ");           

            //Questão 07
            Console.WriteLine("\n \nQuestão 07\n");

            double raio = 5.0;
            double diametro = raio * raio;
            double circunferencia = 2.0 * 3.14 * raio;
            double area = 3.14 * (raio * raio);

            Console.WriteLine(raio + "\n");
            Console.WriteLine(diametro + "\n");
            Console.WriteLine(circunferencia + "\n");
            Console.ReadKey();
        }

        
        
    }
}
