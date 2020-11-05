using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            CalcularBonificacao();
            Console.ReadLine();
        }

        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            Funcionario pedro = new Designer("45401384807");
            pedro.Nome = "Pedro";

            Funcionario roberta = new Diretor("45401384807");
            roberta.Nome = "Roberta";

            Funcionario igor = new Auxiliar("45401384807");
            igor.Nome = "Igor";

            Funcionario camila = new GerenteDeConta("45401384807");
            camila.Nome = "Camila";

            


            gerenciadorBonificacao.Registrar(pedro);
            gerenciadorBonificacao.Registrar(roberta);
            gerenciadorBonificacao.Registrar(igor);
            gerenciadorBonificacao.Registrar(camila);

            Console.WriteLine("Total de bonificações "+ gerenciadorBonificacao.GetTotalBonificacao());


        }


    }
}
