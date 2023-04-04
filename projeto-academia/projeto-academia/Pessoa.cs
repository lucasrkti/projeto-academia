using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_academia
{

    public class Pessoa
    {
        public string nome = string.Empty;
        public int idade = 0;

        public string _nome { get => nome; set => nome = value; }
        public int Idade { get => idade; set => idade = value; }
    }

   
}
