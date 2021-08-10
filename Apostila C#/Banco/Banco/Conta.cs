using System;

namespace Banco.Contas
{
    //Conta é apenas uma ideia em nosso domínio, uma forma genérica de referenciarmos os dois tipos de conta que 
    //realmente existem em nosso sistema, ContaCorrente e ContaPoupanca. Podemos evitar a criação de objetos do 
    //tipo Conta definindo a classe como abstrata: abstract

    //Desta forma, não podemos mais criar objetos do tipo Conta, mas podemos ainda usar variáveis do tipo conta, para
    //referenciar objetos de outros tipos
    //Podemos ter uma classe abstrata sem nenhum método abstrato, mas não o contrário. Se a classe tem pelo menos um 
    //método abstrato, ela deve ser abstrata também pois como o método está incompleto, a classe não está completa
    public abstract class Conta
    {
        public int Numero { get; set; }
        //O atalho para a declarar uma nova propriedade pública é digitar prop e apertar a tecla tab duas vezes
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

        //Uma solução seria para reaproveitar código com herança seria ter classes separadas para Conta (que é a corrente)
        //e ContaPoupança

        //Podemos obrigar todas as classes filhas a sobrescreverem um método na classe mãe, basta declarar esse método
        //com o modificador abstract ao invés de virtual. Toda vez que marcamos um método com o modificador abstract, 
        //ele obrigatoriamente não pode ter uma implementação padrão
        /*public abstract void Saca (double valor); */

        //Com essa modificação, o método Saca passa a representar apenas uma ideia, que precisa de uma implementação 
        //concreta nas classes filhas
        public virtual void Saca(double valor)
        {
            if (this.Saldo >= valor)
            {
                this.Saldo -= valor;
            }
        }
        public virtual bool Transfere (Conta destino, double valor)
        {
            try
            {
                this.Saca(valor);
                destino.Deposita(valor);
                return true;
            } catch (SaldoInsuficienteException ex)
            {
                return false;
            }
        }

        public override bool Equals(object obj)
        {
            if (obj is Conta)
            {
                Conta outraConta = (Conta)obj;
                return this.Numero == outraConta.Numero;
            }
            return false;
        }
        //Atalho para criar um construtor: digita ctor e aperta a tecla tab duas vezes
    }
    /*public class ContaPoupanca
    {
        //Ambas as classes possuem código bem simples, mas agora o problema é outro: a repetição de código entre ambas as
        //classes.
        //A ideia é, portanto, reaproveitar código. Veja que, no fim, uma ContaPoupanca é uma Conta, pois ambos tem 
        //Numero, Saldo e Titular. A única diferença é o comportamento no momento saque
        public int Numero { get; set; }
        public double Saldo { get; private set; }
        
        public Cliente Titular { get; set; }

        public void Saca (double valor)
        {
            this.Saldo -= (valor + 0.10);
        }
        public void Deposita (double valor)
        {
            this.Saldo += valor;
        }
    }*/

    //Queremos fazer com que a conta poupança assine o contrato ITributavel que acabamos de criar, para isso, 
    //precisamos colocar o nome da interface que queremos implementar logo após a declaração da classe pai
    public class ContaPoupanca:Conta, ITributavel
    {
        //Quando uma classe é definida com o :, dizemos que ela herda da outra e por isso ela ganha todos os atributos e 
        //métodos da outra classe
        //Dizemos que a classe ContaPoupanca é uma subclasse ou classe filha da classe Conta e que Conta é uma classe base
        //ou classe pai da ContaPoupanca

        //Mas a ContaPoupanca tem o comportamento de Saca() diferente. Para isso, basta reescrever o comportamento na classe
        //filha, usando a palavra override e mudando a classe pai para indicar que o método pode ser sobrescrito (virtual)
        public override void Saca(double valor)
        {
            //Quando fazemos a sobrescrita de métodos em uma classe filha, muitas vezes, queremos apenas mudar leveemnte
            //o comportamento da classe base. Nessas situações, no código da classe filha, podemos reutilizar o código
            //da classe pai com a palavra base chamando o comportamento que queremos reaproveitar
            if (valor < 0.0)
            {
                throw new ArgumentException();
            }
            if (valor + 0.10 > this.Saldo)
            {
                throw new SaldoInsuficienteException();
            }
            else
            {
                base.Deposita(valor + 0.10);
            }

            //Repare que o método Saca() da ContaPoupanca manipula o Saldo. Mas Saldo é privado! Atributos privados 
            //só são visíveis para a classe que os declarou. Os filhos não enxergam
            //Para resolver, alteraremos o modificador de acesso para protected. Atributos/métodos marcados como 
            //protected são visíveis apenas para a própria classe e para as classes filhas

        }
        public double CalculaTributo()
        {
            //Repare que, para implementarmos o método da interface, não podemos utilizar a palavra override, ela é 
            //reservada para a sobrescrita de métodos da Herança
            return this.Saldo * 0.02;
        }

        public override void Deposita(double valor)
        {
            if (valor < 0.0)
            {
                throw new ArgumentException();
            }
            else
            {
                base.Deposita(valor);
            }
        }
    }
    public class TotalizadorDeContas
    {
        public double ValorTotal { get; private set; }
        public void Soma (Conta conta)
        {
            //Essa ideia de uma variável conseguir referenciar seu próprio tipo ou filhos desse tipo é conhecido por 
            //polimorfismo
            ValorTotal += conta.Saldo;
        }
    }
    public class ContaCorrente:Conta, ITributavel
    {
        //Os construtores da classe pai não são herdados. Então se a classe filha precisa de um construtor que está
        //na classe pai, ela deve explicitamente declarar esse construtor em seu código
        /*public ContaCorrente(int numero)
        {
            this.Numero = numero;
        }*/

        //Ao invés de repetirmos o código da classe pai, podemos simplesmente chamar o construtor que foi declarado
        //na classe Conta a partir do construtor da classe ContaCorrente utilizando a palavra base
        public ContaCorrente(int numero) : base (numero) { }
        private static int totalDeContas = 0;
        public ContaCorrente()
        {
            ContaCorrente.totalDeContas++;
        }
        public static int ProximaConta()
        {
            return ContaCorrente.totalDeContas + 1;
        }
        public override void Saca(double valor)
        {
            if (valor <0.0)
            {
                throw new ArgumentException();
            }
            if (valor + 0.05 > this.Saldo)
            {
                throw new SaldoInsuficienteException();
            }
            else
            {
                base.Saca(valor + 0.05);
            }
        }
        public override void Deposita(double valor)
        {
            if (valor <0.0)
            {
                throw new ArgumentException();
            }
            else
            {
                base.Deposita(valor - 0.10);
            }
            
        }
        public double CalculaTributo()
        {
            return this.Saldo * 0.05;
        }
    }
    public class ContaInvestimento:Conta, ITributavel
    {
        public double CalculaTributo()
        {
            return this.Saldo * 0.03;
        }
    }
    public class TotalizadorDeTributos
    {
        //A próxima funcionalidade é a geração de um relatório, no qual devemos imprimir a quantidade total de 
        //tributos pagos por todas as Contas Investimento ou Poupança do nosso banco.
        public double Total { get; private set; }

        //Dessa forma, podemos dizer que a classe TotalizadorDeTributos recebe um ITributavel qualquer. O polimorfismo
        //funciona com interfaces
        public void Acumula(ITributavel t)
        {
            Total += t.CalculaTributo();
        }
    }
    public class SaldoInsuficienteException: Exception { }
}