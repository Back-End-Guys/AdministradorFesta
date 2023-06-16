namespace GerenciadorDeFestas.WinForms.ModuloCliente
{
    partial class TelaListagemAlugueisForm
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
            tabelaListagemControl1 = new TabelaListagemControl();
            lblNome = new Label();
            SuspendLayout();
            // 
            // tabelaListagemControl1
            // 
            tabelaListagemControl1.BackColor = SystemColors.ControlDark;
            tabelaListagemControl1.Dock = DockStyle.Bottom;
            tabelaListagemControl1.Location = new Point(0, 73);
            tabelaListagemControl1.Name = "tabelaListagemControl1";
            tabelaListagemControl1.Size = new Size(800, 377);
            tabelaListagemControl1.TabIndex = 0;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblNome.Location = new Point(12, 20);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(73, 30);
            lblNome.TabIndex = 1;
            lblNome.Text = "Nome";
            // 
            // TelaListagemAlugueisForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblNome);
            Controls.Add(tabelaListagemControl1);
            Name = "TelaListagemAlugueisForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tela listagem aluguel";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabelaListagemControl tabelaListagemControl1;
        private Label lblNome;
    }
}