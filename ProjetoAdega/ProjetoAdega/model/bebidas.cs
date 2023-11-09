using System.Data.SqlClient;


namespace ProjetoAdega
{
    public class bebidas
    {

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-SFDHQQH\SQLEXPRESS; Initial Catalog= dbadega; User ID=sa; Password=1234567");
        SqlCommand comando = new SqlCommand();

        public void inserirdados(string desc, string tipo, double preco)
        {
            comando.Connection = con;
            con.Open();
            comando.CommandText = "exec insereProduto '" + desc + "','" + tipo + "','" + preco + "'";
            comando.ExecuteNonQuery();
            con.Close();
        }



    }

}
