using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VariaveisETiposPrimitivos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Na declaração de uma variável, devemos dizer seu tipo e qual é o nome que usaremos para referencia-la
            //no texto do programa
            int numeroDaConta;

            //Tipos primitivos:
            //int - números inteiros
            //double e float - números reais
            //string - textos
            //bool - true e false
            //byte - 0 a 255
            //sbyte - -128 a 127
            //short - inteiros
            //ushort - inteiros positivos
            //uint - inteiros positivos
            //long - inteiros
            //ulong - inteiros positivos
            //decimal - números até 28 casas decimais 
            //char - caracteres delimitados por aspas simples 'a', 'ç'

            //Depois de declarada, uma variável pode ser utilizada para armazenar valores
            numeroDaConta = 1;

            double saldo = 100.0;
            double valorDoSaque = 10.0;

            //Operações com variáveis
            //Subtração (-)
            //Soma(+)
            //Multiplicação (*)
            //Divisão (/)


            saldo = saldo - 10.0;
            //saldo = saldo - valorDoSaque;
            saldo -= valorDoSaque;

            //Além do -=, temos também os operadores += (para somas), *= (para multiplicações) e /= (para divisões)

            //Para forçarmos o compilador do C# a fazer uma conversão perigosa, precisamos fazer uma operação do C#
            //chamada casting
            int valor = 1;
            short valorPequeno = (short)valor;

            MessageBox.Show("O saldo da conta após o saque é: " + saldo);

            string mensagem = "Minha mensagem";
            MessageBox.Show(mensagem);

            //Podemos juntar o valor de duas variáveis do tipo string utilizando o operador +
            string m = "Olá ";
            string nome = "Breno";

            MessageBox.Show(m + nome);

            /*isso é um comentário 
             de múltiplas linhas*/

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int idadeBreno = 18;
            int idadeMirelle = 20;
            int idadeYngrid = 10;
            double media = (idadeMirelle + idadeBreno + idadeYngrid) / 3;

            MessageBox.Show("A média das idades é: " + media);

           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double pi = 3.14;
            int piQuebrado = (int)pi;
            MessageBox.Show("piQuebrado = " + piQuebrado);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a = 4;
            int b = 2;
            int c = 0;

            double delta = b * b - 4 * a * c;
            double a1 = (-b + Math.Sqrt(delta) / (2 * a));
            double a2 = (-b - Math.Sqrt(delta) / (2 * a));

            MessageBox.Show("As raízes são: " + a1 + "e " + a2);
        }
    }
}

