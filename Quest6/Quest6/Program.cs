using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quest6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[3];
            Console.WriteLine("Popule os arrays");
            for (int i=0; i < numeros.Length; i++)
            {
                numeros[i] = Convert.ToInt32(Console.ReadLine());

            }
            double soma = 0;
            for (int i=0;i < numeros.Length;i++)
            {
                soma = soma + numeros[i];

            }
            double media = (soma) / 3;

            Console.WriteLine("A media dos arrays é {0}", media);
            Console.ReadKey();
        }
    }
}
