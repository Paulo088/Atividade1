using System;
using System.Collections.Generic;
using System.Text;

namespace Atividade1
{
    public abstract class Conta
    {
        private decimal saldo;
        private string titular;

        public Conta(string t)
        {
            titular = t;
        }
        public  decimal Saldo
        {
            get { return saldo;}
        }
        public string Titular
        {
            get {return titular; }
        }
        public virtual string ID
        {
            get;
        }

        public virtual void Depositar(decimal valor)
        {
            saldo += valor;
        }
        public virtual void Sacar(decimal valor)
        {
            if(valor <= saldo)
            {
                saldo -= valor;
            }
        }





    }
}
