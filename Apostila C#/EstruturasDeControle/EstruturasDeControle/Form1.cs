using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstruturasDeControle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*Estrutura condicional
             
             if (condicao)
              {
              
              } */

            /*Operadores de comparação:
             * >= Maior ou igual
             * > Maior
             * < Menor
             * <= Menor ou igual
             * == Igual
             * != Diferente
             * !(condicao) Negação */

            double saldo = 5.0;
            double valorSaque = 10.0;
            bool realmentePodeSacar = (saldo >= valorSaque) && (valorSaque > 0);
            if (realmentePodeSacar)
            {
                //Código do saque
                saldo -= valorSaque;
                MessageBox.Show("Saque realizado com sucesso!");
                MessageBox.Show("Saldo: " + saldo);
            }
            else
            {
                MessageBox.Show("Saldo Insuficiente");
            }

            bool podeSacar = (saldo >= valorSaque);

            /*Operações com valores booleanos
             * && - verificar se duas operações são verdadeiras ao mesmo tempo (e)
             * || - ou */

            bool rPodeSacar = (saldo >= valorSaque) || (valorSaque > 0);

            double taxa;
            if (saldo < 1000) {
                taxa = 0.01;
            } 
            else if (saldo <= 5000)
            {
                taxa = 0.05;
            }
            else
            {
                taxa = 0.1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double saldo = 500.0;
            if (saldo < 0.0) {
                MessageBox.Show("Você está no negativo!");
            }
            else if (saldo < 1000000.0)
            {
                MessageBox.Show("Você é um bom cliente!");
            }
            else
            {
                MessageBox.Show("Você é milionário!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int idade;
            bool brasileira;

            idade = 17;
            brasileira = true;

            if (idade >= 16 && brasileira)
            {
                MessageBox.Show("Você está apto a votar!");
            }
            else
            {
                MessageBox.Show("Você não está apto a votar!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double valorDaNotaFiscal = 1300;
            double imposto;
            double taxa;
            if (valorDaNotaFiscal < 1000)
            {
                taxa = 0.02;
            }
            else if (valorDaNotaFiscal < 3000)
            {
                taxa = 0.025;
            }
            else if (valorDaNotaFiscal < 7000)
            {
                taxa = 0.028;
            }
            else
            {
                taxa = 0.03;
            }
            imposto = valorDaNotaFiscal * taxa;
            MessageBox.Show("Taxa: " + taxa);
            MessageBox.Show("Você deve pagar R$" + imposto + " de imposto!");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int valor = 15;
            string mensagem = "";
            /*if (valor >10)
            {
                mensagem = "Maior que dez";
            }
            else
            {
                mensagem = "Menor que dez";
            }
            MessageBox.Show(mensagem);*/

            //Operador ternário

            mensagem += (valor > 10) ? "Maior que dez" : "Menor que dez";
            MessageBox.Show(mensagem);
        }
    }
}
