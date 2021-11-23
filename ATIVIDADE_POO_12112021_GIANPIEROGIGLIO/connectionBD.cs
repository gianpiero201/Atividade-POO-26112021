using MySql.Data.MySqlClient;
using System.Data;

namespace ATIVIDADE_POO_12112021_GIANPIEROGIGLIO
{
    internal class connectionBD
    {
        public MySqlConnection sqlConn = new MySqlConnection(" Persist Security Info=False;server = localhost; database = cadastroaluno; uid = root; pwd = 4426; convert zero datetime=True");
        public MySqlDataAdapter? sqlAdapter;

        public string ConectarBanco()
        {
            try
            {
                sqlConn.Open();
            }
            catch (System.Exception ex)
            {
                return (ex.Message.ToString());
            }

            return "";
        }

        public DataSet BuscarDados()
        {
            DataSet dataSet = new DataSet();
            if (sqlConn.State == System.Data.ConnectionState.Open)
            {
                string query = "SELECT * FROM alunos";

                //cria um adapter usando a instrução SQL para acessar a tabela Clientes
                sqlAdapter = new MySqlDataAdapter(query, sqlConn);

                //preenche o dataset via adapter
                sqlAdapter.Fill(dataSet, "alunos");

                sqlConn.Close();
            }
            return dataSet;
        }

        public void InserirDados(Alunos alunos)
        {

            if (sqlConn.State == System.Data.ConnectionState.Open)
            {
                string query = $@"insert into alunos(RA, nome, telefone, cpf, logradouro, bairro, numerocasa, datanascimento)
                    values({alunos.RA},'{alunos.nome}','{alunos.telefone}','{alunos.cpf}','{alunos.logradouro}','{alunos.bairro}',{alunos.numero},'{alunos.dataNascimento.ToString("yyyy-MM-dd")}')";
                MySqlCommand cmd= new MySqlCommand();
                cmd.CommandText=query;
                cmd.Connection = sqlConn;
                cmd.ExecuteNonQuery();
                sqlConn.Close();
            }
        }
    }
}
