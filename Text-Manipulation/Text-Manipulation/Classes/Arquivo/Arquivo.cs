using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Text_Manipulation
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

        public static void GravarArquivo(List<String> lista, String caminho)
        {
            try
            {
                StreamWriter sw = new StreamWriter(caminho);
                foreach(String linha in lista)
                {
                    sw.WriteLine(linha);
                }
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }

        public static bool VerificarExtensao(String caminho)
        {
            int len;
            String[] arquivo;
            len = caminho.Length;
            arquivo = caminho.Split(".");
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

    }
}
