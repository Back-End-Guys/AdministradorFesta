namespace GerenciadorDeFestas.WinForms.ModuloTema
{
    partial class TelaListagemItensForm
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
            listagem = new TabelaListagemItensControl();
            lblNome = new Label();
            lblItens = new Label();
            SuspendLayout();
            // 
            // listagem
            // 
            listagem.Font = new Font("Segoe UI", 12.5F, FontStyle.Regular, GraphicsUnit.Point);
            listagem.Location = new Point(-2, 100);
            listagem.Margin = new Padding(4, 4, 4, 4);
            listagem.Name = "listagem";
            listagem.Size = new Size(803, 393);
            listagem.TabIndex = 0;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblNome.Location = new Point(12, 9);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(95, 37);
            lblNome.TabIndex = 2;
            lblNome.Text = "Nome";
            // 
            // lblItens
            // 
            lblItens.AutoSize = true;
            lblItens.Font = new Font("Segoe UI", 12.5F, FontStyle.Regular, GraphicsUnit.Point);
            lblItens.Location = new Point(12, 57);
            lblItens.Name = "lblItens";
            lblItens.Size = new Size(152, 30);
            lblItens.TabIndex = 3;
            lblItens.Text = "Itens do tema :";
            // 
            // TelaListagemItensForm
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 455);
            Controls.Add(lblItens);
            Controls.Add(lblNome);
            Controls.Add(listagem);
            Name = "TelaListagemItensForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tela Listagem Itens";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabelaListagemItensControl listagem;
        private Label lblNome;
        private Label lblItens;
    }
}