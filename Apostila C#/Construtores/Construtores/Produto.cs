using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construtores
{
    class Produto
    {
        public string Descricao { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }
        public string Fornecedor { get; set; }

        //Para definirmos um valor opcional no construtor, precisamos declarar o parâmetro e atribuir qual será o valor padrão
        public Produto (string descricao = "Sem descrição", string nome = "Sem nome", decimal preco=0.0m, int quantidade=0, string fornecedor="Sem fornecedor")
        {
            this.Descricao = descricao;
            this.Nome = nome;
            this.Preco = preco;
            this.Quantidade = quantidade;
            this.Fornecedor = fornecedor;
        }
    }
}
