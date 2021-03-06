﻿namespace GUI
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.ribbon1 = new System.Windows.Forms.Ribbon();
            this.abaCadastros = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel1 = new System.Windows.Forms.RibbonPanel();
            this.btnCategoria = new System.Windows.Forms.RibbonButton();
            this.btnSubcategoria = new System.Windows.Forms.RibbonButton();
            this.btnUnidadeMedida = new System.Windows.Forms.RibbonButton();
            this.btnProdutos = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel2 = new System.Windows.Forms.RibbonPanel();
            this.btnClientes = new System.Windows.Forms.RibbonButton();
            this.btnFornecedores = new System.Windows.Forms.RibbonButton();
            this.abaConsultas = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel3 = new System.Windows.Forms.RibbonPanel();
            this.btnConsultaCategoria = new System.Windows.Forms.RibbonButton();
            this.btnConsultaSubCategoria = new System.Windows.Forms.RibbonButton();
            this.btnConsultaUnidadeMedida = new System.Windows.Forms.RibbonButton();
            this.abaMovimentacao = new System.Windows.Forms.RibbonTab();
            this.abaRelatorios = new System.Windows.Forms.RibbonTab();
            this.abaFerramentas = new System.Windows.Forms.RibbonTab();
            this.abaSobre = new System.Windows.Forms.RibbonTab();
            this.SuspendLayout();
            // 
            // ribbon1
            // 
            this.ribbon1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ribbon1.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.Minimized = false;
            this.ribbon1.Name = "ribbon1";
            // 
            // 
            // 
            this.ribbon1.OrbDropDown.BorderRoundness = 8;
            this.ribbon1.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.OrbDropDown.Name = "";
            this.ribbon1.OrbDropDown.Size = new System.Drawing.Size(527, 447);
            this.ribbon1.OrbDropDown.TabIndex = 0;
            this.ribbon1.RibbonTabFont = new System.Drawing.Font("Trebuchet MS", 9F);
            this.ribbon1.Size = new System.Drawing.Size(984, 173);
            this.ribbon1.TabIndex = 0;
            this.ribbon1.Tabs.Add(this.abaCadastros);
            this.ribbon1.Tabs.Add(this.abaConsultas);
            this.ribbon1.Tabs.Add(this.abaMovimentacao);
            this.ribbon1.Tabs.Add(this.abaRelatorios);
            this.ribbon1.Tabs.Add(this.abaFerramentas);
            this.ribbon1.Tabs.Add(this.abaSobre);
            this.ribbon1.Text = "ribbon1";
            // 
            // abaCadastros
            // 
            this.abaCadastros.Name = "abaCadastros";
            this.abaCadastros.Panels.Add(this.ribbonPanel1);
            this.abaCadastros.Panels.Add(this.ribbonPanel2);
            this.abaCadastros.Text = "Cadastros";
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.Items.Add(this.btnCategoria);
            this.ribbonPanel1.Items.Add(this.btnSubcategoria);
            this.ribbonPanel1.Items.Add(this.btnUnidadeMedida);
            this.ribbonPanel1.Items.Add(this.btnProdutos);
            this.ribbonPanel1.Name = "ribbonPanel1";
            this.ribbonPanel1.Text = "Cadastros";
            // 
            // btnCategoria
            // 
            this.btnCategoria.Image = ((System.Drawing.Image)(resources.GetObject("btnCategoria.Image")));
            this.btnCategoria.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCategoria.LargeImage")));
            this.btnCategoria.Name = "btnCategoria";
            this.btnCategoria.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnCategoria.SmallImage")));
            this.btnCategoria.Text = "Categorias";
            this.btnCategoria.Click += new System.EventHandler(this.btnCategoria_Click);
            // 
            // btnSubcategoria
            // 
            this.btnSubcategoria.Image = ((System.Drawing.Image)(resources.GetObject("btnSubcategoria.Image")));
            this.btnSubcategoria.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSubcategoria.LargeImage")));
            this.btnSubcategoria.Name = "btnSubcategoria";
            this.btnSubcategoria.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnSubcategoria.SmallImage")));
            this.btnSubcategoria.Text = "Sub-Categoria";
            this.btnSubcategoria.Click += new System.EventHandler(this.btnSubcategoria_Click);
            // 
            // btnUnidadeMedida
            // 
            this.btnUnidadeMedida.Image = ((System.Drawing.Image)(resources.GetObject("btnUnidadeMedida.Image")));
            this.btnUnidadeMedida.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnUnidadeMedida.LargeImage")));
            this.btnUnidadeMedida.Name = "btnUnidadeMedida";
            this.btnUnidadeMedida.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnUnidadeMedida.SmallImage")));
            this.btnUnidadeMedida.Text = "Unidade de Medida";
            this.btnUnidadeMedida.Click += new System.EventHandler(this.btnUnidadeMedida_Click);
            // 
            // btnProdutos
            // 
            this.btnProdutos.Image = ((System.Drawing.Image)(resources.GetObject("btnProdutos.Image")));
            this.btnProdutos.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnProdutos.LargeImage")));
            this.btnProdutos.Name = "btnProdutos";
            this.btnProdutos.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnProdutos.SmallImage")));
            this.btnProdutos.Text = "Produtos";
            // 
            // ribbonPanel2
            // 
            this.ribbonPanel2.Items.Add(this.btnClientes);
            this.ribbonPanel2.Items.Add(this.btnFornecedores);
            this.ribbonPanel2.Name = "ribbonPanel2";
            this.ribbonPanel2.Text = "Pessoas";
            // 
            // btnClientes
            // 
            this.btnClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnClientes.Image")));
            this.btnClientes.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnClientes.LargeImage")));
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnClientes.SmallImage")));
            this.btnClientes.Text = "Clientes";
            // 
            // btnFornecedores
            // 
            this.btnFornecedores.Image = ((System.Drawing.Image)(resources.GetObject("btnFornecedores.Image")));
            this.btnFornecedores.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnFornecedores.LargeImage")));
            this.btnFornecedores.Name = "btnFornecedores";
            this.btnFornecedores.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnFornecedores.SmallImage")));
            this.btnFornecedores.Text = "Fornecedores";
            // 
            // abaConsultas
            // 
            this.abaConsultas.Name = "abaConsultas";
            this.abaConsultas.Panels.Add(this.ribbonPanel3);
            this.abaConsultas.Text = "Consultas";
            // 
            // ribbonPanel3
            // 
            this.ribbonPanel3.Items.Add(this.btnConsultaCategoria);
            this.ribbonPanel3.Items.Add(this.btnConsultaSubCategoria);
            this.ribbonPanel3.Items.Add(this.btnConsultaUnidadeMedida);
            this.ribbonPanel3.Name = "ribbonPanel3";
            this.ribbonPanel3.Text = "Consultas";
            // 
            // btnConsultaCategoria
            // 
            this.btnConsultaCategoria.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultaCategoria.Image")));
            this.btnConsultaCategoria.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnConsultaCategoria.LargeImage")));
            this.btnConsultaCategoria.Name = "btnConsultaCategoria";
            this.btnConsultaCategoria.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnConsultaCategoria.SmallImage")));
            this.btnConsultaCategoria.Text = "Categoria";
            this.btnConsultaCategoria.TextAlignment = System.Windows.Forms.RibbonItem.RibbonItemTextAlignment.Center;
            this.btnConsultaCategoria.Click += new System.EventHandler(this.btnConsultaCategoria_Click);
            // 
            // btnConsultaSubCategoria
            // 
            this.btnConsultaSubCategoria.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultaSubCategoria.Image")));
            this.btnConsultaSubCategoria.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnConsultaSubCategoria.LargeImage")));
            this.btnConsultaSubCategoria.Name = "btnConsultaSubCategoria";
            this.btnConsultaSubCategoria.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnConsultaSubCategoria.SmallImage")));
            this.btnConsultaSubCategoria.Text = "Sub-Categoria";
            this.btnConsultaSubCategoria.Click += new System.EventHandler(this.btnConsultaSubCategoria_Click);
            // 
            // btnConsultaUnidadeMedida
            // 
            this.btnConsultaUnidadeMedida.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultaUnidadeMedida.Image")));
            this.btnConsultaUnidadeMedida.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnConsultaUnidadeMedida.LargeImage")));
            this.btnConsultaUnidadeMedida.Name = "btnConsultaUnidadeMedida";
            this.btnConsultaUnidadeMedida.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnConsultaUnidadeMedida.SmallImage")));
            this.btnConsultaUnidadeMedida.Text = "Unidade de Medida";
            this.btnConsultaUnidadeMedida.Click += new System.EventHandler(this.btnConsultaUnidadeMedida_Click);
            // 
            // abaMovimentacao
            // 
            this.abaMovimentacao.Name = "abaMovimentacao";
            this.abaMovimentacao.Text = "Movimentação";
            // 
            // abaRelatorios
            // 
            this.abaRelatorios.Name = "abaRelatorios";
            this.abaRelatorios.Text = "Relatórios";
            // 
            // abaFerramentas
            // 
            this.abaFerramentas.Name = "abaFerramentas";
            this.abaFerramentas.Text = "Ferramentas";
            // 
            // abaSobre
            // 
            this.abaSobre.Name = "abaSobre";
            this.abaSobre.Text = "Sobre";
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(984, 562);
            this.Controls.Add(this.ribbon1);
            this.KeyPreview = true;
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Controle de Estoque";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Ribbon ribbon1;
        private System.Windows.Forms.RibbonTab abaCadastros;
        private System.Windows.Forms.RibbonPanel ribbonPanel1;
        private System.Windows.Forms.RibbonButton btnCategoria;
        private System.Windows.Forms.RibbonTab abaConsultas;
        private System.Windows.Forms.RibbonTab abaMovimentacao;
        private System.Windows.Forms.RibbonTab abaRelatorios;
        private System.Windows.Forms.RibbonTab abaFerramentas;
        private System.Windows.Forms.RibbonTab abaSobre;
        private System.Windows.Forms.RibbonButton btnSubcategoria;
        private System.Windows.Forms.RibbonButton btnUnidadeMedida;
        private System.Windows.Forms.RibbonButton btnProdutos;
        private System.Windows.Forms.RibbonPanel ribbonPanel2;
        private System.Windows.Forms.RibbonButton btnClientes;
        private System.Windows.Forms.RibbonButton btnFornecedores;
        private System.Windows.Forms.RibbonPanel ribbonPanel3;
        private System.Windows.Forms.RibbonButton btnConsultaCategoria;
        private System.Windows.Forms.RibbonButton btnConsultaSubCategoria;
        private System.Windows.Forms.RibbonButton btnConsultaUnidadeMedida;
    }
}

