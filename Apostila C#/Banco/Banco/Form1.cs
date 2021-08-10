using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Banco.Contas;
using Caelum;

namespace Banco
{
    public partial class Form1 : Form
    {
        private List<Conta> contas;

        private Dictionary<string, Conta> dicionario;
        public Form1()
        {
            InitializeComponent();
            textoTitular.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //ComboBox - lista gerenciada pela aplicação
            /*Para adicionar um novo item no combo box, utilizamos o seguinte código:
             * comboContas.Items.Add("Texto que aparecerá no combo box"); */

            this.dicionario = new Dictionary<string, Conta>();
            //Para criar um método de inicialização do formulário, é só dar um clique duplo nele
            contas = new List<Conta>();
            Conta c1 = new ContaPoupanca();
            c1.Titular = new Cliente("Victor");
            c1.Numero = 1;
            this.AdicionaConta(c1);

            Conta c2 = new ContaPoupanca();
            c2.Titular = new Cliente("Mauricio");
            c2.Numero = 2;
            this.AdicionaConta(c2);

            Conta c3 = new ContaCorrente();
            c3.Titular = new Cliente("Osni");
            c3.Numero = 3;
            this.AdicionaConta(c3);

            //No formulário, para sabermos qual é a conta que deve ser exibida, colocaremos um novo campo de texto
            //onde o usuário escolherá qual é o índice da Conta que será utilizada.
           
            //No caso do número da conta, precisamos convertê-lo para uma string antes de escrevê-lo na propriedade
            //Text

            //Quando queremos fazer conversões entre os tipos básicos do C#, utilizamos uma classe chamada Convert
            //do C#. Dentro dessa classe, podemos utilizar o método ToString para converter um tipo primitivo da
            //linguagem para uma string
        }

        private void botaoDeposito_Click(object sender, EventArgs e)
        {
            Conta selecionada = (Conta) comboContas.SelectedItem;

            string valorDigitado = textoValor.Text;
            double valorOperacao = Convert.ToDouble(valorDigitado);
            try
            {
                selecionada.Deposita(valorOperacao);
                textoSaldo.Text = Convert.ToString(selecionada.Saldo); //Atualiza o valor do saldo na caixa de texto
                MessageBox.Show("Depósito realizado com sucesso!");
            } catch (ArgumentException ex)
            {
                MessageBox.Show("Argumento Inválido!");
            }
         
            //A ação desse botão não pode acessar uma variável que foi declarada dentro de outro método. Para que
            //essa mesma conta possa ser utilizada em diferentes métodos do formulário, ela deve ser declarada 
            //como um atributo da classe do formulário

            //Digitar mbox e apertar tab duas vezes gera um messagebox
        }

        private void botaoSaque_Click(object sender, EventArgs e)
        {
            int indice = comboContas.SelectedIndex;
            Conta selecionada = this.contas[indice];
            string valorDigitado = textoValor.Text;
            double valorOperacao = Convert.ToDouble(valorDigitado);
            try
            {
                selecionada.Saca(valorOperacao);
                textoSaldo.Text = Convert.ToString(selecionada.Saldo);
                MessageBox.Show("Sucesso");
            } catch (ArgumentException ex)
            {
                MessageBox.Show("Não se saca valores negativos!");
            } catch (SaldoInsuficienteException ex)
            {
                MessageBox.Show("Saldo Insuficiente!");
            }
        }

        private void TotContas_Click(object sender, EventArgs e)
        {
            Conta c1 = new ContaPoupanca();
            Conta c2 = new ContaCorrente();

            //Veja que ContaPoupanca é uma Conta. Isso é inclusive expresso através da relação de herança entre as classes
            //E, já que ContaPoupanca é uma Conta, o C# permite que você passe ContaPoupanca em lugares que aceitam 
            //referências do tipo Conta
            ContaPoupanca c3 = new ContaPoupanca();
            TotalizadorDeContas t = new TotalizadorDeContas();
            t.Soma(c1);
            t.Soma(c2);
            t.Soma(c3);
            MessageBox.Show("Valor total: " + t.ValorTotal);
        }

