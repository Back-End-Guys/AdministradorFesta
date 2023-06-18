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
            btnCancelar.Location = new Point(259, 139);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(88, 41);
            btnCancelar.TabIndex = 0;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            btnGravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnGravar.Location = new Point(165, 139);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(88, 41);
            btnGravar.TabIndex = 1;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(57, 15);
            label2.Name = "label2";
            label2.Size = new Size(31, 20);
            label2.TabIndex = 5;
            label2.Text = "ID :";
            // 
            // txtId
            // 
            txtId.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtId.Location = new Point(96, 12);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(126, 27);
            txtId.TabIndex = 6;
            txtId.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(31, 99);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 7;
            label3.Text = "Nome :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(15, 56);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 8;
            label4.Text = "Telefone :";
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtNome.Location = new Point(96, 96);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(250, 27);
            txtNome.TabIndex = 9;
            // 
            // txtTelefone
            // 
            txtTelefone.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtTelefone.Location = new Point(96, 53);
            txtTelefone.Margin = new Padding(3, 2, 3, 2);
            txtTelefone.Mask = "(00) 00000-0000";
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(126, 27);
            txtTelefone.TabIndex = 10;
            // 
            // TelaClienteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(370, 192);
            Controls.Add(txtTelefone);
            Controls.Add(txtNome);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtId);
            Controls.Add(label2);
            Controls.Add(btnGravar);
            Controls.Add(btnCancelar);
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
        private Label label2;
        private TextBox txtId;
        private Label label3;
        private Label label4;
        private TextBox txtNome;
        private MaskedTextBox txtTelefone;
    }
}