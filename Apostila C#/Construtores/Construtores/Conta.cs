using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construtores
{
    class Conta
    {
        private int numero;
        public int Numero { get; private set; }
        public double Saldo { get; private set; }
        public Cliente Titular { get; private set; }
        public bool Saca(double valor)
        {
            if (this.Saldo >= valor)
            {
                this.Saldo -= valor;
                return true;
            }

            return false;
        }
        public void Deposita(double valor)
        {
            this.Saldo += valor;
        }
        public void Transfere(double valor, Conta destino)
        {
            if (this.Saca(valor))
            {
                destino.Deposita(valor);
            }
        }
    }
}
