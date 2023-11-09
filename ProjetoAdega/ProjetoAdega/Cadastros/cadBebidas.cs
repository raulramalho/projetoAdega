using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
namespace ProjetoAdega
{
    public partial class cadBebidas : Form
    {
        bebidas bebidas = new bebidas();

        public cadBebidas()
        {
            InitializeComponent();



            txtpreco.Text = string.Format("{0:#,##0.00}", 0d);


        }

        private void txtkeypress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar.Equals((char)Keys.Back))
            {
                TextBox t = (TextBox)sender;
                string w = Regex.Replace(t.Text, "[^0-9]", string.Empty);
                if (w == string.Empty) w = "00";

                if (e.KeyChar.Equals((char)Keys.Back))
                    w = w.Substring(0, w.Length - 1);
                else
                    w += e.KeyChar;


                t.Text = string.Format("{0:#,##0.00}", Double.Parse(w) / 100);
                t.Select(t.Text.Length, 0);
            }
            e.Handled = true;
        }

        private void btCadastrarbebida_Click(object sender, EventArgs e)
        {

            bebidas.inserirdados(txtDesc.Text, comboBoxTipoBebida.Text, double.Parse(txtpreco.Text));

        }


    }
}

