using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace On4Hotel.Mira.Dominio
{
    public class Quarto
    {
        public int Id { get; set; }
        public String  nome { get; set; }
        public string numero { get; set; }
        public string Descricao { get; set; }
        public bool status { get; set; }
    }
}
