namespace GerenciadorDeFestas.WinForms.ModuloCliente
{
    partial class ListagemAlugueisForm
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
            tableLayoutPanel2 = new TableLayoutPanel();
            btnOK = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblNome = new Label();
            listaAlugueis = new ListagemAlugueisControl();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(btnOK, 0, 0);
            tableLayoutPanel2.Location = new Point(-3, 394);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(914, 59);
            tableLayoutPanel2.TabIndex = 9;
            // 
            // btnOK
            // 
            btnOK.DialogResult = DialogResult.OK;
            btnOK.Dock = DockStyle.Fill;
            btnOK.FlatAppearance.BorderSize = 0;
            btnOK.FlatStyle = FlatStyle.Flat;
            btnOK.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnOK.Location = new Point(3, 3);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(908, 53);
            btnOK.TabIndex = 5;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = false;
            btnOK.MouseEnter += btnOK_MouseEnter;
            btnOK.MouseLeave += btnOK_MouseLeave;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(lblNome, 0, 0);
            tableLayoutPanel1.Location = new Point(2, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(913, 65);
            tableLayoutPanel1.TabIndex = 8;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.BackColor = Color.Snow;
            lblNome.Dock = DockStyle.Fill;
            lblNome.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblNome.Location = new Point(3, 0);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(907, 65);
            lblNome.TabIndex = 2;
            lblNome.Text = "Nome";
            lblNome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // listaAlugueis
            // 
            listaAlugueis.Location = new Point(0, 60);
            listaAlugueis.Margin = new Padding(3, 4, 3, 4);
            listaAlugueis.Name = "listaAlugueis";
            listaAlugueis.Size = new Size(914, 334);
            listaAlugueis.TabIndex = 10;
            // 
            // ListagemAlugueisForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(908, 453);
            Controls.Add(listaAlugueis);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ListagemAlugueisForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tela listagem aluguel";
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel2;
        private Button btnOK;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblNome;
        private ListagemAlugueisControl listaAlugueis;
    }
}