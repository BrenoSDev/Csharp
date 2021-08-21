using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forca
{
    public partial class Form1 : Form
    {
        private string palavraSecreta;
        private int erros = 0;
        private List<char> tentativas = new List<char>();
        private List<char> acertos = new List<char>();

        public Form1()
        {
            InitializeComponent();
        }

        public void MontarBoneco(int totalErros)
        {
            listaForca.Clear();
            string[] boneco = Forca.CriarBoneco(totalErros).Split('V');
            foreach (string linha in boneco)
            {
                listaForca.Items.Add(linha);
            }
        }

        private void botaoEnviar_Click(object sender, EventArgs e)
        {   
            if (labelComando.Text == "Jogar Novamente")
            {
                labelComando.Text = "Palavra Secreta";
                botaoEnviar.Text = "Enviar";
                listaForca.Clear();
                labelPalavraSecreta.Text = "";
            }
            else if (labelComando.Text == "Palavra Secreta")
            {
                if (textoLetra.Text.Length >= 2)
                {
                    palavraSecreta = textoLetra.Text.ToLower();
                    textoLetra.Text = "";
                    labelComando.Text = "Letra";
                    tentativas.Clear();
                    acertos.Clear();
                    erros = 0;
                    MontarBoneco(erros);
                }
                else
                {
                    MessageBox.Show("Digite uma palavra válida!");
                }
            } else if (labelComando.Text == "Letra")
            {
                char[] letrasPalavra = palavraSecreta.ToCharArray();
                if (textoLetra.Text.Length == 1)
                {
                    char tentativa = char.Parse(textoLetra.Text.ToLower());
                    if (tentativas.Contains(tentativa)) {
                        MessageBox.Show("Você já tentou esta letra!");
                    }
                    else
                    {
                        if (letrasPalavra.Contains(tentativa))
                        {
                            acertos.Add(tentativa);
                        } else
                        {
                            erros += 1;
                            MessageBox.Show("Letra Errada!");
                        }
                    }
                    textoLetra.Text = "";
                    string senha = "";
                    foreach (char letra in letrasPalavra)
                    {
                        senha += (acertos.Contains(letra)) ? letra : '*';
                    }
                    labelPalavraSecreta.Text = senha;
                    if (senha == palavraSecreta)
                    {
                        MessageBox.Show("Você Ganhou!");
                        labelComando.Text = "Jogar Novamente";
                        botaoEnviar.Text = "Jogar Novamente";
                    }
                    MontarBoneco(erros);
                    if (erros == 6)
                    {
                        MessageBox.Show("ENFORCADO!");
                        labelComando.Text = "Jogar Novamente";
                        botaoEnviar.Text = "Jogar Novamente";
                    }
                } else
                {
                    MessageBox.Show("Digite alguma letra!");
                }
            }
        }
    }
}
