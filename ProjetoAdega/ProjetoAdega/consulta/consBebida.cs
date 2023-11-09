using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProjetoAdega.consulta
{
    public partial class consBebida : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-SFDHQQH\SQLEXPRESS; Initial Catalog= dbadega; User ID=sa; Password=1234567");
        SqlCommand comando = new SqlCommand();
        public consBebida()
        {
            comando.Connection = con;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter Da = new SqlDataAdapter("", con);

            if (cbTipo.Text == "")
            {
                Da.SelectCommand.CommandText = "SELECT * FROM tb_produto";
                DataTable Dt = new DataTable();
                Da.Fill(Dt);
                dataGridView1.DataSource = Dt;
                con.Close();

            }
            else
            {
                Da.SelectCommand.CommandText = "SELECT * FROM tb_produto WHERE produto_tipo ='" + cbTipo.Text + "'";
                DataTable Dt = new DataTable();
                Da.Fill(Dt);
                dataGridView1.DataSource = Dt;

                con.Close();
            }
        }
        private void carregaBebida()
        {

            try
            {
                nomebeb.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            }
            catch
            {


                MessageBox.Show("seleciona uma linha");


            }


        }


        private void button2_Click(object sender, EventArgs e)
        {
            carregaBebida();
        }
    }
}
