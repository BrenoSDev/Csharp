using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhandoComArrays
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Quando queremos guardar diversos objetos, podemos fazer uso de Arrays. Um array é uma estrutura de dados
            //que consegue guardar vários elementos e ainda nos possibilita pegar esses elementos de maneira fácil
            int[] numeros = new int[5]; //Array de inteiros com 5 posições

            //Para guardar elementos nessas posições fazemos:
            numeros[0] = 1;
            numeros[1] = 600;
            numeros[2] = 257;
            numeros[3] = 12;
            numeros[4] = 42;
            MessageBox.Show("Numero = " + numeros[1]);
            //Veja que a primeira posição de um array é 0 (zero). Logo, as posições de um array vão de 0 até 
            //(tamanho - 1)

            Conta[] contas = new Conta[5];
            contas[0] = new Conta();
            contas[1] = new ContaPoupanca();

            //Se quisermos imprimir todas as Contas armazenadas, podemos fazer um loop nesse array. O loop 
            //começará em 0 e vai até o tamanho do array (contas.Length)
            for (int i = 0; i < contas.Length; i++)
            {
                MessageBox.Show("Saldo = " + contas[i].Saldo);
            }
            //Podemos ainda usar uma outra sintaxe do C#: o foreach
            foreach(Conta c in contas)
            {
                MessageBox.Show("Saldo = "+ c.Saldo);
            }

            //Para facilitar nosso trabalho, o C# nos oferece um atalho para criar e inicializar o conteúdo do 
            //array. Se quiséssemos um array de inteiros preenchido com os números de 1 a 5, poderíamos 
            //utilizar o seguinte código:
            int[] umAoCinco = new int[] { 1, 2, 3, 4, 5 };
        }
    }
}
