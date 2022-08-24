using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dia2.Types
{
    internal class Enumeradores
    {
        public  void Executa()
        {
            System.Console.WriteLine((Byte)diasSemana.SEG);

            diasSemana domingo = diasSemana.DOM;
            System.Console.WriteLine(domingo);
        }
        public enum diasSemana
        {
            DOM,SEG,TER,QUA,QUI,SEX
        }
    }
}