        private void botaoTeste_Click(object sender, EventArgs e)
        {
            Conta c1 = new ContaPoupanca();
            c1.Deposita(100.0);
            c1.Saca(50.0);
            MessageBox.Show("Conta poupança = " + c1.Saldo);

            Conta c2 = new ContaCorrente();
            c2.Deposita(100.0);
            c2.Saca(50.0);
            c2.Numero = 1;
            MessageBox.Show("Conta = " + c2.Saldo);

            Conta c3 = new ContaCorrente();
            c3.Numero = 1;

            if (c2.Equals(c3))
            {
                MessageBox.Show("Iguais");
            }
            else
            {
                MessageBox.Show("Diferentes");
            }
            Cliente guilherme = new Cliente("Guilherme Silveira");
            Cliente mauricio = new Cliente("Mauricio Aniche");

            if (guilherme.Equals(mauricio))
            {
                MessageBox.Show("São o mesmo cliente");
            }
            else
            {
                MessageBox.Show("Não são o mesmo cliente");
            }

            var filtradas = contas.Where((Conta c) => { return c.Saldo > 2000; });
            foreach(Conta conta in filtradas)
            {
                MessageBox.Show(conta.Titular.Nome);
            }
            double saldoTotal = contas.Sum(c => c.Saldo);
            double mediaSaldo = contas.Average(c => c.Saldo);
            MessageBox.Show("Saldo Total: "+saldoTotal);
            MessageBox.Show("Media dos saldos = "+mediaSaldo);

            var filtradas2 = from c in contas
                             where c.Saldo < 2000
                             select c;
            foreach (Conta conta in filtradas2)
            {
                MessageBox.Show(conta.Titular.Nome);
            }

            var resultado = from c in contas
                            where c.Numero < 2000
                            select new { c.Numero, c.Titular };
            foreach (var c in resultado)
            {
                //Aqui dentro só podemos usar o Titular e o Numero, se tentarmos acessar o Saldo teremos um erro
                //de compilação
                MessageBox.Show(c.Titular.Nome+" "+c.Numero);
            }

            Conta c5 = new ContaCorrente();
            Cliente titular = new Cliente("Victor");
            ObjectExtensions.MudaTitular(c5, titular);
        }

        private void comboContas_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Para associar uma ação ao evento de mudança de seleção do combo, precisamos apenas dar um duplo clique
            //no combo box
            //Podemos recuperar qual é o índice (começando de zero) do item que foi selecionado pelo usuário lendo a 
            //propriedade SelectedIndex
            int indice = comboContas.SelectedIndex;
            Conta selecionada = contas[indice];

            textoTitular.Text = selecionada.Titular.Nome;
            textoSaldo.Text = Convert.ToString(selecionada.Saldo);
            textoNumero.Text = Convert.ToString(selecionada.Numero);
        }

        private void botaoTransferencia_Click(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(textoValor.Text);
            Conta transferencia = contas[comboDestinoTransferencia.SelectedIndex];
            contas[comboContas.SelectedIndex].Transfere(transferencia, valor);

            textoSaldo.Text = Convert.ToString(contas[comboContas.SelectedIndex].Saldo);
        }
        //Para definir o texto que será exibido no TextBox, precisaremos de uma variável que guardará a referência para
        //o componente TextBox. Para definir o nome dessa variável, devemos clicar com o botão direito no TextBox e 
        //escolher a opção Propriedades
        //O nome que for colocado no campo name será o nome da variável que conterá a referência para a instância de 
        //TextBox 

        //O texto de um botão do Windows Form também pode ser customizado através de sua propriedade Text.

