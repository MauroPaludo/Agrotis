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
using RestSharp;
using RestSharp.Serializers;
using System.Text.RegularExpressions;
using System.Net;
using System.IO;

namespace Agrotis
{
    public partial class CadastroCliente : Form
    {
        public Decimal codigo = 0;
        public String estado = "";

        public CadastroCliente()
        {
            InitializeComponent();
            CarregaDados();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
           

        }

        private bool ValidaDados()
        {
            if (edtNome.Text == "")
            {
                MessageBox.Show("É necessário informar um nome !!!");
                return false;
            }
            if(maskedCEP.Text == "")
            {
                MessageBox.Show("É necessário informar um CEP !!!");
                return false;
            }
            if (edtLogradouro.Text == "")
            {
                MessageBox.Show("É necessário informar um Logradouro !!!");
                return false;
            }
            if (edtComplemento.Text == "")
            {
                MessageBox.Show("É necessário informar um Complemento !!!");
                return false;
            }
            if (edtBairro.Text == "")
            {
                MessageBox.Show("É necessário informar um Bairro !!!");
                return false;
            }
            if (edtCidade.Text == "")
            {
                MessageBox.Show("É necessário informar uma Cidade !!!");
                return false;
            }
            if (edtUF.Text == "")
            {
                MessageBox.Show("É necessário informar uma UF !!!");
                return false;
            }
            return true;
        }

        private void CarregaDados()
        {
            using (var context = new Contexto())
            {
                dataGridViewClientes.DataSource = context.Cliente.ToList();             
            }             
        }

        private void maskefCEP_Leave(object sender, EventArgs e)
        {
           
        }

        private void CadastroCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnAdicionar_Click_1(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            using (var context = new Contexto())
            {
                if (dataGridViewClientes.SelectedRows.Count > 0)
                {
                    List<DataGridViewRow> rows_with_checked_column = new List<DataGridViewRow>();
                    foreach (DataGridViewRow row in dataGridViewClientes.SelectedRows)
                    {
                        int cod = Convert.ToInt32(row.Cells[codigo_cliente.DataPropertyName].Value.ToString());
                        tabControl1.SelectedTab = tabControl1.TabPages[1];
                        codigo = cod;
                        estado = "editar";
                    }
                }
                else
                {
                    MessageBox.Show("Selecione um Cadastro !!!");
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
                    Cliente c = context.Cliente.Where(s => s.codigo_cliente == codigo).FirstOrDefault();
                    edtNome.Text = c.nome;
                    maskedCEP.Text = c.cep;
                    edtCidade.Text = c.cidade;
                    edtLogradouro.Text = c.logradouro;
                    edtBairro.Text = c.bairro;
                    edtComplemento.Text = c.complemento;
                    edtCodigoIBGE.Text = c.codigo_ibge;
                    edtUF.Text = c.uf;
                    edtCodigo.Text = c.codigo_cliente.ToString();
                }
   
            }
        }

        private void maskedCEP_Leave(object sender, EventArgs e)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://viacep.com.br/ws/" + maskedCEP.Text + "/json/");
                request.AllowAutoRedirect = false;
                HttpWebResponse ChecaServidor = (HttpWebResponse)request.GetResponse();


                if (ChecaServidor.StatusCode != HttpStatusCode.OK)
                {
                    MessageBox.Show("Servidor indisponível");
                    return;
                }

                using (Stream webStream = ChecaServidor.GetResponseStream())
                {
                    if (webStream != null)
                    {
                        using (StreamReader responseReader = new StreamReader(webStream))
                        {
                            string response = responseReader.ReadToEnd();
                            response = Regex.Replace(response, "[{},]", string.Empty);
                            response = response.Replace("\"", "");

                            String[] substrings = response.Split('\n');

                            int cont = 0;
                            foreach (var substring in substrings)
                            {
                                if (cont == 1)
                                {
                                    string[] valor = substring.Split(":".ToCharArray());
                                    if (valor[0] == "  erro")
                                    {
                                        MessageBox.Show("CEP não encontrado");
                                        maskedCEP.Focus();
                                        return;
                                    }
                                }

                                if (cont == 2)
                                {
                                    string[] valor = substring.Split(":".ToCharArray());
                                    edtLogradouro.Text = valor[1];
                                }

                                if (cont == 3)
                                {
                                    string[] valor = substring.Split(":".ToCharArray());
                                    edtComplemento.Text = valor[1];
                                }

                                if (cont == 4)
                                {
                                    string[] valor = substring.Split(":".ToCharArray());
                                    edtBairro.Text = valor[1];
                                }

                                if (cont == 5)
                                {
                                    string[] valor = substring.Split(":".ToCharArray());
                                    edtCidade.Text = valor[1];
                                }

                                if (cont == 6)
                                {
                                    string[] valor = substring.Split(":".ToCharArray());
                                    edtUF.Text = valor[1];
                                }

                                if (cont == 7)
                                {
                                    string[] valor = substring.Split(":".ToCharArray());
                                    edtCodigoIBGE.Text = valor[1];
                                }
                                cont++;
                            }
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("CEP Incorreto !!! ");
                maskedCEP.Text = "";
                maskedCEP.Focus();
                return;
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
                        context.Cliente.Add(new Cliente
                        {
                            nome = edtNome.Text,
                            cep = maskedCEP.Text,
                            logradouro = edtLogradouro.Text,
                            complemento = edtComplemento.Text,
                            bairro = edtBairro.Text,
                            cidade = edtCidade.Text,
                            uf = edtUF.Text,
                            codigo_ibge = edtCodigoIBGE.Text
                        });
                        context.SaveChanges();
                        tabControl1.SelectedTab = tabControl1.TabPages[0];
                        CarregaDados();
                        LimpaCampos();
                    }
                    else
                    {
                        Cliente c = context.Cliente.Where(s => s.codigo_cliente == codigo).FirstOrDefault();
                        c.nome = edtNome.Text;
                        c.cep = maskedCEP.Text;
                        c.cidade = edtCidade.Text;
                        c.logradouro = edtLogradouro.Text;
                        c.bairro = edtBairro.Text;
                        c.complemento = edtComplemento.Text;
                        c.codigo_ibge = edtCodigoIBGE.Text;
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

        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages[1];
            LimpaCampos();
            estado = "novo";
        }


        private void LimpaCampos()
        {
            edtBairro.Text = "";
            edtCidade.Text = "";
            edtCodigoIBGE.Text = "";
            edtComplemento.Text = "";
            edtLogradouro.Text = "";
            edtNome.Text = "";
            edtUF.Text = "";
            maskedCEP.Text = "";
        }
        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            using (var context = new Contexto())
            {
                if (dataGridViewClientes.SelectedRows.Count > 0)
                {
                    List<DataGridViewRow> rows_with_checked_column = new List<DataGridViewRow>();
                    foreach (DataGridViewRow row in dataGridViewClientes.SelectedRows)
                    {
                        int cod = Convert.ToInt32(row.Cells[codigo_cliente.DataPropertyName].Value.ToString());
                        Cliente c = context.Cliente.Where(s => s.codigo_cliente == cod).FirstOrDefault();
                        context.Cliente.Remove(c);
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
    }
}
