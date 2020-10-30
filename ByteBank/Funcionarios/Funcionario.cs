using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank;

namespace ByteBank.Funcionarios
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public double Salario { get; set; }


        //0 - Funcionario
        //1 - Diretor
        //2 - Designer
        private int _tipo;

        public Funcionario(int tipo)
        {
            _tipo = tipo;
        }


        public double GetBonificacao()
        {
       
            return Salario * 0.10;
        }



    }
}
