namespace GerenciadorDeFestas.WinForms.ModuloAluguel
{
    partial class TelaPagamentoForm
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
            label13 = new Label();
            txtValorTotal = new TextBox();
            label12 = new Label();
            txtValorPago = new TextBox();
            txtValorPendente = new TextBox();
            label10 = new Label();
            label11 = new Label();
            txtPorcentagem = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(41, 77);
            label13.Name = "label13";
            label13.Size = new Size(83, 25);
            label13.TabIndex = 31;
            label13.Text = "% Paga :";
            // 
            // txtValorTotal
            // 
            txtValorTotal.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtValorTotal.Location = new Point(130, 30);
            txtValorTotal.Margin = new Padding(3, 4, 3, 4);
            txtValorTotal.Name = "txtValorTotal";
            txtValorTotal.ReadOnly = true;
            txtValorTotal.Size = new Size(132, 32);
            txtValorTotal.TabIndex = 28;
            txtValorTotal.Text = "R$ ";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(25, 163);
            label12.Name = "label12";
            label12.Size = new Size(100, 25);
            label12.TabIndex = 29;
            label12.Text = "Pendente :";
            // 
            // txtValorPago
            // 
            txtValorPago.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtValorPago.Location = new Point(130, 117);
            txtValorPago.Margin = new Padding(3, 4, 3, 4);
            txtValorPago.Name = "txtValorPago";
            txtValorPago.ReadOnly = true;
            txtValorPago.Size = new Size(132, 32);
            txtValorPago.TabIndex = 24;
            txtValorPago.Text = "R$ ";
            // 
            // txtValorPendente
            // 
            txtValorPendente.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtValorPendente.Location = new Point(130, 160);
            txtValorPendente.Margin = new Padding(3, 4, 3, 4);
            txtValorPendente.Name = "txtValorPendente";
            txtValorPendente.ReadOnly = true;
            txtValorPendente.Size = new Size(132, 32);
            txtValorPendente.TabIndex = 30;
            txtValorPendente.Text = "R$ ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(61, 120);
            label10.Name = "label10";
            label10.Size = new Size(63, 25);
            label10.TabIndex = 25;
            label10.Text = "Pago :";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(63, 34);
            label11.Name = "label11";
            label11.Size = new Size(61, 25);
            label11.TabIndex = 27;
            label11.Text = "Total :";
            // 
            // txtPorcentagem
            // 
            txtPorcentagem.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtPorcentagem.Location = new Point(130, 74);
            txtPorcentagem.Margin = new Padding(3, 4, 3, 4);
            txtPorcentagem.Name = "txtPorcentagem";
            txtPorcentagem.ReadOnly = true;
            txtPorcentagem.Size = new Size(132, 32);
            txtPorcentagem.TabIndex = 32;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(130, 215);
            button1.Name = "button1";
            button1.Size = new Size(132, 44);
            button1.TabIndex = 33;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            // 
            // TelaPagamentoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(333, 284);
            Controls.Add(button1);
            Controls.Add(txtPorcentagem);
            Controls.Add(label13);
            Controls.Add(txtValorTotal);
            Controls.Add(label12);
            Controls.Add(txtValorPago);
            Controls.Add(txtValorPendente);
            Controls.Add(label10);
            Controls.Add(label11);
            Margin = new Padding(3, 4, 3, 4);
            Name = "TelaPagamentoForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tela Pagamento";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label13;
        private TextBox txtValorTotal;
        private Label label12;
        private TextBox txtValorPago;
        private TextBox txtValorPendente;
        private Label label10;
        private Label label11;
        private TextBox txtPorcentagem;
        private Button button1;
    }
}