using Polimorfismo.Atividade2508;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite o Valor do Saque");
            double saque = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Poupança -----------");
            Poupanca poupanca = new Poupanca();

            poupanca.CalcularImposto(saque);
            Console.WriteLine();

            Console.WriteLine("Corrente -----------");
            Corrente corrente = new Corrente();

            corrente.CalcularImposto(saque);

            Console.ReadKey();
        }
    }
}
