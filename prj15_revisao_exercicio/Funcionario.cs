using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj15_revisao_exercicio
{
    class Funcionario
    {
        public string Colaborador { get; set; }
        public string Cargo { get; set; }
        public decimal Salario { get; set; }
        public decimal Desconto { get; set; }
        
        /*
        public decimal NovoSalario(decimal desc)
        {
            novoSalario = Salario - (desc / 100 * Salario);
            return novoSalario;
        }
        */
     
        public override string ToString()
        {
            return string.Format("{0} {1} tem um salário bruto de R${2}, com desconto de {3}%, salário será atualizado para R${4}.",
                Cargo, Colaborador, Salario, Desconto.ToString("f2", CultureInfo.InvariantCulture),
                Salario - ((decimal)Desconto / 100 * Salario) );
        }
        
    }
}
