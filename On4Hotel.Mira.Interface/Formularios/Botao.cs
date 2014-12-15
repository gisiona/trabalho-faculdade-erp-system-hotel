using On4Hotel.Mira.Dominio;
using On4Hotel.Mira.Repositorio;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace On4Hotel.Mira.Interface.Formularios
{
    public class Botao
    {

        private static void botaoClick(object sender, EventArgs e)
        {
            FrmAlugar alugar = new FrmAlugar();
            alugar.ShowDialog();
        }

        public static List<Button> adicionarBotao()
        {
            List<Button> botoes = new List<Button>();    
            
            List<Quarto> quartos = new List<Quarto>();
            QuartoDB db = new QuartoDB();
            quartos = db.retornarQuartos();

            foreach (Quarto q in quartos)
            {
                Button bTeste = new System.Windows.Forms.Button();

                bTeste.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
                bTeste.Size = new System.Drawing.Size(85, 93);
                bTeste.UseVisualStyleBackColor = true;
                bTeste.Click += new System.EventHandler(botaoClick);

                bTeste.Name = "btn" + q.Id;
                bTeste.Text = Convert.ToString(q.Id);
                if (q.status == true)
                {
                    bTeste.BackColor = Color.Red;
                }
                botoes.Add(bTeste);
            }

            return botoes;
        }

    }
}
