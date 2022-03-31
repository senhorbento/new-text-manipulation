using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Text_Manipulation.Classes.Arquivo;
using Text_Manipulation.Classes.Links;

namespace Text_Manipulation.UI
{
    public partial class JanelaLinks : Form
    {
        private String nomeDaFuncao = "Null";
        private String caminho;
        private int funcao, qtd;
        private List<String> arquivo1 = new List<string>();

        private const String _ABRIR_URLS_ =
            "https://github.com/senhorbento/new-text-manipulation/blob/master/readme/Links/abrir_links.md";
        private const String _TESTADOR_ =
            "https://github.com/senhorbento/new-text-manipulation/blob/master/readme/Links/testar_ips.md";

        public JanelaLinks()
        {
            InitializeComponent();
            SetLabel("");
        }

        public void SetFuncao(int v)
        {
            funcao = v;
        }

        public void SetQuantidade(int v)
        {
            qtd = v;
        }

        public void SetLabel(String v)
        {
            LbEnderecos.Text = v;
        }

        private void SetCaminho()
        {
            caminho = TxBxCaminho.Text;
        }

        public void DefinirNomeJanela()
        {
            switch (funcao)
            {
                case 20:
                    nomeDaFuncao = "Abrir urls";
                    break;
                case 21:
                    nomeDaFuncao = "Testador de ips";
                    break;
                default:
                    nomeDaFuncao = "Null";
                    break;
            }

            this.Text = nomeDaFuncao;
            LbLista1.Text = "Endereços: ";
            LbTitulo.Text = nomeDaFuncao;
        }

        private void AbrirAjuda()
        {
            switch (funcao)
            {
                case 20:
                    Enderecos.AbrirNavegador(_ABRIR_URLS_);
                    break;
                case 21:
                    Enderecos.AbrirNavegador(_TESTADOR_);
                    break;
                default:
                    nomeDaFuncao = "Null";
                    break;
            }
        }

        private void AbrirJanelaQuantidade()
        {
            qtd = -1;
            JanelaAuxiliar janela = new JanelaAuxiliar(this);
            janela.ShowDialog();
        }

        private void ExecutarFuncao()
        {
            SetCaminho();
            AbrirJanelaQuantidade();
            switch (funcao)
            {

                case 20:
                    if (qtd > 0)
                    {
                        Enderecos.AbrirLinks(arquivo1, caminho, qtd);
                        MessageBox.Show("Lista finalizada", "Sucesso!");
                    }
                    break;
                case 21:
                    if (qtd > 0)
                    {
                        Testador.TestarIps(arquivo1, caminho, qtd, this);
                        MessageBox.Show("Lista finalizada", "Sucesso!");
                    }
                    break;
                default:
                    break;
            }
        }

        private void BtExecutar_Click(object sender, EventArgs e)
        {
            SetCaminho();

            if (Arquivo.VerificarArquivo(caminho))
            {
                arquivo1 = Arquivo.LerArquivo(caminho);
                ExecutarFuncao();
            }
            
        }

        private void BtLista1_Click(object sender, EventArgs e)
        {
            OpenFileDialog CaminhoArquivoExterno = new OpenFileDialog();
            if (CaminhoArquivoExterno.ShowDialog() == DialogResult.OK)
            {
                TxBxCaminho.Text = CaminhoArquivoExterno.FileName;
            }
        }

        private void BtAjuda_Click(object sender, EventArgs e)
        {
            AbrirAjuda();
        }
    }
}
