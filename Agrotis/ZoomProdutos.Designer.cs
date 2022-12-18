namespace Agrotis
{
    partial class ZoomProdutos
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
            this.dataGridViewResult = new System.Windows.Forms.DataGridView();
            this.codigo_produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peso_liquido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preco_unitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edtFiltro = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewResult
            // 
            this.dataGridViewResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo_produto,
            this.Descricao,
            this.peso_liquido,
            this.preco_unitario});
            this.dataGridViewResult.Location = new System.Drawing.Point(12, 51);
            this.dataGridViewResult.Name = "dataGridViewResult";
            this.dataGridViewResult.Size = new System.Drawing.Size(728, 316);
            this.dataGridViewResult.TabIndex = 0;
            this.dataGridViewResult.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewResult_CellContentClick);
            // 
            // codigo_produto
            // 
            this.codigo_produto.DataPropertyName = "codigo_produto";
            this.codigo_produto.HeaderText = "Produto";
            this.codigo_produto.Name = "codigo_produto";
            // 
            // Descricao
            // 
            this.Descricao.DataPropertyName = "descricao";
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.Name = "Descricao";
            this.Descricao.Width = 350;
            // 
            // peso_liquido
            // 
            this.peso_liquido.DataPropertyName = "peso_liquido";
            this.peso_liquido.HeaderText = "Peso Líquido";
            this.peso_liquido.Name = "peso_liquido";
            // 
            // preco_unitario
            // 
            this.preco_unitario.DataPropertyName = "preco_unitario";
            this.preco_unitario.HeaderText = "Preço Unitário";
            this.preco_unitario.Name = "preco_unitario";
            // 
            // edtFiltro
            // 
            this.edtFiltro.Location = new System.Drawing.Point(12, 25);
            this.edtFiltro.Name = "edtFiltro";
            this.edtFiltro.Size = new System.Drawing.Size(627, 20);
            this.edtFiltro.TabIndex = 1;
            this.edtFiltro.TextChanged += new System.EventHandler(this.edtFiltro_TextChanged);
            // 
            // btnOK
            // 
            this.btnOK.Image = global::Agrotis.Properties.Resources.marca_de_verificacao__1_;
            this.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOK.Location = new System.Drawing.Point(645, 11);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(95, 36);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "      Selecionar";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Digite a descrição do produto:";
            // 
            // ZoomProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 380);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.edtFiltro);
            this.Controls.Add(this.dataGridViewResult);
            this.Name = "ZoomProdutos";
            this.Text = "Busca Produtos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewResult;
        private System.Windows.Forms.TextBox edtFiltro;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo_produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn peso_liquido;
        private System.Windows.Forms.DataGridViewTextBoxColumn preco_unitario;
    }
}