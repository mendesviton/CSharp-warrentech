using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarrenTech.Classes
{
    internal class Produto : BaseModel
    {
        public Produto(string name, string descricao)
        {
            this.nome = name;
            this.descricao = descricao; 
        }
        public string nome { get; set; }
        public string descricao { get; set; }
    }
}
