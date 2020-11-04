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

            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();
            
            
            Funcionario carlos = new Funcionario();

            carlos.Nome = "Carlos Almeida";
            carlos.CPF = "45401384807";
            carlos.Salario = 5000;

            gerenciador.Registrar(carlos);

            Console.WriteLine(carlos.GetBonificacao());


            Funcionario roberta = new Diretor();

            roberta.Nome = "Roberta";
            roberta.CPF = "45401384807";
            roberta.Salario = 10000;

            gerenciador.Registrar(roberta);
            Console.WriteLine(roberta.GetBonificacao());

            
            Console.WriteLine("");
            Console.WriteLine("Valor total de bonificações dos funcionarios: "+ gerenciador.GetTotalBonificacao());


            Console.ReadLine();
        }
    }
}
