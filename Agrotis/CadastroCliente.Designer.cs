namespace Agrotis
{
    partial class CadastroCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroCliente));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridViewClientes = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.maskedCEP = new System.Windows.Forms.MaskedTextBox();
            this.lblCodigoIbge = new System.Windows.Forms.Label();
            this.edtCodigoIBGE = new System.Windows.Forms.TextBox();
            this.lblUF = new System.Windows.Forms.Label();
            this.edtUF = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.edtCidade = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.edtBairro = new System.Windows.Forms.TextBox();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.edtComplemento = new System.Windows.Forms.TextBox();
            this.lblLogradouro = new System.Windows.Forms.Label();
            this.edtLogradouro = new System.Windows.Forms.TextBox();
            this.lblCep = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.edtNome = new System.Windows.Forms.TextBox();
            this.codigo_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo_ibge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.complemento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logradouro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.edtCodigo = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 7);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(808, 336);
            this.tabControl1.TabIndex = 33;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.btnEditar);
            this.tabPage1.Controls.Add(this.btnExcluir);
            this.tabPage1.Controls.Add(this.btnFechar);
            this.tabPage1.Controls.Add(this.dataGridViewClientes);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(800, 310);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Clientes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewClientes
            // 
            this.dataGridViewClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo_cliente,
            this.colNome,
            this.bairro,
            this.cidade,
            this.uf,
            this.codigo_ibge,
            this.cep,
            this.complemento,
            this.logradouro});
            this.dataGridViewClientes.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewClientes.Name = "dataGridViewClientes";
            this.dataGridViewClientes.Size = new System.Drawing.Size(788, 255);
            this.dataGridViewClientes.TabIndex = 4;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.edtCodigo);
            this.tabPage2.Controls.Add(this.maskedCEP);
            this.tabPage2.Controls.Add(this.lblCodigoIbge);
            this.tabPage2.Controls.Add(this.edtCodigoIBGE);
            this.tabPage2.Controls.Add(this.lblUF);
            this.tabPage2.Controls.Add(this.edtUF);
            this.tabPage2.Controls.Add(this.lblCidade);
            this.tabPage2.Controls.Add(this.edtCidade);
            this.tabPage2.Controls.Add(this.lblBairro);
            this.tabPage2.Controls.Add(this.edtBairro);
            this.tabPage2.Controls.Add(this.lblComplemento);
            this.tabPage2.Controls.Add(this.edtComplemento);
            this.tabPage2.Controls.Add(this.lblLogradouro);
            this.tabPage2.Controls.Add(this.edtLogradouro);
            this.tabPage2.Controls.Add(this.lblCep);
            this.tabPage2.Controls.Add(this.lblNome);
            this.tabPage2.Controls.Add(this.edtNome);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(800, 310);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Editar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // maskedCEP
            // 
            this.maskedCEP.Location = new System.Drawing.Point(94, 58);
            this.maskedCEP.Name = "maskedCEP";
            this.maskedCEP.Size = new System.Drawing.Size(67, 20);
            this.maskedCEP.TabIndex = 3;
            this.maskedCEP.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.maskedCEP.Leave += new System.EventHandler(this.maskedCEP_Leave);
            // 
            // lblCodigoIbge
            // 
            this.lblCodigoIbge.AutoSize = true;
            this.lblCodigoIbge.Location = new System.Drawing.Point(22, 191);
            this.lblCodigoIbge.Name = "lblCodigoIbge";
            this.lblCodigoIbge.Size = new System.Drawing.Size(71, 13);
            this.lblCodigoIbge.TabIndex = 48;
            this.lblCodigoIbge.Text = "Código IBGE:";
            // 
            // edtCodigoIBGE
            // 
            this.edtCodigoIBGE.Enabled = false;
            this.edtCodigoIBGE.Location = new System.Drawing.Point(94, 188);
            this.edtCodigoIBGE.Name = "edtCodigoIBGE";
            this.edtCodigoIBGE.Size = new System.Drawing.Size(246, 20);
            this.edtCodigoIBGE.TabIndex = 9;
            // 
            // lblUF
            // 
            this.lblUF.AutoSize = true;
            this.lblUF.Location = new System.Drawing.Point(349, 165);
            this.lblUF.Name = "lblUF";
            this.lblUF.Size = new System.Drawing.Size(24, 13);
            this.lblUF.TabIndex = 46;
            this.lblUF.Text = "UF:";
            // 
            // edtUF
            // 
            this.edtUF.Enabled = false;
            this.edtUF.Location = new System.Drawing.Point(380, 162);
            this.edtUF.Name = "edtUF";
            this.edtUF.Size = new System.Drawing.Size(78, 20);
            this.edtUF.TabIndex = 8;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(45, 165);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(43, 13);
            this.lblCidade.TabIndex = 44;
            this.lblCidade.Text = "Cidade:";
            // 
            // edtCidade
            // 
            this.edtCidade.Enabled = false;
            this.edtCidade.Location = new System.Drawing.Point(94, 162);
            this.edtCidade.Name = "edtCidade";
            this.edtCidade.Size = new System.Drawing.Size(246, 20);
            this.edtCidade.TabIndex = 7;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(54, 139);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(37, 13);
            this.lblBairro.TabIndex = 42;
            this.lblBairro.Text = "Bairro:";
            // 
            // edtBairro
            // 
            this.edtBairro.Location = new System.Drawing.Point(94, 136);
            this.edtBairro.Name = "edtBairro";
            this.edtBairro.Size = new System.Drawing.Size(364, 20);
            this.edtBairro.TabIndex = 6;
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Location = new System.Drawing.Point(15, 113);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(74, 13);
            this.lblComplemento.TabIndex = 40;
            this.lblComplemento.Text = "Complemento:";
            // 
            // edtComplemento
            // 
            this.edtComplemento.Location = new System.Drawing.Point(94, 110);
            this.edtComplemento.Name = "edtComplemento";
            this.edtComplemento.Size = new System.Drawing.Size(364, 20);
            this.edtComplemento.TabIndex = 5;
            // 
            // lblLogradouro
            // 
            this.lblLogradouro.AutoSize = true;
            this.lblLogradouro.Location = new System.Drawing.Point(25, 87);
            this.lblLogradouro.Name = "lblLogradouro";
            this.lblLogradouro.Size = new System.Drawing.Size(64, 13);
            this.lblLogradouro.TabIndex = 38;
            this.lblLogradouro.Text = "Logradouro:";
            // 
            // edtLogradouro
            // 
            this.edtLogradouro.Location = new System.Drawing.Point(94, 84);
            this.edtLogradouro.Name = "edtLogradouro";
            this.edtLogradouro.Size = new System.Drawing.Size(364, 20);
            this.edtLogradouro.TabIndex = 4;
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Location = new System.Drawing.Point(58, 61);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(31, 13);
            this.lblCep.TabIndex = 36;
            this.lblCep.Text = "CEP:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(53, 38);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 35;
            this.lblNome.Text = "Nome:";
            // 
            // edtNome
            // 
            this.edtNome.Location = new System.Drawing.Point(94, 32);
            this.edtNome.Name = "edtNome";
            this.edtNome.Size = new System.Drawing.Size(279, 20);
            this.edtNome.TabIndex = 2;
            // 
            // codigo_cliente
            // 
            this.codigo_cliente.DataPropertyName = "codigo_cliente";
            this.codigo_cliente.HeaderText = "Cliente";
            this.codigo_cliente.Name = "codigo_cliente";
            // 
            // colNome
            // 
            this.colNome.DataPropertyName = "nome";
            this.colNome.HeaderText = "Nome";
            this.colNome.Name = "colNome";
            // 
            // bairro
            // 
            this.bairro.DataPropertyName = "bairro";
            this.bairro.HeaderText = "Bairro";
            this.bairro.Name = "bairro";
            // 
            // cidade
            // 
            this.cidade.DataPropertyName = "cidade";
            this.cidade.HeaderText = "Cidade";
            this.cidade.Name = "cidade";
            // 
            // uf
            // 
            this.uf.DataPropertyName = "uf";
            this.uf.HeaderText = "UF";
            this.uf.Name = "uf";
            // 
            // codigo_ibge
            // 
            this.codigo_ibge.DataPropertyName = "codigo_ibge";
            this.codigo_ibge.HeaderText = "Código IBGE";
            this.codigo_ibge.Name = "codigo_ibge";
            // 
            // cep
            // 
            this.cep.DataPropertyName = "cep";
            this.cep.HeaderText = "CEP";
            this.cep.Name = "cep";
            // 
            // complemento
            // 
            this.complemento.DataPropertyName = "complemento";
            this.complemento.HeaderText = "Complemento";
            this.complemento.Name = "complemento";
            // 
            // logradouro
            // 
            this.logradouro.DataPropertyName = "logradouro";
            this.logradouro.HeaderText = "Logradouro";
            this.logradouro.Name = "logradouro";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 53;
            this.label1.Text = "Código:";
            // 
            // edtCodigo
            // 
            this.edtCodigo.Enabled = false;
            this.edtCodigo.Location = new System.Drawing.Point(94, 6);
            this.edtCodigo.Name = "edtCodigo";
            this.edtCodigo.Size = new System.Drawing.Size(279, 20);
            this.edtCodigo.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(701, 269);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 37);
            this.button3.TabIndex = 11;
            this.button3.Text = "     Novo";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(508, 270);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(98, 37);
            this.btnEditar.TabIndex = 10;
            this.btnEditar.Text = "     Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.Location = new System.Drawing.Point(606, 269);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(95, 37);
            this.btnExcluir.TabIndex = 9;
            this.btnExcluir.Text = "     Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFechar.Location = new System.Drawing.Point(407, 270);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(101, 37);
            this.btnFechar.TabIndex = 8;
            this.btnFechar.Text = "      Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // button2
            // 
            this.button2.Image = global::Agrotis.Properties.Resources.cruz__1___1_;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(353, 265);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 39);
            this.button2.TabIndex = 51;
            this.button2.Text = "    Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Image = global::Agrotis.Properties.Resources.opcao_de_salvar_arquivo__1_;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(245, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 39);
            this.button1.TabIndex = 50;
            this.button1.Text = "    Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 355);
            this.Controls.Add(this.tabControl1);
            this.Name = "CadastroCliente";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.CadastroCliente_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridViewClientes;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.MaskedTextBox maskedCEP;
        private System.Windows.Forms.Label lblCodigoIbge;
        private System.Windows.Forms.TextBox edtCodigoIBGE;
        private System.Windows.Forms.Label lblUF;
        private System.Windows.Forms.TextBox edtUF;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.TextBox edtCidade;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox edtBairro;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.TextBox edtComplemento;
        private System.Windows.Forms.Label lblLogradouro;
        private System.Windows.Forms.TextBox edtLogradouro;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox edtNome;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn bairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn uf;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo_ibge;
        private System.Windows.Forms.DataGridViewTextBoxColumn cep;
        private System.Windows.Forms.DataGridViewTextBoxColumn complemento;
        private System.Windows.Forms.DataGridViewTextBoxColumn logradouro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox edtCodigo;
    }
}