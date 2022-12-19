using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agrotis
{
    public partial class CadastroProduto : Form
    {
        public Decimal produto;
        public String estado = "";
        public CadastroProduto()
        {
            InitializeComponent();
            CarregaDados();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (ValidaDados())
            {
                using (var context = new Contexto())
                {
                   context.Produto.Add(new Produto { descricao = edtDescricao.Text, peso_liquido = Convert.ToDecimal(edtPesoLiquido.Text), preco_unitario = Convert.ToDecimal(edtPrecoUnitario.Text) });
                   context.SaveChanges();
                }
            }
   
            CarregaDados();

        }

        private bool ValidaDados()
        {
            if (edtDescricao.Text == " ")
            {
                MessageBox.Show("É necessário informar uma descrição para o produto !!!");
                return false;
            }
            if (edtPesoLiquido.Text == " ")
            {
                MessageBox.Show("É necessário informar um peso para o produto !!!");
                return false;
            }
            if (edtPrecoUnitario.Text == " " || Convert.ToDecimal(edtPrecoUnitario.Text) <= 0)
            {
                MessageBox.Show("É necessário informar um preço para o produto !!!");
                return false;
            }
            return true;
        }


        private void btnAdicionar_Click_1(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            using (var context = new Contexto())
            {
                if (dataGridViewProdutos.SelectedRows.Count > 0)
                {
                    List<DataGridViewRow> rows_with_checked_column = new List<DataGridViewRow>();
                    foreach (DataGridViewRow row in dataGridViewProdutos.SelectedRows)
                    {
                        int cod = Convert.ToInt32(row.Cells[codigo_produto.DataPropertyName].Value.ToString());
                        Produto p = context.Produto.Where(s => s.codigo_produto == cod).FirstOrDefault();
                        context.Produto.Remove(p);
                        context.SaveChanges();
                        CarregaDados();
                    }
                }
                else
                {
                    MessageBox.Show("Selecione um Cadastro !!!");
                }
            }
        }
        private void CarregaDados()
        {
            using (var context = new Contexto())
            {
                dataGridViewProdutos.DataSource = context.Produto.ToList();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            using (var context = new Contexto())
            {
                if (dataGridViewProdutos.SelectedRows.Count > 0)
                {
                    List<DataGridViewRow> rows_with_checked_column = new List<DataGridViewRow>();
                    foreach (DataGridViewRow row in dataGridViewProdutos.SelectedRows)
                    {
                        int cod = Convert.ToInt32(row.Cells[codigo_produto.DataPropertyName].Value.ToString());
                        tabControl1.SelectedTab = tabControl1.TabPages[1];
                        produto = cod;
                        estado = "editar";
                    }
                }
                else
                {
                    MessageBox.Show("Selecione um Produto !!!");
                }
                CarregaItens();
            }
        }

        private void CarregaItens()
        {
            using (var context = new Contexto())
            {
                if (estado == "editar")
                {
                    Produto c = context.Produto.Where(s => s.codigo_produto == produto).FirstOrDefault();
                    edtCodigo.Text = c.codigo_produto.ToString();
                    edtDescricao.Text = c.descricao;
                    edtPesoLiquido.Text = c.peso_liquido.ToString();
                    edtPrecoUnitario.Text = c.preco_unitario.ToString();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var context = new Contexto())
            {
                if (ValidaDados())
                {
                    if (estado == "novo")
                    {
                        context.Produto.Add(new Produto
                        {
                            descricao = edtDescricao.Text,
                            peso_liquido = Convert.ToDecimal(edtPesoLiquido.Text),
                            preco_unitario = Convert.ToDecimal(edtPrecoUnitario.Text)                      
                        });
                        context.SaveChanges();
                        tabControl1.SelectedTab = tabControl1.TabPages[0];
                        CarregaDados();
                        LimpaCampos();
                    }
                    else
                    {
                        Produto p = context.Produto.Where(s => s.codigo_produto == produto).FirstOrDefault();
                        p.descricao = edtDescricao.Text;
                        p.peso_liquido = Convert.ToDecimal(edtPesoLiquido.Text);
                        p.preco_unitario = Convert.ToDecimal(edtPrecoUnitario.Text);
                        context.SaveChanges();
                        tabControl1.SelectedTab = tabControl1.TabPages[0];
                        CarregaDados();
                        LimpaCampos();
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages[0];
            LimpaCampos();
        }

        private void LimpaCampos()
        {
            edtCodigo.Text = "";
            edtDescricao.Text = "";
            edtPesoLiquido.Text = "";
            edtPrecoUnitario.Text = "";
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            estado = "novo";
            tabControl1.SelectedTab = tabControl1.TabPages[1];
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
