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
            button1 = new Button();
            label13 = new Label();
            rdbQuarenta = new RadioButton();
            rdbCinquenta = new RadioButton();
            rdbCem = new RadioButton();
            SuspendLayout();
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(166, 114);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(116, 33);
            button1.TabIndex = 33;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(12, 22);
            label13.Name = "label13";
            label13.Size = new Size(74, 21);
            label13.TabIndex = 31;
            label13.Text = "% Paga :";
            // 
            // rdbQuarenta
            // 
            rdbQuarenta.AutoSize = true;
            rdbQuarenta.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            rdbQuarenta.Location = new Point(15, 60);
            rdbQuarenta.Name = "rdbQuarenta";
            rdbQuarenta.Size = new Size(60, 25);
            rdbQuarenta.TabIndex = 34;
            rdbQuarenta.TabStop = true;
            rdbQuarenta.Text = "40%";
            rdbQuarenta.UseVisualStyleBackColor = true;
            // 
            // rdbCinquenta
            // 
            rdbCinquenta.AutoSize = true;
            rdbCinquenta.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            rdbCinquenta.Location = new Point(111, 60);
            rdbCinquenta.Name = "rdbCinquenta";
            rdbCinquenta.Size = new Size(60, 25);
            rdbCinquenta.TabIndex = 35;
            rdbCinquenta.TabStop = true;
            rdbCinquenta.Text = "50%";
            rdbCinquenta.UseVisualStyleBackColor = true;
            // 
            // rdbCem
            // 
            rdbCem.AutoSize = true;
            rdbCem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            rdbCem.Location = new Point(213, 60);
            rdbCem.Name = "rdbCem";
            rdbCem.Size = new Size(69, 25);
            rdbCem.TabIndex = 36;
            rdbCem.TabStop = true;
            rdbCem.Text = "100%";
            rdbCem.UseVisualStyleBackColor = true;
            // 
            // TelaPagamentoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(291, 163);
            Controls.Add(rdbCem);
            Controls.Add(rdbCinquenta);
            Controls.Add(rdbQuarenta);
            Controls.Add(button1);
            Controls.Add(label13);
            Name = "TelaPagamentoForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tela Pagamento";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Label label13;
        private RadioButton rdbQuarenta;
        private RadioButton rdbCinquenta;
        private RadioButton rdbCem;
    }
}