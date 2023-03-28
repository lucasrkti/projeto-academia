using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_academia
{

    public class Pessoa
    {
       private string nome = string.Empty;
       private int idade = 0;
        private string Usuario { get => nome; set => nome = value; }
        private int Idade { get => idade; set => idade = value; }
    }

}
