using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dia2.Types
{
    internal class Numeradores_2


    {

        public  void Executa()
        {
            System.Console.WriteLine(DiasDaSemana2.DOM);
            DiasDaSemana2 diaspresenciais = (DiasDaSemana2)20;
            System.Console.WriteLine(diaspresenciais);
        }
        [Flags]
        public enum DiasDaSemana2
        {
            DOM = 1,
            SEG = 2,
            TER = 4,
            QUA = 8,
            QUI = 16,
            SEX = 32,
            SAB = 64

        }
    }
}
