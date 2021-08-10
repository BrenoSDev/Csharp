using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncapsulamentoEModificadoresDeAcesso
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conta conta = new Conta();
            conta.Saca(100.0);
            conta.Deposita(250.0);

            //em um arquivo
            conta.Saca(100.0);

            //em outro arquivo
            conta.Saca(250.0);

            //em outro arquivo
            conta.Saca(371.0);

            //Caso ocorresse uma alteração no saque de tirar 10 centavos a cada operação, precisaríamos apenas
            //alterar uma vez o método Saca() ao invés de alterar todas as linhas que acessam o atributo diretamente

            conta.ColocaNumero(1100);
            MessageBox.Show("saldo: " + conta.PegaSaldo());
            MessageBox.Show("número: " + conta.Numero);

            Conta c = new Conta();

            MessageBox.Show("numero: " + c.Numero);
            MessageBox.Show("saldo " + c.Saldo);

            double valorADepositar = 200.0;
            
        }
    }
}
