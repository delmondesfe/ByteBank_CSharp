using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario carlos = new Funcionario(1);

            carlos.Nome = "Carlos Almeida";
            carlos.CPF = "45401384807";
            carlos.Salario = 5000;

            Console.WriteLine(carlos.GetBonificacao());


            Diretor roberta = new Diretor();

            roberta.Nome = "Roberta";
            roberta.CPF = "45401384807";
            roberta.Salario = 10000;

            Console.WriteLine(roberta.GetBonificacao());


            Console.ReadLine();
        }
    }
}
