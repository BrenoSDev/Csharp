using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LidandoComConjuntos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HashSet<string> devedores = new HashSet<string>();
            //Podemos adicionar elementos no conjunto utilizando o método Add
            devedores.Add("Victor");
            devedores.Add("Osni");

            //Para sabermos o número de elementos adicionados, utilizamos a propriedade Count do conjunto
            int elementos = devedores.Count;

            //O conjunto não guarda elementos repetidos, então se tentarmos adicionar novamente a string "Victor",
            //o número de elemento continua sendo 2
            devedores.Add("Victor");

            //Para perguntarmos se o conjunto possui um determinado elemento, utilizamos o método Contains
            bool contem = devedores.Contains("Osni");
            MessageBox.Show(devedores.Count.ToString());

            //Não podemos pegar um elemento pela sua posição, pois os elementos do conjunto não possuem uma
            //ordenação bem determinada

            //Para iterarmos nos elementos de um HashSet, podemos utilizar novamente o comando foreach:
            foreach (string devedor in devedores)
            {
                MessageBox.Show(devedor);
            }
            //Quando executamos o foreach em um HashSet, a ordem em que os elementos são iterados é indefinida

            SortedSet<string> devedores2 = new SortedSet<string>();

            devedores2.Add("Hugo");
            devedores2.Add("Ettore");
            devedores2.Add("Osni");
            devedores2.Add("Alberto");
            devedores2.Add("Victor");

            foreach (string nome in devedores2)
            {
                MessageBox.Show(nome);
            }
        }
    }
}
