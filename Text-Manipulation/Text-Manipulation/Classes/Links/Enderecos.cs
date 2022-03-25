using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;
using System.Text.RegularExpressions;

namespace Text_Manipulation
{
    internal class Enderecos
    {
        public static bool Continuar()
        {
            DialogResult result;
            result = MessageBox.Show("Deseja continuar a execução?", "Pause", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static void AbrirLinks(List <String> arquivo1, String caminho, int qtd)
        {
            int i = 0;
            List<String> remover = new List<String>();
            foreach (String lines in arquivo1)
            {
                AbrirNavegador(lines);
                i++;
                if (i == qtd)
                {
                    if (Continuar())
                    {
                        i = 0;
                    }
                    else
                    {
                        break;
                    }
                    remover.Add(lines);
                }
            }

            foreach (String lines in remover)
            {
                arquivo1.Remove(lines);
            }
            remover.Clear();
            Arquivo.GravarArquivo(arquivo1, caminho);

        }

        public static void AbrirNavegador(String link)
        {
            System.Diagnostics.Process AbrirNavegador = new System.Diagnostics.Process();
            AbrirNavegador.StartInfo.UseShellExecute = true;
            AbrirNavegador.StartInfo.FileName = link;
            AbrirNavegador.Start();
        }

        public static Match RetornarIP(String linha)
        {
            Regex rx = new Regex(@"\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}");
            MatchCollection matches = rx.Matches(linha);
            return matches[0];
        }

    }
}
