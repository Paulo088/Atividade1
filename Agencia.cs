using System;
using System.Collections.Generic;
using System.Text;

namespace Atividade1
{
    class Agencia
    {
        private List<Conta> contas = new List<Conta>();

        public List<Conta> Contas { get; set; }

        public string NumeroAgencia { get; set; }

        public bool VerificarConta(string conta)
        {
            foreach (Conta c in Contas)
            {
                if (conta.Equals(c.ID))
                {
                    return true;
                }

            }
            return false;
        }
    }
}
