using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstruturasdeRepeticao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Loop com o for
            /*for (inicialização; condição; atualização) 
             {
                //Esse código é executado enquanto a condição é verdadeira
             } */

            double valorInvestido = 1000.0;
            for (int i = 1; i <= 12; i += 1)
            {
                valorInvestido *= 1.01;
            }
            MessageBox.Show("Valor investido agora é " + valorInvestido);

            //Loop com o while
            valorInvestido = 1000.0;
            int c = 1;
            while (c <= 12)
            {
                valorInvestido *= 1.01;
                c += 1;
            }
            MessageBox.Show("Valor investido agora é " + valorInvestido);
            //Loop com o do while 
            /*do 
             * {
             *    //corpo do loop
             * } while(condição); */

            //Com o do while a condição do loop só é checada no fim da volta, ou seja, o corpo do loop
            //é executado e depois a condição é checada

            /*Operadores de incremento e decremento de uma variável
             * int valor = 1;
             * valor ++; incremento
             * valor --; decremento */
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int total = 2;
            for (int i = 0; i<5;i++)
            {
                total *= 2;
            }
            MessageBox.Show("O total é: " + total);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Soma dos inteiros de 1 até 1000
            int soma = 0;
            for (int i = 1; i <= 1000; i++)
            {
                soma += i;
            }
            MessageBox.Show("A soma é " + soma);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Múltiplos de 3
            for (int c = 1; c <= 100; c++)
            {
                if (c % 3 == 0)
                {
                    MessageBox.Show("Múltiplo: " + c);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Soma dos inteiros entre 1 e 100, pulando os múltiplos de 3
            int soma = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 != 0)
                {
                    soma += i;
                }
            }
            MessageBox.Show("A soma é: " + soma);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Imprimindo números divísiveis por 3 e 4 entre 0 e 30
            for (int i = 1; i <= 30; i++)
            {
                if (i % 3 == 0)
                {
                    MessageBox.Show(i + " é divisível por 3");
                }
                if (i % 4 == 0)
                {
                    MessageBox.Show(i + " é divisível por 4");
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Imprimindo os fatoriais de 1 a 10
            for (int numero = 1; numero <= 10; numero++)
            {
                int fatorial = 1; ;
                for (int m = numero; m >= 1; m--)
                {
                    fatorial *= m;
                }
                MessageBox.Show("O fatorial de " + numero + " é " + fatorial);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //Imprimindo a série de Fibonacci
            int termo = 0;
            int termoanterior = 1;
            do
            {
                if (termo < 1)
                {
                    MessageBox.Show(termo + "");
                    termo++;
                    MessageBox.Show(termo + "");
                }
                else
                {
                    MessageBox.Show(termo + "");
                    int temp = termo;
                    termo += termoanterior;
                    termoanterior = temp;
                }
            } while (termo < 100);
        }
    }
}
