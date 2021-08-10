using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesEObjetos
{
    class Conta
    /*Quando criamos uma classe, a recomendação é usar o Pascal Casing para nomear a classe:
     *Se o nome da classe é composto por uma única palavra, colocamos a primeira letra dessa palavra em maiúscula
     *Se o nome é composto por diversas palavras, juntamos todas as palavras colocando a primeira letra de cada palavra em maiúscula*/
    /*No caso do nome de métodos, a convenção também é utilizar o Pascal Casing*/

    /*Para argumentos de métodos, a convenção é utilizar o Pascal Casing porém com a primeira letra em minúscula
     (valorDoSaque), uma convenção chamada Camel Casing*/
    {
        //Dentro do C# a declaração da classe é feita utilizando-se a palavra class seguida do nome da classe
        //que queremos implementar

        //As variáveis que declaramos dentro de uma classe são chamadas de atributos
        public int numero;
        public double saldo;
        //A palavra public faz com que as variáveis possam ser usadas pela aplicação

        //Além de atributos, os objetos também podem possuir métodos. Os métodos são blocos de código que isolam
        //lógicas de negócio do objeto.

        public Cliente titular;
        public bool Saca(double valor)  //O argumento é uma variável declarada dentro dos parênteses do método
        {
            //Um método pode ter qualquer número de argumentos. Precisamos apenas separar a declaração das variáveis
            //com uma vírgula
            //Implementação do método

            //Para acessarmos a referência em que um determinado método foi chamado, utilizamos a palavra this
            if (this.saldo >= valor)
            {
                this.saldo -= valor;
                return true;
            }
            
            return false;
            //Dentro da implementação do método, devolvemos um valor utilizando a palavra return seguida do
            //valor que deve ser devolvido

            //Quando um método devolve um valor, o tipo do valor devolvido deve ficar antes do nome do método
            //em sua declaração. Quando um método não devolve valor algum, utilizamos o tipo void.
        }
        public void Deposita(double valor)
        {
            this.saldo += valor;
        }
        public void Transfere(double valor, Conta destino)
        {
            //Implementação da transferência
            /*if (this.saldo >= valor)
            {
                this.saldo -= valor;
                destino.saldo += valor;
            }*/
            //Os comportamentos de verificar se a conta tem saldo suficiente antes de realizar o saque e de
            //somar um valor ao saldo são os comportamentos dos métodos Saca e Deposita, então podemos utiliza-los:
            if (this.Saca(valor))
            {
                destino.Deposita(valor);
            }
        }

    }
}
