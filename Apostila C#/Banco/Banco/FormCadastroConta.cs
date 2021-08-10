using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Banco.Busca;
using Banco.Contas;

namespace Banco
{
    public partial class FormCadastroConta : Form
    {
        //Agora que inicializamos a conta, precisamos cadastrá-la no array que está na classe Form1. Precisamos,
        //portanto acessar a instância de Form1 a partir de FormCadastroConta. Queremos garantir que, na construção
        //do FormCadastroConta, teremos a instância de Form1, portanto vamos modificar o construtor da classe para
        //receber o formulário principal
        private Form1 formPrincipal;

        private ICollection<string> devedores;

        public FormCadastroConta(Form1 formPrincipal)
        {
            this.formPrincipal = formPrincipal;
            InitializeComponent();

            GeradorDeDevedores gerador = new GeradorDeDevedores();
            this.devedores = gerador.GeraList();
        }

        //Para colocar a conta criada no array que contém todas as contas cadastradas que está no formulário principal
        //da aplicação, precisamos colocar um método que adiciona uma nova conta na interface de uso da classe Form1
        public FormCadastroConta()
        {
            InitializeComponent();
        }

        private void botaoCadastrar_Click(object sender, EventArgs e)
        {
            string titular = textoTitular.Text;
            bool ehDevedor = this.devedores.Contains(titular);
            if (!ehDevedor)
            {
                Conta novaConta = new ContaPoupanca();
                if (comboTipoConta.SelectedIndex == 1)
                {
                    novaConta = new ContaCorrente();
                }
                novaConta.Titular = new Cliente(textoTitular.Text);

                this.formPrincipal.AdicionaConta(novaConta);
                textoNumero.Text = Convert.ToString(Conta.ProximoNumero());
            }
            else
            {
                MessageBox.Show("Devedor");
            }
        }

        private void FormCadastroConta_Load(object sender, EventArgs e)
        {
            comboTipoConta.Items.Add("Conta Poupança");
            comboTipoConta.Items.Add("Conta Corrente");
            int proximaConta = Conta.ProximoNumero();
            textoNumero.Text = Convert.ToString(proximaConta);
        }
    }
}
