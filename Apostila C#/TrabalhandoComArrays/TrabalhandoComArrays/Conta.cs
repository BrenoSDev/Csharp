using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhandoComArrays
{
    public class Conta
    {
        public int Numero { get; set; }
        public double Saldo { get; protected set; }
        public Cliente Titular { get; set; }

        public int Tipo { get; set; }

        public Conta() { }

        public Conta(int numero)
        {
            this.Numero = numero;
        }

        public virtual void Deposita(double valor)
        {
            this.Saldo += valor;
        }
        public virtual bool Saca(double valor)
        {
            if (this.Saldo >= valor)
            {
                this.Saldo -= valor;
                return true;
            }
            return false;
        }
    }
    public class ContaPoupanca : Conta 
    {
        public override bool Saca(double valor)
        {
            if (base.Saca(valor + 0.10))
            {
                return true;
            }
            return false;
        }
    }
    public class TotalizadorDeContas
    {
        public double ValorTotal { get; private set; }
        public void Soma(Conta conta)
        {
            ValorTotal += conta.Saldo;
        }
    }
    public class ContaCorrente : Conta
    {
        public ContaCorrente(int numero) : base(numero) { }
        public override bool Saca(double valor)
        {
            if (base.Saca(valor + 0.05))
            {
                return true;
            }
            return false;
        }
        public override void Deposita(double valor)
        {
            base.Deposita(valor - 0.10);
        }
    }
}
