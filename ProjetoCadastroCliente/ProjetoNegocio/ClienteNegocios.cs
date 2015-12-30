using System;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using  ProjetoAcessoBanco;
using ProjetoDTO;

namespace ProjetoNegocio
{
    public class ClienteNegocios
    {
        private readonly AcessoDadosSql _acessoDadosSql = new AcessoDadosSql();

        public string Inserir(Cliente cliente)
        {
            try
            {
                _acessoDadosSql.LimparParametros();
                _acessoDadosSql.AdicionarParametros("@Nome", cliente.Nome);
                _acessoDadosSql.AdicionarParametros("@DataNascimento", cliente.DataNascimento);
                _acessoDadosSql.AdicionarParametros("@Sexo", cliente.Sexo);
                _acessoDadosSql.AdicionarParametros("@LimeteCompra", cliente.LimeteCompra);
                var idCliente = _acessoDadosSql.ExecutarManipulacao(CommandType.StoredProcedure, "upsClienteInserir").ToString();

                return idCliente;
            }
            catch (Exception ex)
            {            
                return ex.Message;
            }
           
        }

        public string Alterar(Cliente cliente)
        {

            try
            {
                _acessoDadosSql.LimparParametros();
                _acessoDadosSql.AdicionarParametros("@IdCliente",cliente.IdCliente);
                _acessoDadosSql.AdicionarParametros("@Nome", cliente.Nome);
                _acessoDadosSql.AdicionarParametros("@DataNascimento",cliente.DataNascimento);
                _acessoDadosSql.AdicionarParametros("@Sexo",cliente.Sexo);
                _acessoDadosSql.AdicionarParametros("@LimeteCompra",cliente.LimeteCompra);
                var retorno =    _acessoDadosSql.ExecutarManipulacao(CommandType.StoredProcedure, "upsClienteAlterar").ToString();

                return retorno;
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public string Deletar(Cliente cliente)
        {
            try
            {
                _acessoDadosSql.LimparParametros();
                _acessoDadosSql.AdicionarParametros("@IdCliente", cliente.IdCliente);
                var retorno = _acessoDadosSql.ExecutarManipulacao(CommandType.StoredProcedure, "upsClienteDeletar").ToString();

                return retorno;
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public ColecaoCliente ConsultarPorNome(string nome)
        {
            try
            {
               var clienteColecao = new ColecaoCliente();

                _acessoDadosSql.LimparParametros();
                _acessoDadosSql.AdicionarParametros("@Nome",nome);
                var dataTablecliente  =  _acessoDadosSql.ExecutarDataTable(CommandType.StoredProcedure,"uspClienteConsultarNome");

                clienteColecao.AddRange(from DataRow linha in dataTablecliente.Rows
                    select new Cliente
                    {
                        IdCliente = (int) linha["IdCliente"], Nome = (string) linha["Nome"], DataNascimento = (DateTime) linha["DataNascimento"], Sexo = (bool) linha["Sexo"], LimeteCompra = (decimal) linha["LimiteCompra"]
                    });
                return clienteColecao;
            }
            catch (Exception ex)
            {
                throw  new Exception("Não foi possível consultar o cliente por nome Detalhes: "+ex.Message);
                
            }
        }

        public ColecaoCliente ConsultarPorId(int idCliente)
        {
            try
            {
                var clienteColecao = new ColecaoCliente();
                _acessoDadosSql.LimparParametros();
                _acessoDadosSql.AdicionarParametros("@IdCliente",idCliente);
               var dataTabelCliente =   _acessoDadosSql.ExecutarDataTable(CommandType.StoredProcedure, "uspClienteConsultarPorId");

                clienteColecao.AddRange(from DataRow linha in dataTabelCliente.Rows
                                        select new Cliente
                                        {
                                            IdCliente = (int)linha["IdCliente"],
                                            Nome = (string)linha["Nome"],
                                            DataNascimento = (DateTime)linha["DataNascimento"],
                                            Sexo = (bool)linha["Sexo"],
                                            LimeteCompra = (decimal)linha["LimiteCompra"]
                                        });

                return clienteColecao;

            }
            catch (Exception ex)
            {
                    
                throw new Exception("Não foi possível consultar o cliente por id Detalhes: "+ ex.Message);
            }
        }
    }
}