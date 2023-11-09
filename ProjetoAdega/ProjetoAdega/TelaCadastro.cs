using System;
using System.Windows.Forms;

namespace ProjetoAdega
{
    public partial class TelaCadastro : Form
    {
        public TelaCadastro()
        {
            InitializeComponent();
        }

        private void brVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            TelaInicial telaInicial = new TelaInicial();
            telaInicial.Show();
        }

        private void btCadBebidas_Click(object sender, EventArgs e)
        {
            this.Hide();
            cadBebidas cadBebidas = new cadBebidas();
            cadBebidas.Show();
        }
    }
}
