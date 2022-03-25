using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Text_Manipulation
{
    public partial class JanelaConjuntos : Form
    {
        private static String temp = Path.GetTempPath();
        private String _CAMINHO_PADRAO_ = Path.Combine(temp + "resultado.txt");
        private String nomeDaFuncao = "Null";
        private int funcao;
        private List<String> arquivo1 = new List<string>();
        private List<String> arquivo2 = new List<string>();
        private List<String> resultado = new List<string>();

        public void SetFuncao(int v)
        {
            funcao = v;
        }

        public JanelaConjuntos()
        {
            InitializeComponent();
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

        private void SalvarArquivoExterno()
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.FileName = "resultado";
            sfd.Filter = "Text (*.txt)|*.txt";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                File.Create(sfd.FileName).Dispose();
                Arquivo.GravarArquivo(resultado, sfd.FileName);
                MessageBox.Show("Exportado para " + sfd.FileName + " com sucesso!", "Êxito");
            }
            else
            {
                MessageBox.Show("Operação cancelada, arquivo não exportado.", "Falha");
            }
        }

        private void AbrirArquivoExterno()
        {
            File.Create(_CAMINHO_PADRAO_).Dispose();
            Arquivo.GravarArquivo(resultado, _CAMINHO_PADRAO_);
            System.Diagnostics.Process.Start("notepad", _CAMINHO_PADRAO_);
        }

        private void LerArquivos()
        {
            arquivo1 = Arquivo.LerArquivo(TxBxLista1.Text);
            arquivo2 = Arquivo.LerArquivo(TxBxLista2.Text);
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

        private void BtLista1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog CaminhoArquivoExterno = new OpenFileDialog();
            if (CaminhoArquivoExterno.ShowDialog() == DialogResult.OK)
            {
                TxBxLista1.Text = CaminhoArquivoExterno.FileName;
            }
        }

        private void BtLista2_Click(object sender, EventArgs e)
        {
            OpenFileDialog CaminhoArquivoExterno = new OpenFileDialog();
            if (CaminhoArquivoExterno.ShowDialog() == DialogResult.OK)
            {
                TxBxLista2.Text = CaminhoArquivoExterno.FileName;
            }
        }

        private void BtExportar_Click(object sender, EventArgs e)
        {
            if (TxBxLista1.Text.Length > 0 && TxBxLista2.Text.Length > 0)
            {
                if (Arquivo.VerificarExtensao(TxBxLista1.Text))
                {
                    if (Arquivo.VerificarExtensao(TxBxLista2.Text))
                    {
                        LerArquivos();
                        ExecutarFuncao();
                        SalvarArquivoExterno();
                    }
                }
            }
            else if (TxBxLista1.Text.Length == 0)
            {
                MessageBox.Show("Não foi possível localizar o arquivo 1, favor inserir novamente!", "Falha");
            }
            else if (TxBxLista2.Text.Length == 0)
            {
                MessageBox.Show("Não foi possível localizar o arquivo 2, favor inserir novamente!", "Falha");
            }
            else
            {
                MessageBox.Show("Erro desconhecido!", "Erro");
            }
        }
        private void LbGerar_Click(object sender, EventArgs e)
        {
            if (TxBxLista1.Text.Length > 0 && TxBxLista2.Text.Length > 0)
            {
                if (Arquivo.VerificarExtensao(TxBxLista1.Text))
                {
                    if (Arquivo.VerificarExtensao(TxBxLista2.Text))
                    {
                        LerArquivos();
                        ExecutarFuncao();
                        AbrirArquivoExterno();
                    }
                }
            }
            else if (TxBxLista1.Text.Length == 0)
            {
                MessageBox.Show("Não foi possível localizar o arquivo 1, favor inserir novamente!", "Falha");
            }
            else if (TxBxLista2.Text.Length == 0)
            {
                MessageBox.Show("Não foi possível localizar o arquivo 2, favor inserir novamente!", "Falha");
            }
            else
            {
                MessageBox.Show("Erro desconhecido!", "Erro");
            }
        }

        private void BtAjuda_Click(object sender, EventArgs e)
        {
            AbrirAjuda();
        }
    }
}
