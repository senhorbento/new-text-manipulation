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
using Text_Manipulation.Classes.Conjuntos;
using Text_Manipulation.Classes.Links;

namespace Text_Manipulation.UI
{
    public partial class JanelaConjuntos : Form
    {
        private static String temp = Path.GetTempPath();
        private String _CAMINHO_PADRAO_ = Path.Combine(temp + "resultado.txt");
        private String nomeDaFuncao = "Null";
        private String caminho1,caminho2;
        private int funcao;
        private List<String> arquivo1 = new List<string>();
        private List<String> arquivo2 = new List<string>();
        private List<String> resultado = new List<string>();

        private const String _INTERSECAO_ =
            "https://github.com/senhorbento/new-text-manipulation/blob/master/readme/Conjuntos/intersecao.md";
        private const String _FILTRO_ =
            "https://github.com/senhorbento/new-text-manipulation/blob/master/readme/Conjuntos/filtro.md";
        private const String _UNIAO_ =
            "https://github.com/senhorbento/new-text-manipulation/blob/master/readme/Conjuntos/uniao.md";

        public JanelaConjuntos()
        {
            InitializeComponent();
        }

        public void SetFuncao(int v)
        {
            funcao = v;
        }

        private void SetCaminhos()
        {
            caminho1 = TxBxCaminho1.Text;
            caminho2 = TxBxCaminho2.Text;
        }

        public void DefinirNomeJanela()
        {
            switch (funcao)
            {
                case 1:
                    nomeDaFuncao = "Interseção";
                    break;
                case 2:
                    nomeDaFuncao = "Filtro";
                    break;
                case 3:
                    nomeDaFuncao = "União";
                    break;
                default:
                    nomeDaFuncao = "Null";
                    break;
            }

            this.Text = nomeDaFuncao;
            LbTitulo.Text = nomeDaFuncao;
        }

        private void LerArquivos()
        {
            arquivo1 = Arquivo.LerArquivo(TxBxCaminho1.Text);
            arquivo2 = Arquivo.LerArquivo(TxBxCaminho2.Text);
        }

        private void ExecutarFuncao()
        {
            switch (funcao)
            {
                case 1:
                    resultado = Intersecao.Resultado(arquivo1, arquivo2);
                    break;
                case 2:
                    resultado = Filtro.Resultado(arquivo1, arquivo2);
                    break;
                case 3:
                    resultado = Uniao.Resultado(arquivo1, arquivo2);
                    break;
                default:
                    break;
            }
        }

        private void AbrirAjuda()
        {
            switch (funcao)
            {
                case 1:
                    Enderecos.AbrirNavegador(_INTERSECAO_);
                    break;
                case 2:
                    Enderecos.AbrirNavegador(_FILTRO_);
                    break;
                case 3:
                    Enderecos.AbrirNavegador(_UNIAO_);
                    break;
                default:
                    break;
            }
        }

        private void BtAjuda_Click(object sender, EventArgs e)
        {
            AbrirAjuda();
        }

        private void BtAbrir_Click(object sender, EventArgs e)
        {
            SetCaminhos();
            if (Arquivo.VerificarArquivo(caminho1) && Arquivo.VerificarArquivo(caminho2))
            {
                LerArquivos();
                ExecutarFuncao();
                Arquivo.AbrirArquivo(_CAMINHO_PADRAO_, resultado);
            }
        }

        private void BtLista1_Click(object sender, EventArgs e)
        {
            OpenFileDialog CaminhoArquivoExterno = new OpenFileDialog();
            if (CaminhoArquivoExterno.ShowDialog() == DialogResult.OK)
            {
                TxBxCaminho1.Text = CaminhoArquivoExterno.FileName;
            }
        }

        private void BtLista2_Click(object sender, EventArgs e)
        {
            OpenFileDialog CaminhoArquivoExterno = new OpenFileDialog();
            if (CaminhoArquivoExterno.ShowDialog() == DialogResult.OK)
            {
                TxBxCaminho2.Text = CaminhoArquivoExterno.FileName;
            }
        }

        private void BtExportar_Click(object sender, EventArgs e)
        {
            SetCaminhos();
            if (Arquivo.VerificarArquivo(caminho1) && Arquivo.VerificarArquivo(caminho2))
            {
                LerArquivos();
                ExecutarFuncao();
                Arquivo.SalvarArquivo(resultado);
            }
        }
    }
}
