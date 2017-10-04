using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace WSVeiculos.DAL
{
    public class Context
    {

        public SqlConnection conexao;

        private SqlConnection CriarConexao()
        {

            conexao = new SqlConnection(ConfigurationManager.ConnectionStrings["strConnection"].ConnectionString);

            return conexao;

        }


        private SqlParameterCollection sqlparametercollection = new SqlCommand().Parameters;

        private SqlCommand criarComando(CommandType commandtype, string nomeProcedure)
        {
            conexao = CriarConexao();
            conexao.Open();
            SqlCommand cmd = conexao.CreateCommand();
            cmd.CommandType = commandtype;
            cmd.CommandText = nomeProcedure;
            cmd.CommandTimeout = 7200;

            foreach (SqlParameter sqlparameter in sqlparametercollection)
            {
                cmd.Parameters.Add(new SqlParameter(sqlparameter.ParameterName, sqlparameter.Value));
            }

            return cmd;
        }


        protected void AdicionarParametros(string nomeParametro, object valorParametro)
        {
            sqlparametercollection.AddWithValue(nomeParametro, valorParametro);
        }

        protected void LimparParametros()
        {
            sqlparametercollection.Clear();
        }

        protected object ExecutarComando(CommandType commandtype, string nomeprocedure)
        {
            try
            {
                SqlCommand cmd = criarComando(commandtype, nomeprocedure);
                return cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

            finally
            {
                conexao.Close();
            }

        }

        protected DataTable ExecutarConsulta(CommandType commandtype, string nomeprocedure)
        {

            try
            {
                SqlCommand cmd = criarComando(commandtype, nomeprocedure);
                DataTable dt = new DataTable();
                SqlDataAdapter sqldataadapter = new SqlDataAdapter(cmd);
                sqldataadapter.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

            finally
            {
                conexao.Close();
            }


        }




























    }
}
