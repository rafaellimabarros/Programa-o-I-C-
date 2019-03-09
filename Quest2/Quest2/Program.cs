using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quest2
{
    class Program
    {
        static void Main(string[] args)
        {
          
            ContaBanco c1 = new ContaBanco();

            Console.WriteLine("Digite o numero da conta");
            c1.numero = Console.ReadLine();

            Console.WriteLine("Digite o saldo");
            c1.saldo = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite o limite");
            c1.limite = Console.ReadLine();

            Console.WriteLine("AÇÔES, 1.Depositar");

            c1.depositar();

            Console.WriteLine("Seu saldo atual é {0}", c1.saldo);

            Console.ReadKey();
        }
    }
}
