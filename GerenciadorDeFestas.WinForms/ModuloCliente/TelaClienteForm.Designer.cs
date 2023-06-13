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
            txtTelefone = new TextBox();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(407, 185);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(101, 55);
            btnCancelar.TabIndex = 0;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(299, 185);
            btnGravar.Margin = new Padding(3, 4, 3, 4);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(101, 55);
            btnGravar.TabIndex = 1;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            // 
            // rdbAntigo
            // 
            rdbAntigo.AutoSize = true;
            rdbAntigo.Location = new Point(287, 127);
            rdbAntigo.Margin = new Padding(3, 4, 3, 4);
            rdbAntigo.Name = "rdbAntigo";
            rdbAntigo.Size = new Size(75, 24);
            rdbAntigo.TabIndex = 2;
            rdbAntigo.TabStop = true;
            rdbAntigo.Text = "Antigo";
            rdbAntigo.UseVisualStyleBackColor = true;
            // 
            // rdbNovo
            // 
            rdbNovo.AutoSize = true;
            rdbNovo.Location = new Point(211, 127);
            rdbNovo.Margin = new Padding(3, 4, 3, 4);
            rdbNovo.Name = "rdbNovo";
            rdbNovo.Size = new Size(66, 24);
            rdbNovo.TabIndex = 3;
            rdbNovo.TabStop = true;
            rdbNovo.Text = "Novo";
            rdbNovo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 129);
            label1.Name = "label1";
            label1.Size = new Size(175, 20);
            label1.TabIndex = 4;
            label1.Text = "Escolha o tipo de cliente:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(425, 34);
            label2.Name = "label2";
            label2.Size = new Size(25, 20);
            label2.TabIndex = 5;
            label2.Text = "Id:";
            // 
            // txtId
            // 
            txtId.Location = new Point(455, 30);
            txtId.Margin = new Padding(3, 4, 3, 4);
            txtId.Name = "txtId";
            txtId.Size = new Size(31, 27);
            txtId.TabIndex = 6;
            txtId.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 33);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 7;
            label3.Text = "Nome:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 83);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 8;
            label4.Text = "Telefone:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(90, 29);
            txtNome.Margin = new Padding(3, 4, 3, 4);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(322, 27);
            txtNome.TabIndex = 9;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(90, 79);
            txtTelefone.Margin = new Padding(3, 4, 3, 4);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(143, 27);
            txtTelefone.TabIndex = 10;
            // 
            // TelaClienteForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(521, 254);
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
            Text = "TelaClienteForm";
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
        private TextBox txtTelefone;
    }
}