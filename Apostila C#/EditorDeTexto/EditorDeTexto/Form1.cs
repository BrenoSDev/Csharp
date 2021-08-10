using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EditorDeTexto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("texto.txt"))
            {
                using (Stream arquivo = File.Open("texto.txt", FileMode.Open))
                using (TextReader leitor = new StreamReader(arquivo))
                {
                    string linha = leitor.ReadToEnd();
                    textoConteudo.Text += linha;
                }
            }
        }

        private void botaoGrava_Click(object sender, EventArgs e)
        {
            using (Stream saida = File.Open("texto.txt", FileMode.Create))
            using (StreamWriter escritor = new StreamWriter(saida))
            {
                escritor.Write(textoConteudo.Text);
            }
        }

        private void botaoBusca_Click(object sender, EventArgs e)
        {
            string busca = textoBusca.Text;
            string textoDoEditor = textoConteudo.Text;
            int resultado = textoDoEditor.IndexOf(busca);
            if (resultado >= 0)
            {
                MessageBox.Show("Achei o texto "+busca);
            }
            else
            {
                MessageBox.Show("Não achei");
            }
        }

        private void botaoReplace_Click(object sender, EventArgs e)
        {
            using (Stream saida = File.Open("texto.txt", FileMode.Create))
            using (StreamWriter substituidor = new StreamWriter(saida))
            {
                string texto = textoConteudo.Text;
                texto = texto.Replace(textoBusca.Text, textoReplace.Text);
                textoConteudo.Text = texto;
                substituidor.Write(texto);
            }
            
        }

        private void botaoMaiusculo_Click(object sender, EventArgs e)
        {
            using (Stream saida = File.Open("texto.txt", FileMode.Create))
            using (StreamWriter maiusculo = new StreamWriter(saida))
            {
                int inicioSelecao = textoConteudo.SelectionStart;
                int tamanhoSelecao = textoConteudo.SelectionLength;

                string textoSelecionado = textoConteudo.Text.Substring(inicioSelecao, tamanhoSelecao);
                string antes = textoConteudo.Text.Substring(0, inicioSelecao);
                string depois = textoConteudo.Text.Substring(inicioSelecao + tamanhoSelecao);
                textoConteudo.Text = antes + textoSelecionado.ToUpper() + depois;
                maiusculo.Write(textoConteudo.Text);
            }
        }

        private void botaoMinusculo_Click(object sender, EventArgs e)
        {
            using (Stream saida = File.Open("texto.txt", FileMode.Create))
            using (StreamWriter minusculo = new StreamWriter(saida))
            {
                int inicioSelecao = textoConteudo.SelectionStart;
                int tamanhoSelecao = textoConteudo.SelectionLength;
                string textoSelecionado = textoConteudo.Text.Substring(inicioSelecao, tamanhoSelecao);
                string antes = textoConteudo.Text.Substring(0, inicioSelecao);
                string depois = textoConteudo.Text.Substring(inicioSelecao + tamanhoSelecao);
                textoConteudo.Text = antes + textoSelecionado.ToLower() + depois;
                minusculo.Write(textoConteudo.Text);
            }
        }
    }
}
