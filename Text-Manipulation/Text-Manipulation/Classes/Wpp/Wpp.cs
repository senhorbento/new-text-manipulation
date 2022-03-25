using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Text_Manipulation
{
    internal class Wpp
    { 
        public static List<String> Resultado(List<String> arquivo1)
        {
            List<String> resultado = new List<String>();
            String prefix = "https://api.whatsapp.com/send/?phone=";
            foreach (String linha1 in arquivo1)
            {
                resultado.Add(prefix + linha1);
            }
            return resultado;
        }
    }
}
