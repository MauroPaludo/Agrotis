namespace Agrotis
{
    partial class CadastroProduto
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridViewProdutos = new System.Windows.Forms.DataGridView();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.edtCodigo = new System.Windows.Forms.TextBox();
            this.lblPrecoUnitario = new System.Windows.Forms.Label();
            this.edtPrecoUnitario = new System.Windows.Forms.TextBox();
            this.lblPesoLiquido = new System.Windows.Forms.Label();
            this.edtPesoLiquido = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.edtDescricao = new System.Windows.Forms.TextBox();
            this.codigo_produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peso_liquido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preco_unitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(460, 387);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.btnEditar);
            this.tabPage1.Controls.Add(this.btnExcluir);
            this.tabPage1.Controls.Add(this.btnFechar);
            this.tabPage1.Controls.Add(this.dataGridViewProdutos);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(452, 361);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Produtos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.lblCodigo);
            this.tabPage2.Controls.Add(this.edtCodigo);
            this.tabPage2.Controls.Add(this.lblPrecoUnitario);
            this.tabPage2.Controls.Add(this.edtPrecoUnitario);
            this.tabPage2.Controls.Add(this.lblPesoLiquido);
            this.tabPage2.Controls.Add(this.edtPesoLiquido);
            this.tabPage2.Controls.Add(this.lblDescricao);
            this.tabPage2.Controls.Add(this.edtDescricao);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(452, 361);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Editar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewProdutos
            // 
            this.dataGridViewProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo_produto,
            this.descricao,
            this.peso_liquido,
            this.preco_unitario});
            this.dataGridViewProdutos.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewProdutos.Name = "dataGridViewProdutos";
            this.dataGridViewProdutos.Size = new System.Drawing.Size(446, 305);
            this.dataGridViewProdutos.TabIndex = 4;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(12, 31);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(98, 13);
            this.lblCodigo.TabIndex = 18;
            this.lblCodigo.Text = "Código do Produto:";
            // 
            // edtCodigo
            // 
            this.edtCodigo.Enabled = false;
            this.edtCodigo.Location = new System.Drawing.Point(116, 28);
            this.edtCodigo.Name = "edtCodigo";
            this.edtCodigo.Size = new System.Drawing.Size(86, 20);
            this.edtCodigo.TabIndex = 17;
            // 
            // lblPrecoUnitario
            // 
            this.lblPrecoUnitario.AutoSize = true;
            this.lblPrecoUnitario.Location = new System.Drawing.Point(33, 109);
            this.lblPrecoUnitario.Name = "lblPrecoUnitario";
            this.lblPrecoUnitario.Size = new System.Drawing.Size(77, 13);
            this.lblPrecoUnitario.TabIndex = 16;
            this.lblPrecoUnitario.Text = "Preço Unitário:";
            // 
            // edtPrecoUnitario
            // 
            this.edtPrecoUnitario.Location = new System.Drawing.Point(116, 106);
            this.edtPrecoUnitario.Name = "edtPrecoUnitario";
            this.edtPrecoUnitario.Size = new System.Drawing.Size(86, 20);
            this.edtPrecoUnitario.TabIndex = 15;
            // 
            // lblPesoLiquido
            // 
            this.lblPesoLiquido.AutoSize = true;
            this.lblPesoLiquido.Location = new System.Drawing.Point(39, 83);
            this.lblPesoLiquido.Name = "lblPesoLiquido";
            this.lblPesoLiquido.Size = new System.Drawing.Size(71, 13);
            this.lblPesoLiquido.TabIndex = 14;
            this.lblPesoLiquido.Text = "Peso Liquido:";
            // 
            // edtPesoLiquido
            // 
            this.edtPesoLiquido.Location = new System.Drawing.Point(116, 80);
            this.edtPesoLiquido.Name = "edtPesoLiquido";
            this.edtPesoLiquido.Size = new System.Drawing.Size(86, 20);
            this.edtPesoLiquido.TabIndex = 13;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(52, 57);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(58, 13);
            this.lblDescricao.TabIndex = 12;
            this.lblDescricao.Text = "Descrição:";
            // 
            // edtDescricao
            // 
            this.edtDescricao.Location = new System.Drawing.Point(116, 54);
            this.edtDescricao.Name = "edtDescricao";
            this.edtDescricao.Size = new System.Drawing.Size(292, 20);
            this.edtDescricao.TabIndex = 11;
            // 
            // codigo_produto
            // 
            this.codigo_produto.DataPropertyName = "codigo_produto";
            this.codigo_produto.HeaderText = "Produto";
            this.codigo_produto.Name = "codigo_produto";
            // 
            // descricao
            // 
            this.descricao.DataPropertyName = "descricao";
            this.descricao.HeaderText = "Descrição";
            this.descricao.Name = "descricao";
            // 
            // peso_liquido
            // 
            this.peso_liquido.DataPropertyName = "peso_liquido";
            this.peso_liquido.HeaderText = "Peso UN";
            this.peso_liquido.Name = "peso_liquido";
            // 
            // preco_unitario
            // 
            this.preco_unitario.DataPropertyName = "preco_unitario";
            this.preco_unitario.HeaderText = "Preço UN";
            this.preco_unitario.Name = "preco_unitario";
            // 
            // button3
            // 
            this.button3.Image = global::Agrotis.Properties.Resources.adicionar_aplicativos__2___1_;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(357, 314);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 37);
            this.button3.TabIndex = 15;
            this.button3.Text = "    Novo";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Image = global::Agrotis.Properties.Resources.botao_editar__2_1;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(184, 314);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(82, 37);
            this.btnEditar.TabIndex = 14;
            this.btnEditar.Text = "    Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Image = global::Agrotis.Properties.Resources.excluir_aplicativos__1___1_;
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.Location = new System.Drawing.Point(266, 314);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(91, 37);
            this.btnExcluir.TabIndex = 13;
            this.btnExcluir.Text = "    Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Image = global::Agrotis.Properties.Resources.cruz__1___1_;
            this.btnFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFechar.Location = new System.Drawing.Point(92, 314);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(93, 37);
            this.btnFechar.TabIndex = 12;
            this.btnFechar.Text = "    Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // button2
            // 
            this.button2.Image = global::Agrotis.Properties.Resources.cruz__1___1_;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(347, 311);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 34);
            this.button2.TabIndex = 53;
            this.button2.Text = "    Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Image = global::Agrotis.Properties.Resources.opcao_de_salvar_arquivo__1_;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(251, 311);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 34);
            this.button1.TabIndex = 52;
            this.button1.Text = "    Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 405);
            this.Controls.Add(this.tabControl1);
            this.Name = "CadastroProduto";
            this.Text = "Produtos";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridViewProdutos;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox edtCodigo;
        private System.Windows.Forms.Label lblPrecoUnitario;
        private System.Windows.Forms.TextBox edtPrecoUnitario;
        private System.Windows.Forms.Label lblPesoLiquido;
        private System.Windows.Forms.TextBox edtPesoLiquido;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox edtDescricao;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo_produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn peso_liquido;
        private System.Windows.Forms.DataGridViewTextBoxColumn preco_unitario;
    }
}