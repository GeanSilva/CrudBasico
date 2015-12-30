using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoNegocio;
using ProjetoDTO;

namespace ProjetoTemplete
{
    public partial class FrmClienteSelecionar : Form
    {
        public FrmClienteSelecionar()
        {
            InitializeComponent();
            Tabela.AutoGenerateColumns = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            AtualizarGrid();
        }
        private void bnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void AtualizarGrid()
        {
            var clienteNegocios = new ClienteNegocios();
            var colecaoCliente = clienteNegocios.ConsultarPorNome(textBox.Text);

            Tabela.DataSource = null;
            Tabela.DataSource = colecaoCliente;

            Tabela.Update();
            Tabela.Refresh();
        }
        private void btnDeleta_Click(object sender, EventArgs e)
        {
            // messagem com retorno da falha se for vazia
            if (Tabela.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum cliente selecionado !","Falha",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

             DialogResult resultado =  MessageBox.Show("Tenha certeza se deseja excluir  ","Pergunta",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            // se a opção for não a execução e cancelada
            if (resultado == DialogResult.No)
            {
                return;
            }

            //Verifica se o cliente está selecinado na gride do sistema 
            var cliente = new Cliente();
            cliente = (Tabela.SelectedRows[0].DataBoundItem as Cliente);

            //Chamar o método para excluir
            var clienteNegocio = new ClienteNegocios();
            string retorno =  clienteNegocio.Deletar(cliente);

            try
            {
                int idCliente = Convert.ToInt32(retorno);
                MessageBox.Show("Cliente excluído com sucesso.","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
                AtualizarGrid();
            }
            catch 
            {

                MessageBox.Show("Não foi possível excluir." +retorno ,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void Alterar_Click(object sender, EventArgs e)
        {
            //instanciando o formulário de cadastro
            var inserir = new  FrmCadastraCliente(AcaoNaTela.INSERIR,null);

            DialogResult resultado = inserir.ShowDialog();

            if (resultado == DialogResult.Yes)
            {
                AtualizarGrid();
            }
            
        }

        private void btnAtuliza_Click(object sender, EventArgs e)
        {
           
            // messagem com retorno da falha se for vazia
            if (Tabela.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum cliente selecionado !", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Verifica se o cliente está selecinado na gride do sistema 
            var cliente = new Cliente();
            cliente = (Tabela.SelectedRows[0].DataBoundItem as Cliente);

            //instanciando o formulário de alterar
            var inserir = new FrmCadastraCliente(AcaoNaTela.ALTERAR,cliente);

            DialogResult resultado = inserir.ShowDialog();

            if (resultado == DialogResult.Yes)
            {
                AtualizarGrid();
            }

        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {

            // messagem com retorno da falha se for vazia
            if (Tabela.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum cliente selecionado !", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Verifica se o cliente está selecinado na gride do sistema 
            var cliente = new Cliente();
            cliente = (Tabela.SelectedRows[0].DataBoundItem as Cliente);

            //instanciando o formulário de consultar
            var inserir = new FrmCadastraCliente(AcaoNaTela.CONSULTAR,cliente);

            DialogResult resultado = inserir.ShowDialog();

            if (resultado == DialogResult.Yes)
            {
                AtualizarGrid();
            }
        }
    }
}
