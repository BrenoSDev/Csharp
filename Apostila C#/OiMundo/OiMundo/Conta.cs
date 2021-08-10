using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OiMundo
{
    class Conta
    {
        public int numero;
        public double saldo;
        public string titular;
        public int idade;

        public void Deposita(double valor)
        {
            this.saldo += valor;
        }
        public bool Saca(double valor)
        {
            if (this.idade < 18 && valor > 200) 
            {
                valor = 200.0;
            }
            if (this.saldo >= valor)
            {
                this.saldo -= valor;
                return true;
            }
            return false;
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
