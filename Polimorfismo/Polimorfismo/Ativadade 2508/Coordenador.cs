using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo.Ativadade_2508
{
    class Coordenador:Colaborador
    {
        public override void CalcularSalario(double salario)
        {
            double result = salario * 0.11;
            Console.WriteLine("O desconto padrão do coordenador é de: " + result);
        }
    }
}
