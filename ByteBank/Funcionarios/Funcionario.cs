using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ByteBank.Funcionarios
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public double Salario { get; set; }

        private int _tipo;


        //0 - Funcionario
        //1 - Diretor
        //2 - Designer


        //public Funcionario(int tipo)
        //{
        //    this._tipo = tipo;
        //}


        public virtual double GetBonificacao()
        {
       
            return Salario * 0.10;
        }



    }
}
