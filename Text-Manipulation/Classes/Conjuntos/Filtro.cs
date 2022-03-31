using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Manipulation.Classes.Conjuntos
{
    internal class Filtro
    {
        public static List<String> Resultado(List<String> arquivo1, List<String> arquivo2)
        {
            List<String> resultado = new List<String>();

            foreach (String linha1 in arquivo1)
            {
                foreach (String linha2 in arquivo2)
                {
                    if (linha2.IndexOf(linha1) > -1)
                    {
                        String buscar = linha2.Substring(linha1.Length);
                        resultado.Add(buscar);
                    }
                }
            }
            return resultado;
        }
    }
}
