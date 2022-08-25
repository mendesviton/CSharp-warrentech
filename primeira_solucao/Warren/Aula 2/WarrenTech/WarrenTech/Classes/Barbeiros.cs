using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarrenTech.Classes
{
    internal class Barbeiros : BaseModel
    {
        public Barbeiros(string name, string email, int idade)
        {
            this.idade = idade;
            this.email = email;
            this.nome = name;
        }
        public string nome { get; set; }
        public string email { get; set; }
        public float idade { get; set; }
    }
}
