using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAB.CaixaEletronico
{
    static class StringUtils
    {
        public static string Pluralize(this string palavra)
        {
            if (palavra.EndsWith("s"))
            {
                return palavra;
            }
            else
            {
                return palavra + "s";
            }
        }
    }
}
