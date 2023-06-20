namespace GerenciadorDeFestas.WinForms.ModuloTema
{
    partial class ListagemItensForm
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
            lblNome = new Label();
            listaItens = new ListagemItensControl();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnOK = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Dock = DockStyle.Fill;
            lblNome.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblNome.Location = new Point(3, 0);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(795, 65);
            lblNome.TabIndex = 2;
            lblNome.Text = "Nome";
            lblNome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // listaItens
            // 
            listaItens.Location = new Point(-2, 69);
            listaItens.Name = "listaItens";
            listaItens.Size = new Size(801, 328);
            listaItens.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(lblNome, 0, 0);
            tableLayoutPanel1.Location = new Point(-2, 1);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(801, 65);
            tableLayoutPanel1.TabIndex = 4;
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
            btnOK.Size = new Size(795, 47);
            btnOK.TabIndex = 5;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.MouseEnter += btnOK_MouseEnter;
            btnOK.MouseLeave += btnOK_MouseLeave;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(btnOK, 0, 0);
            tableLayoutPanel2.Location = new Point(-2, 393);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(801, 53);
            tableLayoutPanel2.TabIndex = 6;
            // 
            // ListagemItensForm
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(800, 445);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(listaItens);
            Name = "ListagemItensForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tela Listagem Itens";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label lblNome;
        private ListagemItensControl listaItens;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnOK;
        private TableLayoutPanel tableLayoutPanel2;
    }
}