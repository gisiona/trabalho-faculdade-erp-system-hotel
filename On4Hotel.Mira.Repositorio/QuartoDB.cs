using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using On4Hotel.Mira.Dominio;
using System.Data.SqlClient;

namespace On4Hotel.Mira.Repositorio
{
    public class QuartoDB 
    {

        public List<Quarto> retornarQuartos() 
        {
            List<Quarto> quartos = new List<Quarto>();
            SqlConnection con = Conexao.obterConexao();
            if(con != null){
                string query = "select * from quarto;";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Quarto q = new Quarto();
                    q.Id = dr.GetInt32(0);
                    q.nome = dr.GetString(1);
                    q.numero = dr.GetString(2);
                    q.Descricao = dr.GetString(3);
                    q.status = dr.GetBoolean(4);

                    quartos.Add(q);
                }
                return quartos;
                con.Close();
            }
            else
            {
                return null;
            }          
        }
    }
}
