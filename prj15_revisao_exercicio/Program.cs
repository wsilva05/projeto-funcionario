using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj15_revisao_exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario func = new Funcionario();

            Console.Write("Informe o nome do funcionário(a): ");
            func.Colaborador = Console.ReadLine();

            Console.Write("Informe o cargo desse funcionário(a): ");
            func.Cargo = Console.ReadLine();

            Console.Write("Informe o salário desse funcionário(a): ");
            func.Salario = decimal.Parse(Console.ReadLine());

            Console.Write("Informe o percentual de desconto: ");
            func.Desconto = decimal.Parse(Console.ReadLine());

            /*
            Console.Write("{0} informe o valor de desconto: ", func.Colaborador);
            int desc = int.Parse(Console.ReadLine());
            Console.WriteLine(func.NovoSalario(desc));
            */

            Console.WriteLine();
            Console.WriteLine(func);

        }
    }
}
