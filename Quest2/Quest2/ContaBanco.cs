using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quest2
{
    class ContaBanco
    {
        public string numero { get; set; }
        public string limite { get; set; }
        public decimal saldo { get; set; }
        public decimal valor { get; set; }

        public void depositar ()
        {
            Console.WriteLine("Seu saldo atual é de {0}", this.saldo);

            Console.WriteLine("Por favor insira o valor que deseja depositar em sua conta");
            valor = Convert.ToDecimal(Console.ReadLine());

            this.saldo = saldo + valor;

        }
             
    }
}
