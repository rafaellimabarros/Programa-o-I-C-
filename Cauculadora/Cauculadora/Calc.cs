using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cauculadora
{
   public class Calc
    {
        public void somar()
        {
            double soma,n1,n2;
            Console.WriteLine("Digite seu primeiro numero");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite seu segundo numero");
            n2 = Convert.ToInt32(Console.ReadLine());
            soma = n1 + n2;

            Console.WriteLine("Sua soma é {0}", soma);
        }

    public void Subtrair(){
        double sub,n1,n2;
          Console.WriteLine("Digite seu primeiro número");
         n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite seu segundo número");
            n2 = Convert.ToInt32(Console.ReadLine());
        sub = n1 - n2;
        Console.WriteLine("Resultado = {0}",sub);
        }

    }
}

