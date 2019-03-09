using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cauculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            int menu = 0;
            Calc c1 = new Calc();
            Clac c2 = new Calc();



            Console.WriteLine("1 - Soma, 2 - Subtrair");
            menu = Convert.ToInt32(Console.ReadLine());
            switch (menu) {
                case 1: c1.somar();
                    break;

                case 2: c2.Subtrair();
                    break;

                 }
            Console.ReadKey();
        }
    }
}
