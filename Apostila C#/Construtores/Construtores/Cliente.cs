using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construtores
{
    class Cliente
    {
        //O comportamento de passar argumentos para um objeto recebe o nome de construtor
        public string Nome { get; set; }
        public string cpf;
        public string rg;
        public string endereco;
        public int Idade { get; set; }

        //Construtor 
        public Cliente (string nome="Sem nome")
        {
            this.Nome = nome;
        }

        //Construtor que recebe o nome e a idade
        public Cliente (int idade, string nome="Sem nome")
        {
            this.Nome = nome;
            this.Idade = idade;
        }
        //Quando colocamos diversas versões do construtor dentro de uma classe, estamos fazendo uma sobrecarga de 
        //construtores

        //No C#, ao invés de fazermos sobrecarga de construtores para podermos passar informações adicionais na criação
        //do objeto, podemos utilizar os parâmetros opcionais com valores padrão

        public bool EhMaiorDeIdade()
        {
            if (this.Idade >= 18)
            {
                return true;
            }
            return false;
        }
    }
}