        //O label funciona como uma etiqueta para nossos campos de texto. Através da propriedade Text da Label, que
        //pode ser modificada pela janela properties, podemos definir qual é o texto que será exibido

        //Utilizando o GroupBox, podemos agrupar diversos componentes diferentes sob um único título

        /*Resumo dos atalhos:
         Ctrl + Shift + N - cria um novo projeto
        Ctrl + . - utilizado para fazer consertos rápidos no código
        Ctrl + - autocomplete
        */

        public void AdicionaConta(Conta conta)
        {
            //Array.Resize(ref contas, numeroDeContas+1);
            //this.contas[this.numeroDeContas] = conta;
            //this.numeroDeContas++;
            this.contas.Add(conta);
            //Além de colocar a conta no array, precisamos também registrar a conta no comboContas
            comboContas.Items.Add(conta);
            comboDestinoTransferencia.Items.Add(conta);
            comboContas.DisplayMember = "Titular.Nome";
            comboDestinoTransferencia.DisplayMember = "Titular.Nome";

            this.dicionario.Add(conta.Titular.Nome, conta);
        }

        private void botaoNovaConta_Click(object sender, EventArgs e)
        {
            //this representa a instância de Form1 que está sendo utilizada pelo Windows Form
            FormCadastroConta formularioDeCadastro = new FormCadastroConta(this);

            //Para mostrar o formulário, utilizaremos o método ShowDialog do FormCadastroConta
            formularioDeCadastro.ShowDialog();
        }

        private void botaoImpostos_Click(object sender, EventArgs e)
        {
            ContaCorrente conta = new ContaCorrente();
            conta.Deposita(200.0);

            MessageBox.Show("Imposto de Conta Corrente = " + conta.CalculaTributo());
            ITributavel t = conta;

            MessageBox.Show("Imposto da conta pela interface = " + t.CalculaTributo());

            SeguroDeVida sv = new SeguroDeVida();
            MessageBox.Show("Imposto do Seguro = " + sv.CalculaTributo());

            t = sv;
            MessageBox.Show("Imposto do Seguro pela Interface " + t.CalculaTributo());

            TotalizadorDeTributos totalizador = new TotalizadorDeTributos();
            totalizador.Acumula(conta);
            MessageBox.Show("Total: "+totalizador.Total);
            totalizador.Acumula(sv);
            MessageBox.Show("Total: " + totalizador.Total);

            TotalizadorDeTributos t1 = new TotalizadorDeTributos();
            //O operador is verifica se o resultado de uma expressão é compatível com um determinado tipo

            foreach (Conta c in contas)
            {
                if (c is ContaCorrente)
                {
                    ContaCorrente a = (ContaCorrente)c;
                    t1.Acumula(a);
                }
            }
            MessageBox.Show("Tributos Totais = "+t1.Total);
            int proxima = ContaCorrente.ProximaConta();
            MessageBox.Show("Proxima conta = "+proxima);

        }

        private void botaoBusca_Click(object sender, EventArgs e)
        {
            //Precisamos primeiro buscar qual é o nome do titular que foi digitado no campo de texto
            string nomeTitular = textoBuscaTitular.Text;
            
            if (dicionario.ContainsKey(nomeTitular))
            {
                //Agora vamos usar o dicionário para fazer a busca
                Conta conta = dicionario[nomeTitular];
                //E agora só precisamos mostrar a conta que foi encontrada na busca
                comboContas.SelectedItem = conta;
                //Quando escrevemos na propriedade SelectedItem, o WindowsForms automaticamente chama a ação de mudança
                //de item selecionado do combo box, logo não precisamos nos preocupar em atualizar os campos de texto
                //no código de busca por nome do titular
            }
            else
            {
                MessageBox.Show("Titular não encontrado!");
            }
        }

        private void botaoRelatorio_Click(object sender, EventArgs e)
        {
            FormRelatorios form = new FormRelatorios(this.contas);
            form.ShowDialog();
        }
    }
}
