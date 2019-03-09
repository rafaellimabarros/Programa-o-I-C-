using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MetodosCalc
{
    class CalcCientifica : Calc
    {
       
        public void Raizes()
        {
            double raiz,i;
            Console.WriteLine("Digite seu numero");
            i = Convert.ToInt32(Console.ReadLine());
            raiz = i * i;
            Console.WriteLine("A raiz quadrada é {0}", raiz);
        }

    }
}
