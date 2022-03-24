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
        private String _CAMINHO_PADRAO_ = Path.Combine(temp + "resultado.txt");
        private String nomeDaFuncao = "Null";
        private int funcao, qtd;
        private List<String> arquivo1 = new List<string>();
        private List<String> resultado = new List<string>();

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

                case 20:
                    qtd = -1;
                    JanelaAuxiliar janela = new JanelaAuxiliar(this);
                    janela.ShowDialog();
                    Enderecos.AbrirLinks(arquivo1, qtd);
                    break;
                default:
                    break;
            }
        }
    }
}
