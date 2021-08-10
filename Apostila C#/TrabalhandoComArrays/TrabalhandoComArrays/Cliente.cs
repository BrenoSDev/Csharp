using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhandoComArrays
{
    public class Cliente
    {
        private string cpf;

        public string Nome { get; set; }

        public Cliente(string nome)
        {
            this.Nome = nome;
        }
        public bool PodeAbrirContaSozinho
        {
            get
            {
                var maiorDeIdade = this.Idade >= 18;

                var possuiCPF = !string.IsNullOrEmpty(this.cpf);
                return (maiorDeIdade) && possuiCPF;
            }
        }

        public int Idade { get; set; }
    }
}
