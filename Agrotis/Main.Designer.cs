namespace Agrotis
{
    partial class Main
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btnCadastroClientes = new System.Windows.Forms.Button();
            this.btnCadastroProdutos = new System.Windows.Forms.Button();
            this.btnCadastroPedidos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCadastroClientes
            // 
            this.btnCadastroClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastroClientes.Image")));
            this.btnCadastroClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastroClientes.Location = new System.Drawing.Point(12, 21);
            this.btnCadastroClientes.Name = "btnCadastroClientes";
            this.btnCadastroClientes.Size = new System.Drawing.Size(147, 50);
            this.btnCadastroClientes.TabIndex = 1;
            this.btnCadastroClientes.Text = "Clientes";
            this.btnCadastroClientes.UseVisualStyleBackColor = true;
            this.btnCadastroClientes.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnCadastroProdutos
            // 
            this.btnCadastroProdutos.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastroProdutos.Image")));
            this.btnCadastroProdutos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastroProdutos.Location = new System.Drawing.Point(210, 21);
            this.btnCadastroProdutos.Name = "btnCadastroProdutos";
            this.btnCadastroProdutos.Size = new System.Drawing.Size(142, 51);
            this.btnCadastroProdutos.TabIndex = 2;
            this.btnCadastroProdutos.Text = "Produtos";
            this.btnCadastroProdutos.UseVisualStyleBackColor = true;
            this.btnCadastroProdutos.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCadastroPedidos
            // 
            this.btnCadastroPedidos.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastroPedidos.Image")));
            this.btnCadastroPedidos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastroPedidos.Location = new System.Drawing.Point(396, 22);
            this.btnCadastroPedidos.Name = "btnCadastroPedidos";
            this.btnCadastroPedidos.Size = new System.Drawing.Size(137, 50);
            this.btnCadastroPedidos.TabIndex = 3;
            this.btnCadastroPedidos.Text = "Pedidos";
            this.btnCadastroPedidos.UseVisualStyleBackColor = true;
            this.btnCadastroPedidos.Click += new System.EventHandler(this.btnCadastroPedidos_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 89);
            this.Controls.Add(this.btnCadastroPedidos);
            this.Controls.Add(this.btnCadastroProdutos);
            this.Controls.Add(this.btnCadastroClientes);
            this.Name = "Main";
            this.Text = "Controle de Vendas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadastroClientes;
        private System.Windows.Forms.Button btnCadastroProdutos;
        private System.Windows.Forms.Button btnCadastroPedidos;
    }
}

