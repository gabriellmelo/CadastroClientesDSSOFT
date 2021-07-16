using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace Database
{
    public class Pessoa
    {
        private string connString = "";

        public Pessoa()
        {
            connString = ConfigurationManager.ConnectionStrings["ConexaoBD"].ConnectionString;
        }

        public void Salvar(string nome, string sobrenome, string idade, string endereco, string bairro, string cidade, string telefone)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string sql = "InserirDados";
                SqlCommand cmd = new SqlCommand(sql, conn);
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();

                    cmd.Parameters.Add("@nome", SqlDbType.VarChar);
                    cmd.Parameters["@nome"].Value = nome;
                    cmd.Parameters.Add("@sobrenome", SqlDbType.VarChar);
                    cmd.Parameters["@sobrenome"].Value = sobrenome;
                    cmd.Parameters.Add("@idade", SqlDbType.VarChar);
                    cmd.Parameters["@idade"].Value = idade;
                    cmd.Parameters.Add("@endereco", SqlDbType.VarChar);
                    cmd.Parameters["@endereco"].Value = endereco;
                    cmd.Parameters.Add("@bairro", SqlDbType.VarChar);
                    cmd.Parameters["@bairro"].Value = bairro;
                    cmd.Parameters.Add("@cidade", SqlDbType.VarChar);
                    cmd.Parameters["@cidade"].Value = cidade;
                    cmd.Parameters.Add("@telefone", SqlDbType.VarChar);
                    cmd.Parameters["@telefone"].Value = telefone;

                  
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
