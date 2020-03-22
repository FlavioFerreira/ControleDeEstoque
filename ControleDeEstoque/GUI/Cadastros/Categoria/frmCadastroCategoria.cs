using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Modelo;
using DAL;
using BLL;

namespace GUI.Cadastros.Categoria
{
    public partial class frmCadastroCategoria : GUI.Cadastros.Templates.frmModeloCadastro
    {
        public frmCadastroCategoria()
        {
            InitializeComponent();
        }

        public void LimpaTela()
        {
            txtCodigo.Clear();
            txtNome.Clear();
        }

        private void frmCadastroCategoria_Load(object sender, EventArgs e)
        {
            this.alteraBotoes(1);


        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.alteraBotoes(2);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.LimpaTela();
            this.alteraBotoes(1);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                ModeloCategoria modelo = new ModeloCategoria();
                modelo.Cat_nome = txtNome.Text;
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCategoria bll = new BLLCategoria(cx);

                if (this.operacao == "inserir")
                {
                    bll.Incluir(modelo);
                    MessageBox.Show("Cadastro Realizado. Código: " + modelo.Cat_cod.ToString());
                }
                else
                {
                    modelo.Cat_cod = Convert.ToInt32(txtCodigo.Text);
                    bll.Alterar(modelo);
                    MessageBox.Show("Cadastro Alterado.");
                }
                this.LimpaTela();
                this.alteraBotoes(1);
            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
    }
}
