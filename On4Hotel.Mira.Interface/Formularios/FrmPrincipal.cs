using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace On4Hotel.Mira.Interface.Formularios
{
    public partial class FrmPrincipal : Form
    {
        private int childFormNumber = 0;

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

       

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmAlugar alugar = new FrmAlugar();
            alugar.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FrmAlugar alugar = new FrmAlugar();
            alugar.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            FrmAlugar alugar = new FrmAlugar();
            alugar.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAlugar alugar = new FrmAlugar();
            alugar.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmAlugar alugar = new FrmAlugar();
            alugar.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmAlugar alugar = new FrmAlugar();
            alugar.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmAlugar alugar = new FrmAlugar();
            alugar.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmAlugar alugar = new FrmAlugar();
            alugar.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FrmAlugar alugar = new FrmAlugar();
            alugar.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FrmAlugar alugar = new FrmAlugar();
            alugar.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            FrmAlugar alugar = new FrmAlugar();
            alugar.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            FrmAlugar alugar = new FrmAlugar();
            alugar.ShowDialog();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            FrmAlugar alugar = new FrmAlugar();
            alugar.ShowDialog();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            FrmAlugar alugar = new FrmAlugar();
            alugar.ShowDialog();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            FrmAlugar alugar = new FrmAlugar();
            alugar.ShowDialog();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            FrmAlugar alugar = new FrmAlugar();
            alugar.ShowDialog();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            FrmAlugar alugar = new FrmAlugar();
            alugar.ShowDialog();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            FrmAlugar alugar = new FrmAlugar();
            alugar.ShowDialog();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            FrmAlugar alugar = new FrmAlugar();
            alugar.ShowDialog();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            FrmAlugar alugar = new FrmAlugar();
            alugar.ShowDialog();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            FrmAlugar alugar = new FrmAlugar();
            alugar.ShowDialog();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            FrmAlugar alugar = new FrmAlugar();
            alugar.ShowDialog();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            FrmAlugar alugar = new FrmAlugar();
            alugar.ShowDialog();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            FrmAlugar alugar = new FrmAlugar();
            alugar.ShowDialog();
        }
    }
}
