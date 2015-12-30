using System;
using System.Windows.Forms;
using ProjetoDTO;
using ProjetoNegocio;

namespace ProjetoTemplete
{
    public partial class FrmCadastraCliente : Form
    {
        AcaoNaTela _acaoNatelaSelecionado = new AcaoNaTela();

        public FrmCadastraCliente(AcaoNaTela _acaoNaTela, Cliente cliente)
        {
            InitializeComponent();

            this._acaoNatelaSelecionado = _acaoNaTela;

            if (_acaoNaTela == AcaoNaTela.INSERIR)
            {
                this.Text = "Inserir Cliente";
            }
            else if (_acaoNaTela == AcaoNaTela.ALTERAR)
            {
                this.Text = "Alterar Cliente";
                texCodigo.Text = cliente.IdCliente.ToString();
                textNome.Text = cliente.Nome;
                dtp_Data.Value = cliente.DataNascimento;

                if (cliente.Sexo == true)
                {
                    radBtnSexoMasculino.Checked = true;
                }
                else
                    radBtnFemenino.Checked = false;

                textValorCompra.Text = cliente.LimeteCompra.ToString();

                //--------------------------------------------------------
            }
            else if (_acaoNaTela == AcaoNaTela.CONSULTAR)
            {
                Text = "Consultar Cliente";


                texCodigo.Text = cliente.IdCliente.ToString();
                textNome.Text = cliente.Nome;
                dtp_Data.Value = cliente.DataNascimento;

                if (cliente.Sexo == true)
                {
                    radBtnSexoMasculino.Checked = true;
                }
                else
                    radBtnFemenino.Checked = false;

                textValorCompra.Text = cliente.LimeteCompra.ToString();


                Desabilitado();
            }
        }

        private void Desabilitado()
        {
            textNome.Enabled = false;
            dtp_Data.Enabled = false;
            textValorCompra.Enabled = false;
            radBtnSexoMasculino.Enabled = false;
            radBtnFemenino.Enabled = false;
            btnCadastrar.Enabled = false;
            btnCadastrar.Text = "Fechar";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            var _cliente = new Cliente();
            var _clienteNegocio = new ClienteNegocios();

            if (_acaoNatelaSelecionado == AcaoNaTela.INSERIR)
            {
                _cliente.Nome = textNome.Text;
                _cliente.DataNascimento = dtp_Data.Value;

                if (radBtnSexoMasculino.Checked == true)
                {
                    _cliente.Sexo = true;
                }
                else
                {
                    _cliente.Sexo = false;
                }

                _cliente.LimeteCompra = Convert.ToDecimal(textValorCompra.Text);

                string retorno = _clienteNegocio.Inserir(_cliente);

                try
                {
                    int idCliente = Convert.ToInt32(retorno);

                    MessageBox.Show("Cliente cadastrado com sucesso! Código: " + idCliente.ToString(), "Sucesso",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                catch
                {

                    MessageBox.Show("Cliente  não cadastrado! Código: "+retorno, "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (_acaoNatelaSelecionado == AcaoNaTela.ALTERAR)
            {
                _cliente.IdCliente = Convert.ToInt32(texCodigo.Text);
                _cliente.Nome = textNome.Text;
                _cliente.DataNascimento = dtp_Data.Value;

                if (radBtnSexoMasculino.Checked == true)
                {
                    _cliente.Sexo = true;
                }
                else
                {
                    _cliente.Sexo = false;
                }

                _cliente.LimeteCompra = Convert.ToDecimal(textValorCompra.Text);

              string retorno =  _clienteNegocio.Alterar(_cliente);

                try
                {
                    int idCliente = Convert.ToInt32(retorno);

                    MessageBox.Show("Cliente Alterado com sucesso! Código: " + idCliente.ToString(), "Alterado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {

                    MessageBox.Show("Cliente não alterado! Código: " + retorno, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

       
    }
}
