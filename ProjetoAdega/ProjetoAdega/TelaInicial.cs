using ProjetoAdega.consulta;
using System;
using System.Windows.Forms;

namespace ProjetoAdega
{
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        private void cadastrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaCadastro telaCadastro = new TelaCadastro();
            telaCadastro.Show();
            this.Hide();
        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            consBebida consBebida = new consBebida();
            consBebida.Show();
            this.Hide();

        }
    }
}
