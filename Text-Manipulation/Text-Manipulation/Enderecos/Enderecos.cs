using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Manipulation
{
    internal class Enderecos
    {
        public static void AbrirLinks(List <String> arquivo1, int qtd)
        {
            int i = 0;
            foreach(String lines in arquivo1)
            {
                if(i == qtd)
                {
                    i = 0;
                    //JanelaEspera("Aguardando OK para continuar a execução");
                }
                i++;
            }
        }
    }
}
