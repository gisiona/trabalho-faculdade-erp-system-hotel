using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace On4Hotel.Mira.Dominio
{
   public class Cliente
    {
        public int Id { get; set; }
        public String Nome { get; set; }
        public String Rg { get; set; }
        public String Cpf { get; set; }
        public DateTime DataCadastro { get; set; }
        public String Obs { get; set; }
    }
}
