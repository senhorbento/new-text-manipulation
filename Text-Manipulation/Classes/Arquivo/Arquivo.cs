using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Text_Manipulation.Classes.Arquivo
{
    internal class Arquivo
    {
        public static List<String> LerArquivo(String caminho)
        {
            List<String> lines = new List<string>();
            String[] leitura = System.IO.File.ReadAllLines(caminho);
            foreach (String linha in leitura)
                lines.Add(linha);
            return lines;
        }

        public static void EscreverArquivo(List<String> lista, String caminho)
        {
            try
            {
                StreamWriter sw = new StreamWriter(caminho);
                foreach (String linha in lista)
                {
                    sw.WriteLine(linha);
                }
                sw.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Exception: " + e.Message, "Exception");
            }
        }

        public static void AbrirArquivo(String caminho, List<String> lista)
        {
            File.Create(caminho).Dispose();
            EscreverArquivo(lista, caminho);
            System.Diagnostics.Process.Start("notepad", caminho);
        }

        public static void SalvarArquivo(List<String> lista)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.FileName = "resultado";
            sfd.Filter = "Text (*.txt)|*.txt";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                File.Create(sfd.FileName).Dispose();
                EscreverArquivo(lista, sfd.FileName);
                MessageBox.Show("Exportado para " + sfd.FileName + " com sucesso!", "Êxito");
            }
            else
            {
                MessageBox.Show("Operação cancelada, arquivo não exportado.", "Falha");
            }
        }

        private static bool VerificarExtensao(String caminho)
        {
            int len;
            String[] arquivo;
            len = caminho.Length;
            arquivo = caminho.Split('.');
            if (arquivo[1] != "txt")
            {
                MessageBox.Show("O Formato " + arquivo[1] + " não é suportado, apenas txt é suportado", "Erro");
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool VerificarArquivo(String caminho)
        {
            if (caminho.Length == 0)
            {
                MessageBox.Show("Não foi possível localizar um arquivo, favor inserir novamente!", "Falha");
                return false;
            }
            else if (Arquivo.VerificarExtensao(caminho))
            {
                return true;
            }
            else
            {
                return false;
            }            
        }

    }
}
