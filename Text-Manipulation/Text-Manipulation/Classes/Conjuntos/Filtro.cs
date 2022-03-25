using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Text_Manipulation
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
                        String[] buscar = linha2.Split(linha1);
                        resultado.Add(buscar[1]);
                    }
                }
            }
            return resultado;
        }
    }
}
