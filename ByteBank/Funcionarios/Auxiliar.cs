using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    class Auxiliar : Funcionario
    {
        public Auxiliar(String cpf) : base(2000,cpf)
        {
           
        }

        public override double GetBonificacao()
        {
            return Salario * 0.2;
        }

        public override void AumentaSalario()
        {
            Salario *= 1.1;
        }

    }
}
