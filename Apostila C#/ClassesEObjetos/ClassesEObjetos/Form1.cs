using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassesEObjetos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Para utilizarmos a classe que criamos, precisamos criar uma nova conta no código do formulário
            //Fazemos isso usando a instrução new

            //Quando utilizamos o new dentro do código de uma classe estamos pedindo para o C# criar uma nova
            //instância de Conta na memória
            //Além disso, o new possui mais uma função, devolver a referência, uma seta que aponta para o objeto
            //em memória, que será utilizada para manipularmos a Conta criada. Podemos guardar essa referência
            //dentro de uma variável do tipo Conta

            Conta c = new Conta();

            //Para definirmos os valores dos atributos que serão armazenados na Conta, precisamos acessar o 
            //objeto que vive na memória. Fazemos isso utilizando o operador . do C#, informando qual é 
            //o atributo que queremos acessar
            c.numero = 1;
            c.Deposita(100.0);

            //Chamando o método Saca
            c.Saca(10.0);
            //Quando queremos passar um valor para um método, precisamos passar esse valor dentro dos parênteses
            //da chamada do método

            //Recuperando um valor devolvido pelo return
            bool deuCerto = c.Saca(100.0);

            if (deuCerto)
            {
                MessageBox.Show("Saque realizado com sucesso!");
            }
            else
            {
                MessageBox.Show("Saldo Insuficiente!"); 
            }

            //Utilizando o retorno do método diretamente do if
            if (c.Saca(100.0))
            {
                MessageBox.Show("Saque realizado com sucesso!");
            }
            else
            {
                MessageBox.Show("Saldo Insuficiente!");
            }

            /*Quando declaramos uma variável no C#, ela começa com um valor indefinido, logo não podemos 
             utiliza-la enquanto seu valor não for inicializado, porém a linguagem trata os atributos de
            uma classe de forma diferenciada. Quando instanciamos uma classe, todos os seus atributos são
            inicializados para valores padrão. Valores numéricos são inicializados para zero, o bool é 
            inicializado para false e atributos que guardam referências são inicializados para a referência
            vazia (valor null do C#)*/

            Conta breno = new Conta();
            breno.saldo = 1000;

            Conta guilherme = new Conta();

            //Usando o método transfere
            breno.Transfere(10.0, guilherme);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cliente victor = new Cliente();
            victor.nome = "victor";
            Conta umaConta = new Conta();
            umaConta.titular = victor;
            //Podemos modificar os atributos do Cliente através da referência guardada no atributo titular da Conta
            umaConta.titular.rg = "12345678-9";

            MessageBox.Show(umaConta.titular.nome);
            MessageBox.Show(victor.rg);

            Conta conta = new Conta();
            Cliente cliente = new Cliente();
            conta.titular = cliente;
            conta.titular.nome = "Victor";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Conta umaConta = new Conta();
            Cliente guilherme = new Cliente();
            guilherme.nome = "Guilherme Silveira";
            guilherme.rg = "12345678-9";
            guilherme.idade = 18;

            umaConta.titular = guilherme;
            umaConta.titular.rg = "98765432-1";

            MessageBox.Show(umaConta.titular.nome);
            MessageBox.Show(guilherme.rg);

            if (guilherme.EhMaiorDeIdade())
            {
                MessageBox.Show("Guilherme é maior de idade!");
            }
            else
            {
                MessageBox.Show("Guilherme é menor de idade!");
            }
        }
    }
}
