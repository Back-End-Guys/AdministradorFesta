namespace GerenciadorDeFestas.WinForms.ModuloCliente
{
    partial class TelaClienteForm
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
            btnCancelar = new Button();
            btnGravar = new Button();
            rdbAntigo = new RadioButton();
            rdbNovo = new RadioButton();
            label1 = new Label();
            label2 = new Label();
            txtId = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtNome = new TextBox();
            txtTelefone = new MaskedTextBox();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.Location = new Point(550, 173);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(101, 55);
            btnCancelar.TabIndex = 0;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            btnGravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnGravar.Location = new Point(442, 173);
            btnGravar.Margin = new Padding(3, 4, 3, 4);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(101, 55);
            btnGravar.TabIndex = 1;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // rdbAntigo
            // 
            rdbAntigo.AutoSize = true;
            rdbAntigo.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            rdbAntigo.Location = new Point(561, 48);
            rdbAntigo.Margin = new Padding(3, 4, 3, 4);
            rdbAntigo.Name = "rdbAntigo";
            rdbAntigo.Size = new Size(89, 29);
            rdbAntigo.TabIndex = 2;
            rdbAntigo.TabStop = true;
            rdbAntigo.Text = "Antigo";
            rdbAntigo.UseVisualStyleBackColor = true;
            // 
            // rdbNovo
            // 
            rdbNovo.AutoSize = true;
            rdbNovo.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            rdbNovo.Location = new Point(456, 48);
            rdbNovo.Margin = new Padding(3, 4, 3, 4);
            rdbNovo.Name = "rdbNovo";
            rdbNovo.Size = new Size(78, 29);
            rdbNovo.TabIndex = 3;
            rdbNovo.TabStop = true;
            rdbNovo.Text = "Novo";
            rdbNovo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(289, 50);
            label1.Name = "label1";
            label1.Size = new Size(140, 25);
            label1.TabIndex = 4;
            label1.Text = "Tipo de cliente:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(85, 52);
            label2.Name = "label2";
            label2.Size = new Size(39, 25);
            label2.TabIndex = 5;
            label2.Text = "ID :";
            // 
            // txtId
            // 
            txtId.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtId.Location = new Point(127, 48);
            txtId.Margin = new Padding(3, 4, 3, 4);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(143, 32);
            txtId.TabIndex = 6;
            txtId.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(293, 103);
            label3.Name = "label3";
            label3.Size = new Size(72, 25);
            label3.TabIndex = 7;
            label3.Text = "Nome :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(34, 107);
            label4.Name = "label4";
            label4.Size = new Size(92, 25);
            label4.TabIndex = 8;
            label4.Text = "Telefone :";
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtNome.Location = new Point(365, 99);
            txtNome.Margin = new Padding(3, 4, 3, 4);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(285, 32);
            txtNome.TabIndex = 9;
            // 
            // txtTelefone
            // 
            txtTelefone.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtTelefone.Location = new Point(127, 103);
            txtTelefone.Mask = "(00) 00000-0000";
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(143, 32);
            txtTelefone.TabIndex = 10;
            // 
            // TelaClienteForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(701, 258);
            Controls.Add(txtTelefone);
            Controls.Add(txtNome);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtId);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(rdbNovo);
            Controls.Add(rdbAntigo);
            Controls.Add(btnGravar);
            Controls.Add(btnCancelar);
            Margin = new Padding(3, 4, 3, 4);
            Name = "TelaClienteForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tela Cliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnGravar;
        private RadioButton rdbAntigo;
        private RadioButton rdbNovo;
        private Label label1;
        private Label label2;
        private TextBox txtId;
        private Label label3;
        private Label label4;
        private TextBox txtNome;
        private MaskedTextBox txtTelefone;
    }
}