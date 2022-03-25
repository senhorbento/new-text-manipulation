using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;

namespace Text_Manipulation
{
    internal class Enderecos
    {
        public static void AbrirLinks(List <String> arquivo1, int qtd)
        {
            int i = 0;
            foreach(String lines in arquivo1)
            {
                AbrirNavegador(lines);
                i++;
                if (i == qtd)
                {
                    MessageBox.Show("Deseja continuar a execução?", "Pause", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    i = 0;
                }
            }
        }

        public static void AbrirNavegador(String link)
        {
            System.Diagnostics.Process AbrirNavegador = new System.Diagnostics.Process();
            AbrirNavegador.StartInfo.UseShellExecute = true;
            AbrirNavegador.StartInfo.FileName = link;
            AbrirNavegador.Start();
        }

    }
}
