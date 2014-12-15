using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace On4Hotel.Mira.Repositorio
{
    public class Conexao
    {
        private static string stringConexao = "Data Source=ULTRABOOK\\SQLEXPRESS;Initial Catalog=ON4HOTEL;Integrated Security=True;";
        private static SqlConnection con = null;

        public static SqlConnection obterConexao()
        {
            con = new SqlConnection(stringConexao);

            try
            {    
                con.Open();
            }
            catch (Exception ex)
            {
                con = null;  
            }
            return con;
        }

        public static void fecharConexao()
        {
            if (con != null)
            {
                con.Close();
            }
        }
    }
}
