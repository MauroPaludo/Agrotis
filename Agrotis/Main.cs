using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agrotis
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            CadastroCliente frmCliente= new CadastroCliente();
            frmCliente.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadastroProduto frmProduto = new CadastroProduto();
            frmProduto.ShowDialog();
        }

        private void btnCadastroPedidos_Click(object sender, EventArgs e)
        {
            CadastroPedido frmPedido = new CadastroPedido();
            frmPedido.ShowDialog();
        }
    }
}
