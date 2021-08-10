using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulamentoEModificadoresDeAcesso
{
    public class Conta
    {
        private int numero;
        //A declaração de uma propriedade é parecida com a declaração de um atributo, porém precisamos falar o que deve
        //ser feito na leitura (get) e na escrita (set) da propriedade
        /*public int Numero
        {
            get
            {
                //Código para ler a propriedade
                return this.numero;
            }
            set
            {
                //Código para escrever na propriedade
                //Dentro do bloco set, o valor que foi atribuído à propriedade fica dentro de uma variável chamada
                //value, então podemos implementar o set da seguinte forma:
                this.numero = value;
            }
            //Podemos também declarar uma propriedade que tem apenas o get, sem o set. Nesse caso, estamos declarando
            //uma propriedade que pode ser lida mas não pode ser escrita
        }*/

        //Auto-implemented properties
        public int Numero { get; private set; }
        //Esse código faz com que o compilador declare um atributo do tipo int e gere o código para a propriedade
        //Numero com um get e um set que leem e escrevem no atributo declarado. Ao utilizarmos as auto-implemented
        //properties, só podemos acessar o valor do atributo declarado através da propriedade

        //Toda vez que declaramos um auto-implemented property, precisamos sempre declarar um get e um set para a
        //propriedade, porém podemos controlar a visibilidade tanto do get quanto do set.
        public double Saldo { get; private set; }
        
        //A convenção de nomes definida para properties do C# é o Pascal Casing (Todas as palavras do nome são concatenadas
        //e cada palavra tem a inicial maiúscula

        //Atributos e métodos private são acessados apenas pela própria classe
        public Cliente Titular { get; private set; }

        //Contudo, agora temos outro problema.Se quisermos exibir o saldo não conseguiremos. O private bloqueia tanto
        //a escrita, quanto a leitura
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
        //Na orientação a objetos, esconder os detalhes de implementação de uma classe é um conceito conhecido como
        //encapsulamento. Como os detalhes da implementação da classe estão escondidos, todo o acesso deve ser feito
        //através dos seus métodos públicos
        
        //Para esconder um atributo, podemos modificar o acesso ao atributo para que ele seja privado, private


        //Como o private bloqueia a leitura, precisaremos de um novo método dentro da classe que nos devolverá o 
        //valor atual do atributo
        public double PegaSaldo()
        {
            return this.Saldo;
        }
        public void ColocaNumero(int numero)
        {
            this.numero = numero;
        }
        //Com isso nós conseguimos controlar todo o acesso a classe Conta, mas para escrevermos ou lermos o valor de
        //um atributo precisamos utilizar os métodos. O ideal seria utilizarmos uma sintaxe parecida com a de acesso
        //a atributos, porém com o controle que o método nos oferece. Para resolver esse problema o C# nos oferece
        //as properties(propriedades)


    }
}
