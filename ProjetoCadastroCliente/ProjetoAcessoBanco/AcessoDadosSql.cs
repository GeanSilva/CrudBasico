using System;
using System.Data;
using System.Data.SqlClient;

//propriedade que pega o conexão string
using ProjetoAcessoBanco.Properties;

namespace ProjetoAcessoBanco
{
    public class AcessoDadosSql
    {
 #region Propriedade de conexão com banco
        //Criando conexão
        private static SqlConnection _criarConnection()
        {
            return new SqlConnection(Settings.Default.Setting);
        }

        // comando do parâmentro
        private  SqlParameterCollection _sqlParameterCollection = new SqlCommand().Parameters;

        // limpado o parâmetro
        public void LimparParametros()
        {
            _sqlParameterCollection.Clear();
        }

        //Adicioando o parâmentro
        public void AdicionarParametros(string nomeParametro, object valorParametro)
        {
            _sqlParameterCollection.Add(new SqlParameter(nomeParametro, valorParametro));
        }

        //Persistência - inserir, alterar,excluir
        public object ExecutarManipulacao(CommandType commandType, string nomeStoreProcedure)
        {
            try
            {
                //Criar conexão
                var sqlConnection = _criarConnection();
                //abrindo conexão
                sqlConnection.Open();
                //criar o comando que vai levar a informção para o banco
                var sqlCommand = sqlConnection.CreateCommand();
                //colar as coisas dentro do comando (dentro da caixa que vai trafegar na caixa)
                sqlCommand.CommandType = commandType;
                sqlCommand.CommandText = nomeStoreProcedure;
                sqlCommand.CommandTimeout = 7200;

                //Adicionar os parâmetros no comando
                foreach (SqlParameter sqlParameter in _sqlParameterCollection)
                {
                    sqlCommand.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));
                }

                //executa o comando, ou seja, manda o comando ir até o banco
                return sqlCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                
                throw new Exception(ex.Message);
            }
            
        }

        //Consulta dos resgistros do banco
        public DataTable ExecutarDataTable(CommandType commandType, string nomeStoreProcedure)
        {
            try
            {
                //Criar conexão
                var sqlConnection = _criarConnection();
                //abrindo conexão
                sqlConnection.Open();
                //criar o comando que vai levar a informção para o banco
                var sqlCommand = sqlConnection.CreateCommand();
                //colar as coisas dentro do comando (dentro da caixa que vai trafegar na caixa)
                sqlCommand.CommandType = commandType;
                sqlCommand.CommandText = nomeStoreProcedure;
                // em segundos
                sqlCommand.CommandTimeout = 7200; 

                //Adicionar os parâmetros no comando
                foreach (SqlParameter sqlParameter in _sqlParameterCollection)
                {
                    sqlCommand.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));
                }

                //Criando um adpatador
                var sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                //datatable = tabela de dados vazia onde vou colocar o dados que vem do banco
                var dataTable = new DataTable();

                //mandar o comando  ir até o banco buscar os dados preenchedo o banco
                sqlDataAdapter.Fill(dataTable);

                return dataTable;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

            
        }

#endregion
    }
}