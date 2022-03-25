using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net.NetworkInformation;

namespace Text_Manipulation
{
    internal class Testador
    {
        private static bool Estado(String ip)
        {
            Ping ping = new Ping();
            PingReply reply = ping.Send(ip, 500);

            if (reply.Status == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public static void AbrirIp(List<String> arquivo1, String caminho, int repeticao, JanelaLinks janela)
        {
            int i = 0, qtdLista = -1, remove = 0;
            const String prefix = "http://";
            List<String> remover = new List<String>();

            while(qtdLista != 0) 
            {
                qtdLista = 0;
                foreach (String lines in arquivo1)
                {
                    qtdLista++;
                    janela.SetLabel("Testando o ip: " + lines);
                    if (Estado(lines))
                    {
                        String abrir = prefix + lines;
                        Enderecos.AbrirNavegador(abrir);
                        remover.Add(lines);
                        remove = 1;
                        i++;
                        qtdLista--;
                    }                
                    if (i == repeticao)
                    {
                        MessageBox.Show("Deseja continuar a execução?", "Pause", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        i = 0;
                    }
                }

                if(remove == 1) 
                { 
                    foreach(String lines in remover)
                    {
                        arquivo1.Remove(lines);
                    }
                    remover.Clear();
                    Arquivo.GravarArquivo(arquivo1, caminho);
                }

                if(qtdLista > 0)
                {
                    qtdLista = -1;
                }                
            }
            janela.SetLabel("");
            MessageBox.Show("Lista finalizada", "Sucesso!");
        }

    }
}
