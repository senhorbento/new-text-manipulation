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
using Text_Manipulation.Classes.Arquivo;
using Text_Manipulation.Classes.Links;

namespace Text_Manipulation.UI
{
    public partial class JanelaSimples : Form
    {
        private static String temp = Path.GetTempPath();
        private String _CAMINHO_PADRAO_ = Path.Combine(temp + "resultado.txt");
        private String nomeDaFuncao = "Null";
        private String caminho;
        private int funcao;
        private List<String> arquivo1 = new List<string>();
        private List<String> resultado = new List<string>();

        private const String _WPP_ =
            "https://github.com/senhorbento/new-text-manipulation/blob/master/readme/Links/wpp.md";

        public JanelaSimples()
        {
            InitializeComponent();
        }

        public void SetFuncao(int v)
        {
            funcao = v;
        }

        public void DefinirNomeJanela()
        {
            switch (funcao)
            {
                case 10:
                    nomeDaFuncao = "Atalho para Whatsapp";
                    LbLista1.Text = "Números: ";
                    break;
                default:
                    nomeDaFuncao = "Null";
                    break;
            }

            this.Text = nomeDaFuncao;
            LbTitulo.Text = nomeDaFuncao;
        }

        private void ExecutarFuncao()
        {
            switch (funcao)
            {
                case 10:
                    resultado = Wpp.Resultado(arquivo1);
                    break;
                default:
                    break;
            }
        }

        private void AbrirAjuda()
        {
            switch (funcao)
            {
                case 10:
                    Enderecos.AbrirNavegador(_WPP_);
                    break;
                default:
                    break;
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

        private void BtExportar_Click(object sender, EventArgs e)
        {
            caminho = TxBxCaminho.Text;
            if (Arquivo.VerificarArquivo(caminho))
            {
                arquivo1 = Arquivo.LerArquivo(caminho);
                ExecutarFuncao();
                Arquivo.SalvarArquivo(resultado);
            }
        }

        private void BtAbrir_Click(object sender, EventArgs e)
        {
            caminho = TxBxCaminho.Text;
            if (Arquivo.VerificarArquivo(caminho))
            {
                arquivo1 = Arquivo.LerArquivo(caminho);
                ExecutarFuncao();
                Arquivo.AbrirArquivo(_CAMINHO_PADRAO_, resultado);
            }
        }
    }
}
