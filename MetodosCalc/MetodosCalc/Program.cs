using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            int menu = 0;
            Calc c1 = new Calc();
            CalcCientifica c2 = new CalcCientifica();

            Console.WriteLine(" Calculadora 2000");
            Console.WriteLine("       1.Somar      2.Subtrair");
            menu = Convert.ToInt32(Console.ReadLine());

            switch (menu)
            {
                case 1: c1.Somar();
                    break;

                case 2: c1.Subtrair();
                    break;

                case 3: c2.Raizes();
                    break;
            }
            
            
            Console.ReadKey();

        }
    }
}
