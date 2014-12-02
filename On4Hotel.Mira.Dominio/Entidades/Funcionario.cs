using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace On4Hotel.Mira.Dominio
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Rg { get; set; }
        public string Cpf { get; set; }
        public DateTime DataCadastro { get; set; }
        public String Obs { get; set; }
    }
}
