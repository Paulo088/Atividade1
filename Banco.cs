using System;
using System.Collections.Generic;
using System.Text;

namespace Atividade1
{
    class Banco
    {
        private List<Agencia> agencias = new List<Agencia>();
        private List<Cliente> clientes = new List<Cliente>();

        public string Nome { get; set; }
        public List<Agencia> Agencias { get; set; }
        internal List<Cliente> Clientes { get; set; }

        public bool VerificarAgencia(string agencia)
        {
            foreach(Agencia a in Agencias)
            {
                if (agencia.Equals(a.NumeroAgencia))
                {
                    return true;
                }
            }
            return false;
        }
        public bool VerificarCliente(string nome)
        {
            foreach(Cliente c in Clientes)
            {
                if (nome.Equals(c.Nome))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
