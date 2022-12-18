using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Agrotis
{
    public partial class ZoomProdutos : Form
    {
        String tabela;
        public Object retorno;
        public string cod;
        public ZoomProdutos(String tabela)
        {
            this.tabela = tabela;
            InitializeComponent();
            FiltraDados();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            using (var context = new Contexto())
            {
                if (dataGridViewResult.SelectedRows.Count > 0)
                {
                    List<DataGridViewRow> rows_with_checked_column = new List<DataGridViewRow>();
                    foreach (DataGridViewRow row in dataGridViewResult.SelectedRows)
                    {                    
                        cod = row.Cells[codigo_produto.DataPropertyName].Value.ToString();
                        var ret = context.Cliente.Where(s => s.codigo_cliente == Convert.ToInt32(cod));
                    }
                    Close();
                }              
            }             
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            using (var context = new Contexto())
            {
                if(edtFiltro.Text != " ")
                {
                    var result = context.Cliente.Where(s => s.nome.Contains(edtFiltro.Text)).ToList();
                    dataGridViewResult.DataSource = result;
                }
            }
        }

        private void edtFiltro_TextChanged(object sender, EventArgs e)
        {
            FiltraDados();
        }

        private void FiltraDados()
        {
            using (var context = new Contexto())
            {
                if (tabela == "produto")
                {
                    var result = context.Produto.Where(s => s.descricao.Contains(edtFiltro.Text) || edtFiltro.Text == "").ToList();
                    dataGridViewResult.DataSource = result;
                }                

            }
        }

        private void dataGridViewResult_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
