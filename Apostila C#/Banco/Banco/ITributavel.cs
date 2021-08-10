using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    //Precisamos achar uma maneira de "achar um pai em comum" apenas para a ContaPoupanca e ContaInvestimento. 
    //Classes em C# não podem ter dois pais. Mas o que podemos fazer é dizer para o compilador que garantiremos
    //a existência do método CalculaTributo() nas classes que chegarem para o método Acumula(). Para fazer isso,
    //fazemos a classe assinar um contrato.Contratos no C# são conhecidos como interfaces. A declaração de uma
    //interface é praticamente igual a de uma classe, porém utilizamos a palavra interface
    //A convenção de nomes do C# para uma interface é seguir a mesma convenção de nomenclatura de classes porém
    //com um I no começo do nome
    public interface ITributavel
    {
        //É uma boa prática colocar o código da interface dentro de um arquivo separado com o mesmo nome da 
        //interface.
        //Dentro da interface, queremos colocar a declaração do método CalculaTributo(). Métodos declarados em
        //uma interface nunca possuem implementação e sempre são públicos
        double CalculaTributo();
    }
    //Podemos fazer com que uma classe assine uma interface sem herdar de outra classe
    //Interfaces são bem mais simples do que classes. Elas não tem atributos e seus métodos não tem implementação.
    //A interface apenas nos garante que o método existirá naquela classe. Por esse motivo, apesar de C# não 
    //suportar herança múltipla, podemos implementar quantas interfaces quisermos. Basta colocar uma na frente da 
    //outra

    //Quando uma classe utiliza tanto herança quanto interfaces, precisamos sempre declarar qual é a classe pai e 
    //depois as interfaces
}
