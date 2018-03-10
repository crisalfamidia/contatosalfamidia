using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemplos
{
    public class Pessoa
    {
        public String Nome { get; set; }
        public String Sobrenome { get; set; }
        public String Cpf { get; set; }


        String NomeCompleto(String primeiro, String segundo)
        {
            return primeiro + segundo;
        }
    }
}
