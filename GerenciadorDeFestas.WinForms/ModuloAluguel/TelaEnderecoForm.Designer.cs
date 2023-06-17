namespace GerenciadorDeFestas.WinForms.ModuloAluguel
{
    partial class TelaEnderecoForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtCep = new MaskedTextBox();
            txtId = new TextBox();
            txtRua = new TextBox();
            txtNumero = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(244, 148);
            label1.Name = "label1";
            label1.Size = new Size(54, 25);
            label1.TabIndex = 0;
            label1.Text = "CEP :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(73, 42);
            label2.Name = "label2";
            label2.Size = new Size(39, 25);
            label2.TabIndex = 1;
            label2.Text = "ID :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(59, 95);
            label3.Name = "label3";
            label3.Size = new Size(53, 25);
            label3.TabIndex = 2;
            label3.Text = "Rua :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(21, 148);
            label4.Name = "label4";
            label4.Size = new Size(90, 25);
            label4.TabIndex = 3;
            label4.Text = "Número :";
            // 
            // txtCep
            // 
            txtCep.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtCep.Location = new Point(311, 144);
            txtCep.Mask = "00000-000";
            txtCep.Name = "txtCep";
            txtCep.ReadOnly = true;
            txtCep.Size = new Size(125, 32);
            txtCep.TabIndex = 11;
            // 
            // txtId
            // 
            txtId.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtId.Location = new Point(124, 38);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(312, 32);
            txtId.TabIndex = 12;
            // 
            // txtRua
            // 
            txtRua.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtRua.Location = new Point(124, 91);
            txtRua.Name = "txtRua";
            txtRua.ReadOnly = true;
            txtRua.Size = new Size(312, 32);
            txtRua.TabIndex = 13;
            // 
            // txtNumero
            // 
            txtNumero.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtNumero.Location = new Point(124, 144);
            txtNumero.Name = "txtNumero";
            txtNumero.ReadOnly = true;
            txtNumero.Size = new Size(108, 32);
            txtNumero.TabIndex = 14;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(124, 201);
            button1.Name = "button1";
            button1.Size = new Size(312, 44);
            button1.TabIndex = 15;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            // 
            // TelaEnderecoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(465, 267);
            Controls.Add(button1);
            Controls.Add(txtNumero);
            Controls.Add(txtRua);
            Controls.Add(txtId);
            Controls.Add(txtCep);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "TelaEnderecoForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tela Endereço";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private MaskedTextBox txtCep;
        private TextBox txtId;
        private TextBox txtRua;
        private TextBox txtNumero;
        private Button button1;
    }
}