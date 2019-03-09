using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosCalc
{
   public class Calc
    {
        public void Somar()
        {
            double soma, n1, n2;

            Console.WriteLine("Digite seu número");
            n1 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Digite seu número");
            n2 = Convert.ToInt32(Console.ReadLine());

            soma = n1 + n2;

            Console.WriteLine("O resultado da soma e {0}", soma);

        }
        public void Subtrair()
        {
            double sub, n1, n2;

            Console.WriteLine("Digite seu número");
            n1 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Digite seu número");
            n2 = Convert.ToInt32(Console.ReadLine());

            sub = n1 - n2;


            Console.WriteLine("O resultado da subtração e {0}", sub);
        }

    }
}
