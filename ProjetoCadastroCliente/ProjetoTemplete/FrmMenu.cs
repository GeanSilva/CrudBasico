using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoTemplete
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
           var frmClienteSelecionar = new FrmClienteSelecionar();
            frmClienteSelecionar.MdiParent = this;
            frmClienteSelecionar.Show();
        }

        private void menuSair_Click(object sender, EventArgs e)
        {
          
            Application.Exit();
        }
    }
}
