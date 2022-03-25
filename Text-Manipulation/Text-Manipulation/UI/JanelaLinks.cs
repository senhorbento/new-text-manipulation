using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Text_Manipulation
{
    public partial class JanelaLinks : Form
    {
        private static String temp = Path.GetTempPath();
        private String nomeDaFuncao = "Null";
        private int funcao, qtd;
        private List<String> arquivo1 = new List<string>();

        private const String _ABRIR_URLS_ =
            "https://github.com/senhorbento/new-text-manipulation/blob/master/readme/Links/abrir_links.md";
        private const String _TESTADOR_ =
            "https://github.com/senhorbento/new-text-manipulation/blob/master/readme/Links/testar_ips.md";

        public JanelaLinks()
        {
            InitializeComponent();
        }

        public void SetFuncao(int v)
        {
            funcao = v;
        }

        public void SetQuantidade(int v)
        {
            qtd = v;
        }

        public void SetLabel(String nome)
        {
            LbAuxiliar.Text = nome;
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
            LbAuxiliar.Text = "";
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

        private void LerArquivos()
        {
            arquivo1 = Arquivo.LerArquivo(TxBxLista1.Text);
        }

        private void ExecutarFuncao()
        {
            switch (funcao)
            {

                case 20:
                    AbrirJanelaQuantidade();
                    if(qtd > 0)
                    {
                        Enderecos.AbrirLinks(arquivo1, TxBxLista1.Text, qtd);
                        MessageBox.Show("Lista finalizada", "Sucesso!");
                    }
                    break;
                case 21:
                    AbrirJanelaQuantidade();
                    if(qtd > 0)
                    {
                        Testador.AbrirIp(arquivo1, TxBxLista1.Text, qtd, this);
                        SetLabel("");
                        MessageBox.Show("Lista finalizada", "Sucesso!");
                    }
                    break;
                default:
                    break;
            }
        }

        private void AbrirJanelaQuantidade()
        {
            qtd = -1;
            JanelaAuxiliar janela = new JanelaAuxiliar(this);
            janela.ShowDialog();
        }

        private void BtLista1_Click(object sender, EventArgs e)
        {
            OpenFileDialog CaminhoArquivoExterno = new OpenFileDialog();
            if (CaminhoArquivoExterno.ShowDialog() == DialogResult.OK)
            {
                TxBxLista1.Text = CaminhoArquivoExterno.FileName;
            }
        }

        private void BtAjuda_Click(object sender, EventArgs e)
        {
            AbrirAjuda();
        }

        private void BtAbrir_Click(object sender, EventArgs e)
        {
            LerArquivos();
            ExecutarFuncao();
        }
    }
}
