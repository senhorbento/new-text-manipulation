using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using Text_Manipulation.UI;
using Text_Manipulation.Classes.Arquivo;

namespace Text_Manipulation.Classes.Links
{
    internal class Testador
    {
        private static bool Estado(String ip)
        {
            bool retorno = false;
            Task t = Task.Factory.StartNew(() => {

                Ping ping = new Ping();
                PingReply reply = ping.Send(ip, 500);

                if (reply.Status == 0)
                {
                    retorno = true;
                }
                else
                {
                    retorno = false;
                }
            });
            t.Wait();
            return retorno;
        }

        public static void TestarIps(List<String> arquivo1, String caminho, int repeticao, JanelaLinks janela)
        {
            int i = 0, qtdLista = -1, remove = 0;
            const String prefix = "http://";
            String ip;
            List<String> remover = new List<String>();

            while (qtdLista != 0)
            {
                qtdLista = 0;
                foreach (String lines in arquivo1)
                {
                    qtdLista++;
                    ip = Enderecos.RetornarIP(lines).ToString();

                    janela.SetLabel("Testando o ip: " + ip);

                    if (Estado(ip))
                    {
                        String abrir = prefix + ip;
                        Enderecos.AbrirNavegador(abrir);
                        remover.Add(lines);
                        remove = 1;
                        i++;
                        qtdLista--;
                    }

                    if (i == repeticao)
                    {
                        if (Enderecos.Continuar())
                        {
                            i = 0;
                        }
                        else
                        {
                            qtdLista = 0;
                            break;
                        }
                    }
                }

                if (remove == 1)
                {
                    foreach (String lines in remover)
                    {
                        arquivo1.Remove(lines);
                    }
                    remover.Clear();
                    Arquivo.Arquivo.EscreverArquivo(arquivo1, caminho);
                }

                if (qtdLista > 0)
                {
                    qtdLista = -1;
                }
            }
        }
    }
}
