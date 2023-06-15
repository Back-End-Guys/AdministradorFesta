namespace GerenciadorDeFestas.WinForms
{
    partial class TelaPrincipalForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuBar = new MenuStrip();
            cadastrosToolStripMenuItem = new ToolStripMenuItem();
            clientesMenuItem = new ToolStripMenuItem();
            TemasMenu = new ToolStripMenuItem();
            ItensMenuItem = new ToolStripMenuItem();
            TemasMenuItem = new ToolStripMenuItem();
            aluguelMenuItem = new ToolStripMenuItem();
            toolBar = new ToolStrip();
            btnInserir = new ToolStripButton();
            btnEditar = new ToolStripButton();
            btnExcluir = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnListaAlugueis = new ToolStripButton();
            btnPagamento = new ToolStripButton();
            btnEndereco = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            labelTipoCadastro = new ToolStripLabel();
            panelRegistros = new Panel();
            statusStrip1 = new StatusStrip();
            labelRodape = new ToolStripStatusLabel();
            menuBar.SuspendLayout();
            toolBar.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuBar
            // 
            menuBar.BackColor = Color.FromArgb(230, 235, 239);
            menuBar.ImageScalingSize = new Size(20, 20);
            menuBar.Items.AddRange(new ToolStripItem[] { cadastrosToolStripMenuItem });
            menuBar.Location = new Point(0, 0);
            menuBar.Name = "menuBar";
            menuBar.Size = new Size(906, 40);
            menuBar.TabIndex = 0;
            menuBar.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clientesMenuItem, TemasMenu, aluguelMenuItem });
            cadastrosToolStripMenuItem.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cadastrosToolStripMenuItem.Image = Properties.Resources.cadastroIcon;
            cadastrosToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            cadastrosToolStripMenuItem.Margin = new Padding(15, 0, 0, 0);
            cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            cadastrosToolStripMenuItem.Size = new Size(123, 36);
            cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // clientesMenuItem
            // 
            clientesMenuItem.Image = Properties.Resources.clientesIcon;
            clientesMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            clientesMenuItem.Name = "clientesMenuItem";
            clientesMenuItem.Size = new Size(149, 38);
            clientesMenuItem.Text = "Cliente";
            clientesMenuItem.Click += clientesMenuItem_Click;
            // 
            // TemasMenu
            // 
            TemasMenu.DropDownItems.AddRange(new ToolStripItem[] { ItensMenuItem, TemasMenuItem });
            TemasMenu.Image = Properties.Resources.tema1Icon;
            TemasMenu.ImageScaling = ToolStripItemImageScaling.None;
            TemasMenu.Name = "TemasMenu";
            TemasMenu.Size = new Size(149, 38);
            TemasMenu.Text = "Temas";
            // 
            // ItensMenuItem
            // 
            ItensMenuItem.Image = Properties.Resources.itemIcon;
            ItensMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            ItensMenuItem.Name = "ItensMenuItem";
            ItensMenuItem.Size = new Size(139, 38);
            ItensMenuItem.Text = "Itens";
            ItensMenuItem.Click += ItensMenuItem_Click;
            // 
            // TemasMenuItem
            // 
            TemasMenuItem.Image = Properties.Resources.tema2Icon;
            TemasMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            TemasMenuItem.Name = "TemasMenuItem";
            TemasMenuItem.Size = new Size(139, 38);
            TemasMenuItem.Text = "Temas";
            TemasMenuItem.Click += TemasMenuItem_Click;
            // 
            // aluguelMenuItem
            // 
            aluguelMenuItem.Image = Properties.Resources.aluguelIcon;
            aluguelMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            aluguelMenuItem.Name = "aluguelMenuItem";
            aluguelMenuItem.Size = new Size(149, 38);
            aluguelMenuItem.Text = "Aluguel";
            aluguelMenuItem.Click += aluguelMenuItem_Click;
            // 
            // toolBar
            // 
            toolBar.BackColor = Color.FromArgb(230, 235, 239);
            toolBar.Enabled = false;
            toolBar.GripStyle = ToolStripGripStyle.Hidden;
            toolBar.ImageScalingSize = new Size(20, 20);
            toolBar.Items.AddRange(new ToolStripItem[] { btnInserir, btnEditar, btnExcluir, toolStripSeparator1, btnListaAlugueis, btnPagamento, btnEndereco, toolStripSeparator2, labelTipoCadastro });
            toolBar.Location = new Point(0, 40);
            toolBar.Name = "toolBar";
            toolBar.RenderMode = ToolStripRenderMode.System;
            toolBar.Size = new Size(906, 53);
            toolBar.TabIndex = 2;
            toolBar.Text = "toolStrip1";
            // 
            // btnInserir
            // 
            btnInserir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnInserir.Image = Properties.Resources.adicionarIcon;
            btnInserir.ImageScaling = ToolStripItemImageScaling.None;
            btnInserir.ImageTransparentColor = Color.Magenta;
            btnInserir.Margin = new Padding(15, 1, 0, 2);
            btnInserir.Name = "btnInserir";
            btnInserir.Padding = new Padding(7);
            btnInserir.Size = new Size(50, 50);
            btnInserir.Text = "toolStripButton1";
            btnInserir.Click += btnInserir_Click;
            // 
            // btnEditar
            // 
            btnEditar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnEditar.Image = Properties.Resources.editarIcon;
            btnEditar.ImageScaling = ToolStripItemImageScaling.None;
            btnEditar.ImageTransparentColor = Color.Magenta;
            btnEditar.Name = "btnEditar";
            btnEditar.Padding = new Padding(7);
            btnEditar.Size = new Size(50, 50);
            btnEditar.Text = "toolStripButton2";
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnExcluir.Image = Properties.Resources.deletarIcon;
            btnExcluir.ImageScaling = ToolStripItemImageScaling.None;
            btnExcluir.ImageTransparentColor = Color.Magenta;
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Padding = new Padding(7);
            btnExcluir.Size = new Size(50, 50);
            btnExcluir.Text = "toolStripButton3";
            btnExcluir.Click += btnExcluir_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 53);
            // 
            // btnListaAlugueis
            // 
            btnListaAlugueis.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnListaAlugueis.Image = Properties.Resources.listIcon;
            btnListaAlugueis.ImageAlign = ContentAlignment.MiddleLeft;
            btnListaAlugueis.ImageScaling = ToolStripItemImageScaling.None;
            btnListaAlugueis.ImageTransparentColor = Color.Magenta;
            btnListaAlugueis.MergeAction = MergeAction.Remove;
            btnListaAlugueis.Name = "btnListaAlugueis";
            btnListaAlugueis.Padding = new Padding(7, 7, 1, 7);
            btnListaAlugueis.Size = new Size(44, 50);
            btnListaAlugueis.Text = "toolStripButton3";
            btnListaAlugueis.Click += btnListaAlugueis_Click;
            // 
            // btnPagamento
            // 
            btnPagamento.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnPagamento.Image = Properties.Resources.pagamentoIcon;
            btnPagamento.ImageScaling = ToolStripItemImageScaling.None;
            btnPagamento.ImageTransparentColor = Color.Magenta;
            btnPagamento.Name = "btnPagamento";
            btnPagamento.Padding = new Padding(7);
            btnPagamento.Size = new Size(50, 50);
            btnPagamento.Text = "toolStripButton4";
            btnPagamento.Click += btnPagamento_Click;
            // 
            // btnEndereco
            // 
            btnEndereco.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnEndereco.Image = Properties.Resources.enderecoIcon;
            btnEndereco.ImageScaling = ToolStripItemImageScaling.None;
            btnEndereco.ImageTransparentColor = Color.Magenta;
            btnEndereco.Name = "btnEndereco";
            btnEndereco.Padding = new Padding(7);
            btnEndereco.Size = new Size(50, 50);
            btnEndereco.Text = "toolStripButton1";
            btnEndereco.Click += btnEndereco_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 53);
            // 
            // labelTipoCadastro
            // 
            labelTipoCadastro.Font = new Font("Nirmala UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelTipoCadastro.Name = "labelTipoCadastro";
            labelTipoCadastro.Size = new Size(121, 50);
            labelTipoCadastro.Text = "Tipo de cadastro";
            // 
            // panelRegistros
            // 
            panelRegistros.BorderStyle = BorderStyle.FixedSingle;
            panelRegistros.Dock = DockStyle.Fill;
            panelRegistros.Font = new Font("Nirmala UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            panelRegistros.Location = new Point(0, 93);
            panelRegistros.Name = "panelRegistros";
            panelRegistros.Size = new Size(906, 377);
            panelRegistros.TabIndex = 4;
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = Color.FromArgb(230, 235, 239);
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { labelRodape });
            statusStrip1.Location = new Point(0, 448);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(906, 22);
            statusStrip1.TabIndex = 5;
            statusStrip1.Text = "[rodape]";
            // 
            // labelRodape
            // 
            labelRodape.Font = new Font("Nirmala UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelRodape.Margin = new Padding(16, 4, 0, 2);
            labelRodape.Name = "labelRodape";
            labelRodape.Size = new Size(0, 16);
            // 
            // TelaPrincipalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(906, 470);
            Controls.Add(statusStrip1);
            Controls.Add(panelRegistros);
            Controls.Add(toolBar);
            Controls.Add(menuBar);
            MainMenuStrip = menuBar;
            Name = "TelaPrincipalForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gerenciador de Festas Infantis";
            menuBar.ResumeLayout(false);
            menuBar.PerformLayout();
            toolBar.ResumeLayout(false);
            toolBar.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuBar;
        private ToolStripMenuItem cadastrosToolStripMenuItem;
        private ToolStripMenuItem clientesMenuItem;
        private ToolStripMenuItem TemasMenu;
        private ToolStripMenuItem ItensMenuItem;
        private ToolStripMenuItem aluguelMenuItem;
        private ToolStrip toolBar;
        private ToolStripButton btnInserir;
        private ToolStripButton btnEditar;
        private ToolStripButton btnExcluir;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnPagamento;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripLabel labelTipoCadastro;
        private Panel panelRegistros;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel labelRodape;
        private ToolStripMenuItem TemasMenuItem;
        private ToolStripButton btnEndereco;
        private ToolStripButton btnListaAlugueis;
    }
}