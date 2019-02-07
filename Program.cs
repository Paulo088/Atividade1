using System;
using System.Collections.Generic;
using System.Globalization;

namespace Atividade1
{
    class Program
    {
        public static void Main( String [] args) {

            Banco banco = new Banco();
            banco.Nome = "Bradesco";
            banco.Agencias = new List<Agencia>();
            banco.Clientes = new List<Cliente>();

            Agencia a = new Agencia();
            a.NumeroAgencia = "001";
            a.Contas = new List<Conta>();
            banco.Agencias.Add(a);

            a = new Agencia();
            a.NumeroAgencia = "002";
            a.Contas = new List<Conta>();
            banco.Agencias.Add(a);

            while (true)
            {
                Console.WriteLine("Digite a opcao desejada.");
                Console.WriteLine("1 - Abrir conta");
                Console.WriteLine("2 - Consultar saldo");
                Console.WriteLine("3 - Depositar");
                Console.WriteLine("4 - Sacar");
                Console.WriteLine("0 - Sair");

                int op = int.Parse(Console.ReadLine());
                Console.WriteLine(op);
                if (op == 0)
                {
                    break;
                }

                if (op == 1)
                {
                    Console.WriteLine("Informe o nummero da agencia:");
                    string nAgencia = Console.ReadLine();

                    if (banco.VerificarAgencia(nAgencia)) 
                    {
                        Agencia ag = null;
                        foreach (Agencia agencia in banco.Agencias)
                        {
                            if (agencia.NumeroAgencia.Equals(nAgencia))
                            {
                                ag = agencia;
                                break;
                            }
                        }
                        Console.WriteLine("1 - Conta corrente\n2 - Conta Poupanca");
                        op = int.Parse(Console.ReadLine());
                        if (op == 1)
                        {
                            Console.WriteLine("Nome do titular:");
                            string nome = Console.ReadLine();
                            Console.WriteLine("Cpf do titular:");
                            string cpf = Console.ReadLine();
                            Cliente c = new Cliente();
                            c.Nome = nome;
                            c.Cpf = cpf;
                            banco.Clientes.Add(c);
                            ContaCorrente cc = new ContaCorrente(nome);
                            ag.Contas.Add(cc);
                        } else if (op == 2)
                        {
                            Console.WriteLine("Nome do titular:");
                            string nome = Console.ReadLine();
                            Console.WriteLine("Cpf do titular:");
                            string cpf = Console.ReadLine();
                            Console.WriteLine("Data de nascimento do titular:");
                            string data = Console.ReadLine();
                            DateTime dt = DateTime.ParseExact(data, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                            Cliente c = new Cliente();
                            c.Nome = nome;
                            c.Cpf = cpf;
                            banco.Clientes.Add(c);
                            ContaPoupanca cp = new ContaPoupanca(0.02M, dt, nome);
                            ag.Contas.Add(cp);
                        }
                        continue;
                    } else
                    {
                        Console.WriteLine("Agencia nao encontrada.");
                        continue;
                    }
                }
                else if (op == 2)
                {
                    Console.WriteLine("Informe o nome do titular:");
                    string nome = Console.ReadLine();

                    if (banco.VerificarCliente(nome))
                    {
                        Console.WriteLine("Informe o nummero da agencia:");
                        string nAgencia = Console.ReadLine();

                        if (banco.VerificarAgencia(nAgencia)) 
                        {
                            Agencia ag = null;
                            foreach (Agencia agencia in banco.Agencias)
                            {
                                if (agencia.NumeroAgencia.Equals(nAgencia))
                                {
                                    ag = agencia;
                                    break;
                                }
                            }

                            Conta c = null;
                            foreach (Conta conta in ag.Contas)
                            {
                                if (conta.Titular.Equals(nome))
                                {
                                    c = conta;
                                    break;
                                }
                            }
                            Console.WriteLine("Saldo: " + c.Saldo);
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("Agencia nao encontrada.");
                            continue;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Nome incorreto.");
                        continue;
                    }
                }
                else if (op == 3)
                {
                    Console.WriteLine("Informe o nome do titular:");
                    string nome = Console.ReadLine();

                    if (banco.VerificarCliente(nome))
                    {
                        Console.WriteLine("Informe o nummero da agencia:");
                        string nAgencia = Console.ReadLine();

                        if (banco.VerificarAgencia(nAgencia)) 
                        {
                            Agencia ag = null;
                            foreach (Agencia agencia in banco.Agencias)
                            {
                                if (agencia.NumeroAgencia.Equals(nAgencia))
                                {
                                    ag = agencia;
                                    break;
                                }
                            }

                            Conta c = null;
                            foreach (Conta conta in ag.Contas)
                            {
                                if (conta.Titular.Equals(nome))
                                {
                                    c = conta;
                                    break;
                                }
                            }

                            Console.WriteLine("Valor a ser depositado:");
                            decimal valor = decimal.Parse(Console.ReadLine());

                            c.Depositar(valor);
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("Agencia nao encontrada.");
                            continue;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Nome incorreto.");
                        continue;
                    }
                }
                else if (op == 4)
                {
                    Console.WriteLine("Informe o nome do titular:");
                    string nome = Console.ReadLine();

                    if (banco.VerificarCliente(nome))
                    {
                        Console.WriteLine("Informe o nummero da agencia:");
                        string nAgencia = Console.ReadLine();

                        if (banco.VerificarAgencia(nAgencia)) 
                        {
                            Agencia ag = null;
                            foreach (Agencia agencia in banco.Agencias)
                            {
                                if (agencia.NumeroAgencia.Equals(nAgencia))
                                {
                                    ag = agencia;
                                    break;
                                }
                            }

                            Conta c = null;
                            foreach (Conta conta in ag.Contas)
                            {
                                if (conta.Titular.Equals(nome))
                                {
                                    c = conta;
                                    break;
                                }
                            }

                            Console.WriteLine("Valor a ser sacado:");
                            decimal valor = decimal.Parse(Console.ReadLine());

                            c.Sacar(valor);
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("Agencia nao encontrada.");
                            continue;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Nome incorreto.");
                        continue;
                    }
                }
            }
        }
    }
}
