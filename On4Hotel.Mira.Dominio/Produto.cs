using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace On4Hotel.Mira.Dominio
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal ValorUnitario { get; set; }
        public DateTime DataCadastro { get; set; }
        public int QtdeEstoque { get; set; }
        public Boolean Status { get; set; }

    }
}
