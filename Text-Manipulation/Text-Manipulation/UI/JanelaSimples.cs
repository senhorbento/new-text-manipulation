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
    public partial class JanelaSimples : Form
    {
        private static String temp = Path.GetTempPath();
        private String _CAMINHO_PADRAO_ = Path.Combine(temp + "resultado.txt");
        private String nomeDaFuncao = "Null";
        private int funcao;
        private List<String> arquivo1 = new List<string>();
        private List<String> resultado = new List<string>();
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
        private void BtAbrir_Click(object sender, EventArgs e)
        {
            if (TxBxLista1.Text.Length > 0)
            {
                if (Arquivo.VerificarExtensao(TxBxLista1.Text))
                {
                    LerArquivos();
                    ExecutarFuncao();
                    AbrirArquivoExterno();
                }
            }
            else if (TxBxLista1.Text.Length == 0)
            {
                MessageBox.Show("Não foi possível localizar o arquivo contendo os números, favor inserir novamente!", "Falha");
            }
            else
            {
                MessageBox.Show("Erro desconhecido!", "Erro");
            }
        }

        private void BtExportar_Click(object sender, EventArgs e)
        {
            if (TxBxLista1.Text.Length > 0)
            {
                if (Arquivo.VerificarExtensao(TxBxLista1.Text))
                {
                    LerArquivos();
                    ExecutarFuncao();
                    SalvarArquivoExterno();
                }
            }
            else if (TxBxLista1.Text.Length == 0)
            {
                MessageBox.Show("Não foi possível localizar o arquivo contendo os números, favor inserir novamente!", "Falha");
            }
            else
            {
                MessageBox.Show("Erro desconhecido!", "Erro");
            }
        }

        private void BtLista1_Click(object sender, EventArgs e)
        {
            OpenFileDialog CaminhoArquivoExterno = new OpenFileDialog();
            if (CaminhoArquivoExterno.ShowDialog() == DialogResult.OK)
            {
                TxBxLista1.Text = CaminhoArquivoExterno.FileName;
            }
        }
    }
}
