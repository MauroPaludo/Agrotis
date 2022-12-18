using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Agrotis
{
    public partial class CadastroPedido : Form
    {
        public int pedido;
        public int produto;
        public String estado = "";
        public String estado_item = "";
        public bool pendingEntityChanges = false;
        public CadastroPedido()
        {
            InitializeComponent();
            CarregaDados();
        }

        private void CarregaDados()
        {
            using (var context = new Contexto())
            {
                dataGridViewPedidos.DataSource = context.Pedido.ToList();
            }
        }

        private void CarregaItens()
        {
            using (var context = new Contexto())
            {
                if (estado == "editar")
                {
                    Pedido ped = context.Pedido.Where(s => s.codigo_pedido == pedido).FirstOrDefault();
                    edtCodigoPedido.Text = ped.codigo_pedido.ToString();
                    edtNomeCliente.Text = ped.nome_cliente;
                    edtCodigoCliente.Text = ped.codigo_cliente.ToString();
                    dateEmissao.Value = ped.emissao;
                    edtPesoTotalPedido.Text = ped.peso_pedido.ToString();
                    edtPrecoTotalPedido.Text = ped.preco_pedido.ToString();
                    dataGridViewItensPedido.DataSource = context.ItensPedido.Where(s => s.codigo_pedido == pedido).ToList();
                }
                else
                {
                }
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages[1];
            pedido = 0;
            estado = "novo";
            CarregaItens();
        }

        private bool ValidaDados()
        {
             if (edtNomeCliente.Text == "" || edtCodigoCliente.Text == "")
             {
                 MessageBox.Show("É necessário informar um nome !!!");
                 return false;
             }
             if(dateEmissao.Text == "")
             {
                MessageBox.Show("É necessário informar a adat de emissão !!!");
                return false;
             }
            return true;
        }

        private void AtualizaGrid()
        {
            using (var context = new Contexto())
            {
                //  dataGridViewClientes.DataSource = context.Cliente.ToList();
                Decimal pedido = Convert.ToDecimal(edtCodigoPedido.Text);
                dataGridViewItensPedido.DataSource = context.ItensPedido.Where(s => s.codigo_pedido == pedido).ToList();
            }

        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {

        }

        private void btnProduto_Click(object sender, EventArgs e)
        {

        }

        private void edtQuantidade_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAdicionarItem_Click(object sender, EventArgs e)
        {

        }

        private bool ValidaItem()
        {
            if (edtProduto.Text == "")
            {
                MessageBox.Show("É necessário informar um produto !!!");
                return false;
            }
            if (edtQuantidade.Text == "")
            {
                MessageBox.Show("É necessário informar a quantidade do item !!!");
                return false;
            }
            return true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBuscarCliente_Click_1(object sender, EventArgs e)
        {
            ZoomClientes frmZoom = new ZoomClientes("cliente");
            frmZoom.ShowDialog();
            if (frmZoom.cod != null)
            {
                using (var context = new Contexto())
                {
                    Decimal cod = Convert.ToDecimal(frmZoom.cod);
                    // Cliente cliente = (Cliente)frmZoom.retorno;
                    Cliente cliente = context.Cliente.Where(s => s.codigo_cliente == cod).FirstOrDefault();
                    edtCodigoCliente.Text = cliente.codigo_cliente.ToString();
                    edtNomeCliente.Text = cliente.nome;
                }

            }
        }

        private void btnProduto_Click_1(object sender, EventArgs e)
        {
            ZoomProdutos frmZoom = new ZoomProdutos("produto");
            frmZoom.ShowDialog();
            if (frmZoom.cod != null)
            {
                using (var context = new Contexto())
                {
                    Decimal cod = Convert.ToDecimal(frmZoom.cod);
                    Produto produto = context.Produto.Where(s => s.codigo_produto == cod).FirstOrDefault();
                    edtProduto.Text = produto.codigo_produto.ToString();
                    edtDescricaoProduto.Text = produto.descricao;
                    edtPesoUnitario.Text = produto.peso_liquido.ToString();
                    edtUnitario.Text = produto.preco_unitario.ToString();
                }

            }
        }

        private void btnAdicionarItem_Click_1(object sender, EventArgs e)
        {

        }
        private void LimpaCampos()
        {
            edtDescricaoProduto.Text = "";
            edtQuantidade.Value = 0;
            edtPesoItem.Text = "";
            edtPrecoItem.Text = "";
            edtUnitario.Text = "";
            edtPesoUnitario.Text = "";
            edtProduto.Text = "";
        }

        private void edtQuantidade_ValueChanged_1(object sender, EventArgs e)
        {
            if (edtQuantidade.Text != "" && edtPesoUnitario.Text != "")
            {
                edtPesoItem.Text = (Convert.ToDecimal(edtPesoUnitario.Text) * edtQuantidade.Value).ToString();
                edtPrecoItem.Text = (Convert.ToDecimal(edtUnitario.Text) * edtQuantidade.Value).ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            using (var context = new Contexto())
            {
                if (dataGridViewPedidos.SelectedRows.Count > 0)
                {
                    List<DataGridViewRow> rows_with_checked_column = new List<DataGridViewRow>();
                    foreach (DataGridViewRow row in dataGridViewPedidos.SelectedRows)
                    {
                        int cod = Convert.ToInt32(row.Cells[codigo_pedido.DataPropertyName].Value.ToString());
                        Pedido ped = context.Pedido.Where(s => s.codigo_pedido == cod).FirstOrDefault();

                        tabControl1.SelectedTab = tabControl1.TabPages[1];
                        pedido = cod;
                        estado = "editar";
                    }
                }
                else
                {
                    MessageBox.Show("Selecione um Registro !!!");
                }
                CarregaItens();
            }

        }

        private void lblProduto_Click(object sender, EventArgs e)
        {

        }

        private void btnEditarItem_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            using (var context = new Contexto())
            {
                context.SaveChanges();
                LimpaCampos();
                tabControl1.SelectedTab = tabControl1.TabPages[0];
                CarregaDados();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var context = new Contexto())
            {
                LimpaCampos();
                CarregaDados();
                tabControl1.SelectedTab = tabControl1.TabPages[0];
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
          
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConfirmarItem_Click(object sender, EventArgs e)
        {
            using (var context = new Contexto())
            {
                int nro_pedido = Convert.ToInt32(edtCodigoPedido.Text);
                Decimal preco_total = 0;
                Decimal peso_total = 0;

                if (estado == "novo" && ValidaDados())
                {
                    context.Pedido.Add(new Pedido { codigo_pedido = Convert.ToInt32(edtCodigoPedido.Text), codigo_cliente = Convert.ToInt32(edtCodigoCliente.Text), nome_cliente = edtNomeCliente.Text, emissao = dateEmissao.Value });
                    context.SaveChanges();
                }

                if (ValidaItem())
                {
                    if (estado_item == "editar" && pedido != 0)
                    {
                        ItensPedido ped = context.ItensPedido.Where(s => s.codigo_itenspedido == produto).FirstOrDefault();
                        ped.quantidade = edtQuantidade.Value;
                        ped.peso_total = Convert.ToDecimal(edtPesoItem.Text);
                        ped.preco_total = Convert.ToDecimal(edtPrecoItem.Text);
                        ped.codigo_produto = Convert.ToInt32(edtProduto.Text);
                        ped.preco_unitario = Convert.ToDecimal(edtUnitario.Text);
                        ped.peso_liquido = Convert.ToDecimal(edtPesoUnitario.Text);
                    }
                    else
                    {
                        context.ItensPedido.Add(new ItensPedido()
                        {
                            codigo_pedido = Convert.ToInt32(edtCodigoPedido.Text),
                            quantidade = edtQuantidade.Value,
                            peso_total = Convert.ToDecimal(edtPesoItem.Text),
                            preco_total = Convert.ToDecimal(edtPrecoItem.Text),
                            codigo_produto = Convert.ToInt32(edtProduto.Text),
                            preco_unitario = Convert.ToDecimal(edtUnitario.Text),
                            peso_liquido = Convert.ToDecimal(edtPesoUnitario.Text),
                        });
                    }
                    context.SaveChanges();
                    LimpaCampos();
                    estado_item = "novo";
                }

                foreach (ItensPedido itens in context.ItensPedido.Where(s => s.codigo_pedido == nro_pedido).ToList())
                {
                    peso_total += itens.peso_total;
                    preco_total += itens.preco_total;
                    Pedido ped = context.Pedido.Where(s => s.codigo_pedido == nro_pedido).FirstOrDefault();
                    ped.peso_pedido = peso_total;
                    ped.preco_pedido = preco_total;
                    edtPrecoTotalPedido.Text = ped.preco_pedido.ToString();
                    edtPesoTotalPedido.Text = ped.peso_pedido.ToString();
                    context.SaveChanges();
                }
                AtualizaGrid();
                estado = "editar";
            }
        }

        private void btnAdicionaItem_Click(object sender, EventArgs e)
        {
            estado_item = "novo";

        }

        private void btnEditarItem_Click_1(object sender, EventArgs e)
        {
            using (var context = new Contexto())
            {
                if (dataGridViewItensPedido.SelectedRows.Count > 0)
                {
                    List<DataGridViewRow> rows_with_checked_column = new List<DataGridViewRow>();
                    foreach (DataGridViewRow row in dataGridViewItensPedido.SelectedRows)
                    {
                        int cod = Convert.ToInt32(row.Cells[codigo_itenspedido.DataPropertyName].Value.ToString());
                        ItensPedido item = context.ItensPedido.Where(s => s.codigo_itenspedido == cod).FirstOrDefault();
                        edtProduto.Text = item.codigo_produto.ToString();
                        edtQuantidade.Text = item.quantidade.ToString();
                        edtUnitario.Text = item.preco_unitario.ToString();
                        edtPesoUnitario.Text = item.peso_liquido.ToString();
                        edtPesoItem.Text = item.peso_total.ToString();
                        edtPrecoItem.Text = item.preco_total.ToString();
                        produto = cod;
                    }
                }
                else
                {
                    MessageBox.Show("Selecione um Registro !!!");
                }
                estado_item = "editar";

                CarregaDados();
            }
        }

        private void btnRemoverItem_Click(object sender, EventArgs e)
        {
            using (var context = new Contexto())
            {
                if (dataGridViewItensPedido.SelectedRows.Count > 0)
                {
                    List<DataGridViewRow> rows_with_checked_column = new List<DataGridViewRow>();
                    foreach (DataGridViewRow row in dataGridViewItensPedido.SelectedRows)
                    {
                        int cod = Convert.ToInt32(row.Cells[codigo_itenspedido.DataPropertyName].Value.ToString());
                        ItensPedido item = context.ItensPedido.Where(s => s.codigo_itenspedido == cod).FirstOrDefault();
                        context.ItensPedido.Remove(item);
                        MessageBox.Show("Item removido com sucesso !!!");
                        context.SaveChanges();
                        CarregaItens();
                    }
                }
                else
                {
                    MessageBox.Show("Selecione um Registro !!!");
                }
                CarregaDados();
                estado_item = "novo";
            }
        }

        private void dataGridViewPedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages[1];
            pedido = 0;
            estado = "novo";
            using (var context = new Contexto())
            {
                var ultimo = context.Pedido.OrderByDescending(s => s.codigo_pedido).FirstOrDefault();
                if (ultimo != null)
                {
                    edtCodigoPedido.Text = (ultimo.codigo_pedido + 1).ToString();
                }
                else
                {
                    edtCodigoPedido.Text = "1";
                }

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            using (var context = new Contexto())
            {
                if (dataGridViewPedidos.SelectedRows.Count > 0)
                {
                    List<DataGridViewRow> rows_with_checked_column = new List<DataGridViewRow>();
                    foreach (DataGridViewRow row in dataGridViewPedidos.SelectedRows)
                    {
                        int cod = Convert.ToInt32(row.Cells[codigo_pedido.DataPropertyName].Value.ToString());
                        Pedido ped = context.Pedido.Where(s => s.codigo_pedido == cod).FirstOrDefault();
                        context.Pedido.Remove(ped);
                        context.SaveChanges();
                        CarregaDados();
                    }
                }
                else
                {
                    MessageBox.Show("Selecione um Pedido !!!");
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (var context = new Contexto())
            {
                if (dataGridViewPedidos.SelectedRows.Count > 0)
                {
                    List<DataGridViewRow> rows_with_checked_column = new List<DataGridViewRow>();
                    foreach (DataGridViewRow row in dataGridViewPedidos.SelectedRows)
                    {
                        int cod = Convert.ToInt32(row.Cells[codigo_pedido.DataPropertyName].Value.ToString());
                        Pedido ped = context.Pedido.Where(s => s.codigo_pedido == cod).FirstOrDefault();

                        tabControl1.SelectedTab = tabControl1.TabPages[1];
                        pedido = cod;
                        estado = "editar";
                        CarregaItens();
                    }
                }
                else
                {
                    MessageBox.Show("Selecione um Pedido !!!");
                }
            }
        }
    }    
}
