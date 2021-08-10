using Banco.Contas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    public partial class FormRelatorios : Form
    {
        private List<Conta> contas;
        public FormRelatorios(List<Conta> contas)
        {
            InitializeComponent();
            this.contas = contas;
        }

        private void botaoFiltroSaldo_Click(object sender, EventArgs e)
        {
            //O ListBox funciona como o ComboBox. Quando queremos adicionar uma nova linha, precisamos adicionar
            //o objeto que queremos mostrar dentro da propriedade Items do ListBox. Ele mostrará o ToString()
            //do objeto adicionado
            //Como utilizaremos esse ListBox para mostrarmos o resultado de diversas buscas, precisamos limpar
            //o resultado anterior antes de mostrar o próximo, e fazemos isso através do método Clear() da 
            //propriedade Items:
            listaResultado.Items.Clear();
            var resultado = contas
                                .Where(c => c.Saldo > 5000)
                                .OrderBy(c => c.Titular.Nome)
                                .ThenBy(c => c.Numero);

            foreach (var c in resultado)
            {
                listaResultado.Items.Add(c.Titular.Nome);
            }
            double saldoTotal = resultado.Sum(c => c.Saldo);
            double maiorSaldo = resultado.Max(c => c.Saldo);

            labelSaldoTotal.Text = Convert.ToString(saldoTotal);
            labelMaiorSaldo.Text = Convert.ToString(maiorSaldo);
        }

        private void botaoFiltroSaldo2_Click(object sender, EventArgs e)
        {
            listaResultado.Items.Clear();
            var resultado = from c in contas where c.Numero < 10 && c.Saldo > 1000 orderby c.Titular.Nome, c.Numero select c;
            foreach(var c in resultado)
            {
                listaResultado.Items.Add(c.Titular.Nome);
            }

            double saldoTotal = resultado.Sum(c => c.Saldo);
            double maiorSaldo = resultado.Max(c => c.Saldo);

            labelSaldoTotal.Text = Convert.ToString(saldoTotal);
            labelMaiorSaldo.Text = Convert.ToString(maiorSaldo);
        }
    }
}
