using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excecoes
{
    public abstract class Conta
    {
        public int Numero { get; set; }
        public double Saldo { get; protected set; }
        public Cliente Titular { get; set; }

        public int Tipo { get; set; }

        private static int numeroDeContas;

        public Conta()
        {
            Conta.numeroDeContas++;
            this.Numero = Conta.numeroDeContas;
        }
        public static int ProximoNumero()
        {
            return Conta.numeroDeContas + 1;
        }
        public Conta(int numero)
        {
            this.Numero = numero;
        }

        public virtual void Deposita(double valor)
        {
            this.Saldo += valor;
        }
        public virtual void Saca(double valor)
        {
            if (this.Saldo >= valor)
            {
                this.Saldo -= valor;
            }
        }
    }
    public class ContaPoupanca : Conta
    {
        public override void Saca(double valor)
        {
            if (valor < 0.0)
            {
                //Repare que, para jogarmos a exceção, precisamos executar um new, ou seja, a Exception é uma
                //classe do C#. Podemos criar uma hierarquia de exceções utilizando a herança para indicar qual
                //foi o tipo de erro que ocorreu
                throw new ArgumentException();
            }
            if (valor+0.10 > this.Saldo)
            {
                //E vamos utilizar o SaldoInsuficienteException no método Saca da classe ContaPoupanca
                throw new SaldoInsuficienteException();
            }
            else
            {
                this.Saldo -= valor + 0.10;
            }
        }
    }
    //Para criarmos um novo tipo de exceção, precisamos apenas criar uma nova classe que herde de Exception.
    public class SaldoInsuficienteException : Exception
    {

    }
}
