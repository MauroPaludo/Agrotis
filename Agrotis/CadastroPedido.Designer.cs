namespace Agrotis
{
    partial class CadastroPedido
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.dataGridViewPedidos = new System.Windows.Forms.DataGridView();
            this.codigo_pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emissao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peso_pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preco_pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panelItens = new System.Windows.Forms.Panel();
            this.btnEditarItem = new System.Windows.Forms.Button();
            this.btnRemoverItem = new System.Windows.Forms.Button();
            this.btnConfirmarItem = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.edtPrecoItem = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.edtPesoItem = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.edtPesoUnitario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.edtUnitario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.edtQuantidade = new System.Windows.Forms.NumericUpDown();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.edtProduto = new System.Windows.Forms.TextBox();
            this.lblProduto = new System.Windows.Forms.Label();
            this.edtDescricaoProduto = new System.Windows.Forms.TextBox();
            this.btnProduto = new System.Windows.Forms.Button();
            this.lblItens = new System.Windows.Forms.Label();
            this.dataGridViewItensPedido = new System.Windows.Forms.DataGridView();
            this.dateEmissao = new System.Windows.Forms.DateTimePicker();
            this.lblNumeroPedido = new System.Windows.Forms.Label();
            this.edtCodigoPedido = new System.Windows.Forms.TextBox();
            this.edtNomeCliente = new System.Windows.Forms.TextBox();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.lblBairro = new System.Windows.Forms.Label();
            this.edtPesoTotalPedido = new System.Windows.Forms.TextBox();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.edtPrecoTotalPedido = new System.Windows.Forms.TextBox();
            this.lblLogradouro = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.edtCodigoCliente = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.codigo_itenspedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo_pedido2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo_produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao_produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preco_unitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peso_liquido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preco_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peso_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPedidos)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panelItens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edtQuantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItensPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(824, 715);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Controls.Add(this.button6);
            this.tabPage1.Controls.Add(this.button7);
            this.tabPage1.Controls.Add(this.dataGridViewPedidos);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(816, 689);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pedidos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Image = global::Agrotis.Properties.Resources.adicionar_aplicativos__2___1_;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(724, 646);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(89, 37);
            this.button4.TabIndex = 19;
            this.button4.Text = "    Novo";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Image = global::Agrotis.Properties.Resources.botao_editar__2_1;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(551, 646);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(82, 37);
            this.button5.TabIndex = 18;
            this.button5.Text = "    Editar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Image = global::Agrotis.Properties.Resources.excluir_aplicativos__1___1_;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(633, 646);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(91, 37);
            this.button6.TabIndex = 17;
            this.button6.Text = "    Excluir";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Image = global::Agrotis.Properties.Resources.cruz__1___1_;
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(459, 646);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(93, 37);
            this.button7.TabIndex = 16;
            this.button7.Text = "    Fechar";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // dataGridViewPedidos
            // 
            this.dataGridViewPedidos.AllowUserToAddRows = false;
            this.dataGridViewPedidos.AllowUserToDeleteRows = false;
            this.dataGridViewPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo_pedido,
            this.codigo_cliente,
            this.nome_cliente,
            this.emissao,
            this.peso_pedido,
            this.preco_pedido});
            this.dataGridViewPedidos.Location = new System.Drawing.Point(7, 6);
            this.dataGridViewPedidos.Name = "dataGridViewPedidos";
            this.dataGridViewPedidos.ReadOnly = true;
            this.dataGridViewPedidos.Size = new System.Drawing.Size(803, 634);
            this.dataGridViewPedidos.TabIndex = 0;
            this.dataGridViewPedidos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPedidos_CellContentClick);
            // 
            // codigo_pedido
            // 
            this.codigo_pedido.DataPropertyName = "codigo_pedido";
            this.codigo_pedido.HeaderText = "Nro Pedido";
            this.codigo_pedido.Name = "codigo_pedido";
            this.codigo_pedido.ReadOnly = true;
            // 
            // codigo_cliente
            // 
            this.codigo_cliente.DataPropertyName = "codigo_cliente";
            this.codigo_cliente.HeaderText = "Cliente";
            this.codigo_cliente.Name = "codigo_cliente";
            this.codigo_cliente.ReadOnly = true;
            this.codigo_cliente.Width = 120;
            // 
            // nome_cliente
            // 
            this.nome_cliente.DataPropertyName = "nome_cliente";
            this.nome_cliente.HeaderText = "Nome";
            this.nome_cliente.Name = "nome_cliente";
            this.nome_cliente.ReadOnly = true;
            this.nome_cliente.Width = 250;
            // 
            // emissao
            // 
            this.emissao.DataPropertyName = "emissao";
            this.emissao.HeaderText = "Data Emissão";
            this.emissao.Name = "emissao";
            this.emissao.ReadOnly = true;
            // 
            // peso_pedido
            // 
            this.peso_pedido.DataPropertyName = "peso_pedido";
            this.peso_pedido.HeaderText = "Peso Pedido";
            this.peso_pedido.Name = "peso_pedido";
            this.peso_pedido.ReadOnly = true;
            // 
            // preco_pedido
            // 
            this.preco_pedido.DataPropertyName = "preco_pedido";
            this.preco_pedido.HeaderText = "Preço Pedido";
            this.preco_pedido.Name = "preco_pedido";
            this.preco_pedido.ReadOnly = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panelItens);
            this.tabPage2.Controls.Add(this.dateEmissao);
            this.tabPage2.Controls.Add(this.lblNumeroPedido);
            this.tabPage2.Controls.Add(this.edtCodigoPedido);
            this.tabPage2.Controls.Add(this.edtNomeCliente);
            this.tabPage2.Controls.Add(this.btnBuscarCliente);
            this.tabPage2.Controls.Add(this.lblBairro);
            this.tabPage2.Controls.Add(this.edtPesoTotalPedido);
            this.tabPage2.Controls.Add(this.lblComplemento);
            this.tabPage2.Controls.Add(this.edtPrecoTotalPedido);
            this.tabPage2.Controls.Add(this.lblLogradouro);
            this.tabPage2.Controls.Add(this.lblCliente);
            this.tabPage2.Controls.Add(this.edtCodigoCliente);
            this.tabPage2.Controls.Add(this.btnAdicionar);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(816, 689);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Editar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panelItens
            // 
            this.panelItens.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelItens.Controls.Add(this.btnEditarItem);
            this.panelItens.Controls.Add(this.btnRemoverItem);
            this.panelItens.Controls.Add(this.btnConfirmarItem);
            this.panelItens.Controls.Add(this.button2);
            this.panelItens.Controls.Add(this.button1);
            this.panelItens.Controls.Add(this.edtPrecoItem);
            this.panelItens.Controls.Add(this.label4);
            this.panelItens.Controls.Add(this.edtPesoItem);
            this.panelItens.Controls.Add(this.label3);
            this.panelItens.Controls.Add(this.edtPesoUnitario);
            this.panelItens.Controls.Add(this.label2);
            this.panelItens.Controls.Add(this.edtUnitario);
            this.panelItens.Controls.Add(this.label1);
            this.panelItens.Controls.Add(this.edtQuantidade);
            this.panelItens.Controls.Add(this.lblQuantidade);
            this.panelItens.Controls.Add(this.edtProduto);
            this.panelItens.Controls.Add(this.lblProduto);
            this.panelItens.Controls.Add(this.edtDescricaoProduto);
            this.panelItens.Controls.Add(this.btnProduto);
            this.panelItens.Controls.Add(this.lblItens);
            this.panelItens.Controls.Add(this.dataGridViewItensPedido);
            this.panelItens.Location = new System.Drawing.Point(7, 146);
            this.panelItens.Name = "panelItens";
            this.panelItens.Size = new System.Drawing.Size(806, 537);
            this.panelItens.TabIndex = 38;
            this.panelItens.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // btnEditarItem
            // 
            this.btnEditarItem.Image = global::Agrotis.Properties.Resources.botao_editar__2_1;
            this.btnEditarItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarItem.Location = new System.Drawing.Point(704, 126);
            this.btnEditarItem.Name = "btnEditarItem";
            this.btnEditarItem.Size = new System.Drawing.Size(96, 36);
            this.btnEditarItem.TabIndex = 8;
            this.btnEditarItem.Text = "     Editar ";
            this.btnEditarItem.UseVisualStyleBackColor = true;
            this.btnEditarItem.Click += new System.EventHandler(this.btnEditarItem_Click_1);
            // 
            // btnRemoverItem
            // 
            this.btnRemoverItem.Image = global::Agrotis.Properties.Resources.excluir_aplicativos__1___1_1;
            this.btnRemoverItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoverItem.Location = new System.Drawing.Point(610, 126);
            this.btnRemoverItem.Name = "btnRemoverItem";
            this.btnRemoverItem.Size = new System.Drawing.Size(97, 36);
            this.btnRemoverItem.TabIndex = 7;
            this.btnRemoverItem.Text = "       Remover ";
            this.btnRemoverItem.UseVisualStyleBackColor = true;
            this.btnRemoverItem.Click += new System.EventHandler(this.btnRemoverItem_Click);
            // 
            // btnConfirmarItem
            // 
            this.btnConfirmarItem.Image = global::Agrotis.Properties.Resources.marca_de_verificacao__1_;
            this.btnConfirmarItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmarItem.Location = new System.Drawing.Point(512, 126);
            this.btnConfirmarItem.Name = "btnConfirmarItem";
            this.btnConfirmarItem.Size = new System.Drawing.Size(99, 36);
            this.btnConfirmarItem.TabIndex = 6;
            this.btnConfirmarItem.Text = "      Confirmar";
            this.btnConfirmarItem.UseVisualStyleBackColor = true;
            this.btnConfirmarItem.Click += new System.EventHandler(this.btnConfirmarItem_Click);
            // 
            // button2
            // 
            this.button2.Image = global::Agrotis.Properties.Resources.cruz__1___1_;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(699, 491);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 45);
            this.button2.TabIndex = 42;
            this.button2.Text = "    Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Image = global::Agrotis.Properties.Resources.opcao_de_salvar_arquivo__1_;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(589, 491);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 45);
            this.button1.TabIndex = 41;
            this.button1.Text = "    Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // edtPrecoItem
            // 
            this.edtPrecoItem.Enabled = false;
            this.edtPrecoItem.Location = new System.Drawing.Point(130, 132);
            this.edtPrecoItem.Name = "edtPrecoItem";
            this.edtPrecoItem.Size = new System.Drawing.Size(73, 20);
            this.edtPrecoItem.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Total Item (R$):";
            // 
            // edtPesoItem
            // 
            this.edtPesoItem.Enabled = false;
            this.edtPesoItem.Location = new System.Drawing.Point(348, 132);
            this.edtPesoItem.Name = "edtPesoItem";
            this.edtPesoItem.Size = new System.Drawing.Size(73, 20);
            this.edtPesoItem.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(240, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Peso Total Item (KG):";
            // 
            // edtPesoUnitario
            // 
            this.edtPesoUnitario.Enabled = false;
            this.edtPesoUnitario.Location = new System.Drawing.Point(349, 57);
            this.edtPesoUnitario.Name = "edtPesoUnitario";
            this.edtPesoUnitario.Size = new System.Drawing.Size(73, 20);
            this.edtPesoUnitario.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Peso Unitário (KG):";
            // 
            // edtUnitario
            // 
            this.edtUnitario.Enabled = false;
            this.edtUnitario.Location = new System.Drawing.Point(128, 56);
            this.edtUnitario.Name = "edtUnitario";
            this.edtUnitario.Size = new System.Drawing.Size(73, 20);
            this.edtUnitario.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Unitário (R$):";
            // 
            // edtQuantidade
            // 
            this.edtQuantidade.Location = new System.Drawing.Point(128, 83);
            this.edtQuantidade.Name = "edtQuantidade";
            this.edtQuantidade.Size = new System.Drawing.Size(73, 20);
            this.edtQuantidade.TabIndex = 5;
            this.edtQuantidade.ValueChanged += new System.EventHandler(this.edtQuantidade_ValueChanged_1);
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(59, 87);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(65, 13);
            this.lblQuantidade.TabIndex = 25;
            this.lblQuantidade.Text = "Quantidade:";
            // 
            // edtProduto
            // 
            this.edtProduto.Enabled = false;
            this.edtProduto.Location = new System.Drawing.Point(128, 30);
            this.edtProduto.Name = "edtProduto";
            this.edtProduto.Size = new System.Drawing.Size(73, 20);
            this.edtProduto.TabIndex = 24;
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Location = new System.Drawing.Point(78, 33);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(47, 13);
            this.lblProduto.TabIndex = 23;
            this.lblProduto.Text = "Produto:";
            this.lblProduto.Click += new System.EventHandler(this.lblProduto_Click);
            // 
            // edtDescricaoProduto
            // 
            this.edtDescricaoProduto.Enabled = false;
            this.edtDescricaoProduto.Location = new System.Drawing.Point(207, 30);
            this.edtDescricaoProduto.Name = "edtDescricaoProduto";
            this.edtDescricaoProduto.Size = new System.Drawing.Size(307, 20);
            this.edtDescricaoProduto.TabIndex = 22;
            // 
            // btnProduto
            // 
            this.btnProduto.Image = global::Agrotis.Properties.Resources.procurar__1_;
            this.btnProduto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduto.Location = new System.Drawing.Point(519, 19);
            this.btnProduto.Name = "btnProduto";
            this.btnProduto.Size = new System.Drawing.Size(116, 43);
            this.btnProduto.TabIndex = 4;
            this.btnProduto.Text = "    Buscar Produto";
            this.btnProduto.UseVisualStyleBackColor = true;
            this.btnProduto.Click += new System.EventHandler(this.btnProduto_Click_1);
            // 
            // lblItens
            // 
            this.lblItens.AutoSize = true;
            this.lblItens.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItens.Location = new System.Drawing.Point(4, 2);
            this.lblItens.Name = "lblItens";
            this.lblItens.Size = new System.Drawing.Size(44, 16);
            this.lblItens.TabIndex = 12;
            this.lblItens.Text = "Itens:";
            // 
            // dataGridViewItensPedido
            // 
            this.dataGridViewItensPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewItensPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo_itenspedido,
            this.codigo_pedido2,
            this.codigo_produto,
            this.descricao_produto,
            this.quantidade,
            this.preco_unitario,
            this.peso_liquido,
            this.preco_total,
            this.peso_total});
            this.dataGridViewItensPedido.Location = new System.Drawing.Point(13, 168);
            this.dataGridViewItensPedido.Name = "dataGridViewItensPedido";
            this.dataGridViewItensPedido.Size = new System.Drawing.Size(790, 317);
            this.dataGridViewItensPedido.TabIndex = 4;
            // 
            // dateEmissao
            // 
            this.dateEmissao.Location = new System.Drawing.Point(77, 62);
            this.dateEmissao.Name = "dateEmissao";
            this.dateEmissao.Size = new System.Drawing.Size(215, 20);
            this.dateEmissao.TabIndex = 3;
            // 
            // lblNumeroPedido
            // 
            this.lblNumeroPedido.AutoSize = true;
            this.lblNumeroPedido.Location = new System.Drawing.Point(10, 13);
            this.lblNumeroPedido.Name = "lblNumeroPedido";
            this.lblNumeroPedido.Size = new System.Drawing.Size(63, 13);
            this.lblNumeroPedido.TabIndex = 36;
            this.lblNumeroPedido.Text = "Pedido Nro:";
            // 
            // edtCodigoPedido
            // 
            this.edtCodigoPedido.Enabled = false;
            this.edtCodigoPedido.Location = new System.Drawing.Point(77, 10);
            this.edtCodigoPedido.Name = "edtCodigoPedido";
            this.edtCodigoPedido.Size = new System.Drawing.Size(183, 20);
            this.edtCodigoPedido.TabIndex = 1;
            // 
            // edtNomeCliente
            // 
            this.edtNomeCliente.Enabled = false;
            this.edtNomeCliente.Location = new System.Drawing.Point(156, 35);
            this.edtNomeCliente.Name = "edtNomeCliente";
            this.edtNomeCliente.Size = new System.Drawing.Size(307, 20);
            this.edtNomeCliente.TabIndex = 34;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Image = global::Agrotis.Properties.Resources.procurar__1_;
            this.btnBuscarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarCliente.Location = new System.Drawing.Point(467, 23);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(118, 42);
            this.btnBuscarCliente.TabIndex = 2;
            this.btnBuscarCliente.Text = "    Buscar Cliente";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click_1);
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblBairro.Location = new System.Drawing.Point(573, 118);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(144, 13);
            this.lblBairro.TabIndex = 32;
            this.lblBairro.Text = "Peso Total Pedido (KG):";
            // 
            // edtPesoTotalPedido
            // 
            this.edtPesoTotalPedido.Enabled = false;
            this.edtPesoTotalPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtPesoTotalPedido.Location = new System.Drawing.Point(723, 113);
            this.edtPesoTotalPedido.Name = "edtPesoTotalPedido";
            this.edtPesoTotalPedido.Size = new System.Drawing.Size(75, 22);
            this.edtPesoTotalPedido.TabIndex = 31;
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComplemento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblComplemento.Location = new System.Drawing.Point(568, 92);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(148, 13);
            this.lblComplemento.TabIndex = 30;
            this.lblComplemento.Text = "Preço Total Pedido (R$):";
            // 
            // edtPrecoTotalPedido
            // 
            this.edtPrecoTotalPedido.Enabled = false;
            this.edtPrecoTotalPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtPrecoTotalPedido.Location = new System.Drawing.Point(723, 87);
            this.edtPrecoTotalPedido.Name = "edtPrecoTotalPedido";
            this.edtPrecoTotalPedido.Size = new System.Drawing.Size(75, 22);
            this.edtPrecoTotalPedido.TabIndex = 29;
            // 
            // lblLogradouro
            // 
            this.lblLogradouro.AutoSize = true;
            this.lblLogradouro.Location = new System.Drawing.Point(39, 62);
            this.lblLogradouro.Name = "lblLogradouro";
            this.lblLogradouro.Size = new System.Drawing.Size(33, 13);
            this.lblLogradouro.TabIndex = 28;
            this.lblLogradouro.Text = "Data:";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(32, 39);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(42, 13);
            this.lblCliente.TabIndex = 27;
            this.lblCliente.Text = "Cliente:";
            // 
            // edtCodigoCliente
            // 
            this.edtCodigoCliente.Enabled = false;
            this.edtCodigoCliente.Location = new System.Drawing.Point(77, 35);
            this.edtCodigoCliente.Name = "edtCodigoCliente";
            this.edtCodigoCliente.Size = new System.Drawing.Size(75, 20);
            this.edtCodigoCliente.TabIndex = 26;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(734, 205);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 25;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // codigo_itenspedido
            // 
            this.codigo_itenspedido.DataPropertyName = "codigo_itenspedido";
            this.codigo_itenspedido.HeaderText = "codigo_itenspedido";
            this.codigo_itenspedido.Name = "codigo_itenspedido";
            this.codigo_itenspedido.Visible = false;
            // 
            // codigo_pedido2
            // 
            this.codigo_pedido2.DataPropertyName = "codigo_pedido";
            this.codigo_pedido2.HeaderText = "Pedido";
            this.codigo_pedido2.Name = "codigo_pedido2";
            // 
            // codigo_produto
            // 
            this.codigo_produto.DataPropertyName = "codigo_produto";
            this.codigo_produto.HeaderText = "Produto";
            this.codigo_produto.Name = "codigo_produto";
            this.codigo_produto.Width = 50;
            // 
            // descricao_produto
            // 
            this.descricao_produto.DataPropertyName = "descricao_produto";
            this.descricao_produto.HeaderText = "Descrição";
            this.descricao_produto.Name = "descricao_produto";
            // 
            // quantidade
            // 
            this.quantidade.DataPropertyName = "quantidade";
            this.quantidade.HeaderText = "Quantidade";
            this.quantidade.Name = "quantidade";
            // 
            // preco_unitario
            // 
            this.preco_unitario.DataPropertyName = "preco_unitario";
            this.preco_unitario.HeaderText = "Unitário";
            this.preco_unitario.Name = "preco_unitario";
            // 
            // peso_liquido
            // 
            this.peso_liquido.DataPropertyName = "peso_liquido";
            this.peso_liquido.HeaderText = "Peso Unitário";
            this.peso_liquido.Name = "peso_liquido";
            // 
            // preco_total
            // 
            this.preco_total.DataPropertyName = "preco_total";
            this.preco_total.HeaderText = "Preço";
            this.preco_total.Name = "preco_total";
            // 
            // peso_total
            // 
            this.peso_total.DataPropertyName = "peso_total";
            this.peso_total.HeaderText = "Peso Item";
            this.peso_total.Name = "peso_total";
            // 
            // CadastroPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 751);
            this.Controls.Add(this.tabControl1);
            this.Name = "CadastroPedido";
            this.Text = "Pedidos";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPedidos)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panelItens.ResumeLayout(false);
            this.panelItens.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edtQuantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItensPedido)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridViewPedidos;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panelItens;
        private System.Windows.Forms.TextBox edtPrecoItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox edtPesoItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox edtPesoUnitario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox edtUnitario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown edtQuantidade;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.TextBox edtProduto;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.TextBox edtDescricaoProduto;
        private System.Windows.Forms.Button btnProduto;
        private System.Windows.Forms.Label lblItens;
        private System.Windows.Forms.DataGridView dataGridViewItensPedido;
        private System.Windows.Forms.DateTimePicker dateEmissao;
        private System.Windows.Forms.Label lblNumeroPedido;
        private System.Windows.Forms.TextBox edtCodigoPedido;
        private System.Windows.Forms.TextBox edtNomeCliente;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox edtPesoTotalPedido;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.TextBox edtPrecoTotalPedido;
        private System.Windows.Forms.Label lblLogradouro;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox edtCodigoCliente;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnEditarItem;
        private System.Windows.Forms.Button btnRemoverItem;
        private System.Windows.Forms.Button btnConfirmarItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo_pedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn emissao;
        private System.Windows.Forms.DataGridViewTextBoxColumn peso_pedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn preco_pedido;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo_itenspedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo_pedido2;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo_produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao_produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn preco_unitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn peso_liquido;
        private System.Windows.Forms.DataGridViewTextBoxColumn preco_total;
        private System.Windows.Forms.DataGridViewTextBoxColumn peso_total;
    }
}