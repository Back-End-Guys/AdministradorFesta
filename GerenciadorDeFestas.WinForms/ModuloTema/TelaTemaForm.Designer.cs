namespace GerenciadorDeFestas.WinForms.ModuloTema
{
    partial class TelaTemaForm
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
            txtId = new TextBox();
            label2 = new Label();
            btnGravar = new Button();
            btnCancelar = new Button();
            txtNome = new TextBox();
            label1 = new Label();
            chListItens = new CheckedListBox();
            label3 = new Label();
            txtValor = new TextBox();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtId.Location = new Point(95, 32);
            txtId.Margin = new Padding(3, 4, 3, 4);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(238, 32);
            txtId.TabIndex = 10;
            txtId.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(53, 36);
            label2.Name = "label2";
            label2.Size = new Size(39, 25);
            label2.TabIndex = 9;
            label2.Text = "ID :";
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnGravar.Location = new Point(108, 345);
            btnGravar.Margin = new Padding(3, 4, 3, 4);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(101, 55);
            btnGravar.TabIndex = 8;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.Location = new Point(214, 345);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(101, 55);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtNome.Location = new Point(95, 72);
            txtNome.Margin = new Padding(3, 4, 3, 4);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(238, 32);
            txtNome.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(20, 75);
            label1.Name = "label1";
            label1.Size = new Size(72, 25);
            label1.TabIndex = 12;
            label1.Text = "Nome :";
            // 
            // chListItens
            // 
            chListItens.CheckOnClick = true;
            chListItens.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            chListItens.FormattingEnabled = true;
            chListItens.Location = new Point(95, 112);
            chListItens.Margin = new Padding(3, 4, 3, 4);
            chListItens.Name = "chListItens";
            chListItens.Size = new Size(238, 166);
            chListItens.TabIndex = 13;
            chListItens.SelectedValueChanged += chListItens_SelectedValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(31, 293);
            label3.Name = "label3";
            label3.Size = new Size(61, 25);
            label3.TabIndex = 14;
            label3.Text = "Total :";
            // 
            // txtValor
            // 
            txtValor.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtValor.Location = new Point(95, 289);
            txtValor.Margin = new Padding(3, 4, 3, 4);
            txtValor.Name = "txtValor";
            txtValor.ReadOnly = true;
            txtValor.Size = new Size(238, 32);
            txtValor.TabIndex = 15;
            txtValor.Text = "R$ 0";
            // 
            // TelaTemaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(386, 426);
            Controls.Add(txtValor);
            Controls.Add(label3);
            Controls.Add(chListItens);
            Controls.Add(label1);
            Controls.Add(txtNome);
            Controls.Add(txtId);
            Controls.Add(label2);
            Controls.Add(btnGravar);
            Controls.Add(btnCancelar);
            Margin = new Padding(3, 4, 3, 4);
            Name = "TelaTemaForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tela Tema";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtId;
        private Label label2;
        private Button btnGravar;
        private Button btnCancelar;
        private TextBox txtNome;
        private Label label1;
        private CheckedListBox chListItens;
        private Label label3;
        private TextBox txtValor;
    }
}