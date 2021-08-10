using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OiMundo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World!");
            MessageBox.Show("Curso de C# da Caelum");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Conta conta = new Conta();
            Conta c = new Conta();
            c.saldo = 1000.0;
            c.saldo += 200;
            c.titular = "Breno";
            c.numero = 1;
            MessageBox.Show(c.titular+": "+c.saldo);

            Conta c2 = new Conta();
            c2.titular = "Yngrid";
            c2.saldo = 600.0;
            c2.Deposita(500.0);
            c2.Saca(1000.0);
            MessageBox.Show(c2.titular + ": " + c2.saldo);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Conta mauricio = new Conta();
            mauricio.saldo = 2000.0;

            Conta guilherme = new Conta();
            guilherme.saldo = 5000.0;

            mauricio.Transfere(200, guilherme);

            MessageBox.Show("mauricio = " + mauricio.saldo);
            MessageBox.Show("guilherme = " + guilherme.saldo);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Conta mauricio = new Conta();
            mauricio.numero = 1;
            mauricio.titular = "Mauricio";
            mauricio.saldo = 100.0;

            Conta mauricio2 = new Conta();
            mauricio2.numero = 1;
            mauricio2.titular = "Mauricio";
            mauricio2.saldo = 100.0;

            if (mauricio==mauricio2)
            {
                MessageBox.Show("As contas são iguais");
            }
            else
            {
                MessageBox.Show("As contas são diferentes");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Conta mauricio = new Conta();
            mauricio.saldo = 2000.0;

            Conta copia = mauricio;
            copia.saldo = 3000.0;

            MessageBox.Show("mauricio = " + mauricio.saldo);
            MessageBox.Show("copia = " + copia.saldo);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Conta breno = new Conta();
            breno.saldo = 500.0;
            if (breno.Saca(600.0))
            {
                MessageBox.Show("Saque realizado com sucesso!");
            }
            else
            {
                MessageBox.Show("Saldo insuficiente!");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Conta jose = new Conta();
            jose.idade = 15;
            jose.saldo = 400;
            jose.Saca(300.0);
            MessageBox.Show("jose = " + jose.saldo);
        }
    }
}
