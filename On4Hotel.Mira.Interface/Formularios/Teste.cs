using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using On4Hotel.Mira.Repositorio;

namespace On4Hotel.Mira.Interface.Formularios
{
    public partial class Teste : Form
    {
        public Teste()
        {
            InitializeComponent();
        }

        SqlConnection con = Conexao.obterConexao();

        private void button1_Click(object sender, EventArgs e)
        {
          
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            flp.Controls.RemoveAt(0);
        }

        private void buttonClick(object sender, EventArgs e)
        {
            FrmAlugar alugar = new FrmAlugar();
            alugar.ShowDialog();
        }

        private void Teste_Load(object sender, EventArgs e)
        {
           
            try
            {
                con.Open();

                MessageBox.Show("Conexão aberta");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
