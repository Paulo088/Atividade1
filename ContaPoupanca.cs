using System;
using System.Collections.Generic;
using System.Text;

namespace Atividade1
{
    public class ContaPoupanca : Conta
    {
        public const decimal JUROS = 0.1M;

        private decimal taxaJuros;
        private DateTime dataAniversario;


        public ContaPoupanca(decimal j, DateTime d, string t) : base(t)
        {
            taxaJuros = j;
            dataAniversario = d;

        }

        public decimal Juros
        {
            get { return taxaJuros; }
            set { taxaJuros = value; }
        }

        public DateTime DataAniversario
        {
            get { return dataAniversario; }
        }
        public void AdcionarRendimentos()
        {
            if (DateTime.Now.Equals(dataAniversario)){
                decimal rendimento;
                rendimento = Saldo * taxaJuros;
                Depositar(rendimento);
            }
        }
        public override string ID
        {
            get { return Titular + "(CP)"; }
        }



    }
}

