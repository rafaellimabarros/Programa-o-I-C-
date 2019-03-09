using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quest3
{
    class Program
    {
        static void Main(string[] args)
        {
            FuncionarioBanco f1 = new FuncionarioBanco();
            FuncionarioBanco f2 = new FuncionarioBanco();

            Console.WriteLine("Digite o nome do funcionário");
            f1.nome = Console.ReadLine();

            f1.salario = 200;

            int acoes;
            Console.WriteLine("-------AÇÕES-------");
            Console.WriteLine("1.Todos os funcionarios");
            Console.WriteLine("2.Alterar nome e salario do funcionario");
            Console.WriteLine("3. adicionar novo funcionário");
            Console.WriteLine("4. Sair");

            acoes = Convert.ToInt32(Console.ReadLine());
            switch (acoes)
                {
                    case 1:
                        Console.WriteLine("Nome {0} e Salário R$ {1}", f1.nome, f1.salario);

                        break;
                    case 2:
                        Console.WriteLine("Alterar nome e o salário do funcionario {0}",f1.nome);
                        Console.WriteLine("Digite o novo nome do funcionário {0}",f1.nome);
                        f1.nome = Console.ReadLine();
                        Console.WriteLine("Digite o novo salário do funcionário {0}", f1.nome);
                        f1.salario = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine("Ola {0} seu salário é R$ {1}", f1.nome, f1.salario);

                    break;
                    case 3:
                    Console.WriteLine("Digite o nome do funcionário");
                    f2.nome = Console.ReadLine();

                    f2.salario = 200;

                    break;
                case 4:
                        break;
                }
            Console.Clear();
            Console.ReadKey();
        }
    }
}
