using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Construtores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cliente guilherme = new Cliente("Guilherme Silveira");
            //Para inserir os outros dados do cliente precisamos do código:
            /*guilherme.cpf = "123.456.789-01";
            guilherme.rg = "21.345.987-x";
            guilherme.Idade = 25;*/

            //Para evitar a repetição, podemos utilizar os initializers do C#. O Initializer é um bloco de código
            //que serve para inicializar as propriedades públicas do objeto
            Cliente cliente = new Cliente("Victor Harada")
            {
                //Bloco de inicialização
                cpf = "123.456.789-01",
                rg = "21.345.987-x",
                Idade = 25
            };

            //Parâmetros nomeados
            //Quando queremos utilizar um parâmetro nomeado, precisamos falar o nome do parâmetro seguido de ':' e 
            //depois o valor que será colocado no parâmetro
            Produto p = new Produto(nome:"Apostila de C#");
        }
    }}
