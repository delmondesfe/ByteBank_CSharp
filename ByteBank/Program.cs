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

            Designer pedro = new Designer("45401384807");
            pedro.Nome = "Pedro";

            Diretor roberta = new Diretor("45401384807");
            roberta.Nome = "Roberta";

            Auxiliar igor = new Auxiliar("45401384807");
            igor.Nome = "Igor";

            GerenteDeConta camila = new GerenteDeConta("45401384807");
            camila.Nome = "Camila";

            


            gerenciadorBonificacao.Registrar(pedro);
            gerenciadorBonificacao.Registrar(roberta);
            gerenciadorBonificacao.Registrar(igor);
            gerenciadorBonificacao.Registrar(camila);

            Console.WriteLine("Total de bonificações "+ gerenciadorBonificacao.GetTotalBonificacao());


        }


    }
}
