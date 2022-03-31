using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Text_Manipulation.UI
{
    public partial class JanelaAuxiliar : Form
    {
        private JanelaLinks JT = new JanelaLinks();
        private int quantidadeMaxima;

        public JanelaAuxiliar()
        {
            InitializeComponent();
        }

        public JanelaAuxiliar(JanelaLinks janela, int qtd)
        {
            InitializeComponent();
            JT = janela;
            quantidadeMaxima = qtd;
        }

        private void BtContinuar_Click(object sender, EventArgs e)
        {
            int quantidadeEscolhida = int.Parse(NmBxQtd.Text);
            if (quantidadeEscolhida <= quantidadeMaxima) { 
                JT.SetQuantidade(quantidadeEscolhida);
                this.Close();
            }
            else
            {
                MessageBox.Show("Quantidade maior que o tamanho da lista, favor inserir uma quantidade menor",
                "Erro!", MessageBoxButtons.OK);
            }
        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
