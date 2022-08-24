using Dia2.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarrenTech.Classes;
using WarrenTech.CRUD;

namespace WarrenTech
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestaPessoas testerPpl = new TestaPessoas();
            testerPpl.ExecutaJuridico();
            
        }
    }
}
