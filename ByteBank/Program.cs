﻿using ByteBank.Funcionarios;
using ByteBank.Sistemas;
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
            UsarSistema();

            //CalcularBonificacao();
            Console.ReadLine();
        }

        public static void UsarSistema()
        {
            SistemaInterno sistemaInternt = new SistemaInterno();
            Diretor Roberta = new Diretor("45401384807");
            Roberta.Nome = "Roberta";
            Roberta.Senha = "123456";

            GerenteDeConta Camila = new GerenteDeConta("45401384807");
            Camila.Nome = "Camila";
            Camila.Senha = "123";


            ParceiroComercial parceiro = new ParceiroComercial();
            parceiro.Senha = "123";
            

            sistemaInternt.Logar(Camila, "123");
            sistemaInternt.Logar(Roberta, "123456");
            sistemaInternt.Logar(parceiro, "123");
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

            Funcionario felipe = new Auxiliar("45401384807");
            felipe.Nome = "Felipe";

            
            gerenciadorBonificacao.Registrar(pedro);
            gerenciadorBonificacao.Registrar(roberta);
            gerenciadorBonificacao.Registrar(igor);
            gerenciadorBonificacao.Registrar(camila);
            gerenciadorBonificacao.Registrar(felipe);

            Console.WriteLine("Total de bonificações "+ gerenciadorBonificacao.GetTotalBonificacao());

        }


    }
}
