using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Manipulation.Classes.Conjuntos
{
    internal class Uniao
    {
        public static List<String> Resultado(List<String> arquivo1, List<String> arquivo2)
        {
            List<String> resultado = new List<String>();
            resultado = arquivo1;
            foreach (String linha2 in arquivo2)
            {
                resultado.Add(linha2);
            }
            resultado = resultado.Distinct().ToList();
            return resultado;
        }
    }
}
