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
            rdbQuarenta = new RadioButton();
            rdbCinquenta = new RadioButton();
            rdbCem = new RadioButton();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(36, 228);
            button1.Name = "button1";
            button1.Size = new Size(217, 44);
            button1.TabIndex = 33;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            // 
            // rdbQuarenta
            // 
            rdbQuarenta.AutoSize = true;
            rdbQuarenta.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rdbQuarenta.Location = new Point(69, 50);
            rdbQuarenta.Margin = new Padding(3, 4, 3, 4);
            rdbQuarenta.Name = "rdbQuarenta";
            rdbQuarenta.Size = new Size(71, 32);
            rdbQuarenta.TabIndex = 34;
            rdbQuarenta.TabStop = true;
            rdbQuarenta.Text = "40%";
            rdbQuarenta.UseVisualStyleBackColor = true;
            // 
            // rdbCinquenta
            // 
            rdbCinquenta.AutoSize = true;
            rdbCinquenta.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rdbCinquenta.Location = new Point(69, 90);
            rdbCinquenta.Margin = new Padding(3, 4, 3, 4);
            rdbCinquenta.Name = "rdbCinquenta";
            rdbCinquenta.Size = new Size(71, 32);
            rdbCinquenta.TabIndex = 35;
            rdbCinquenta.TabStop = true;
            rdbCinquenta.Text = "50%";
            rdbCinquenta.UseVisualStyleBackColor = true;
            // 
            // rdbCem
            // 
            rdbCem.AutoSize = true;
            rdbCem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rdbCem.Location = new Point(69, 130);
            rdbCem.Margin = new Padding(3, 4, 3, 4);
            rdbCem.Name = "rdbCem";
            rdbCem.Size = new Size(82, 32);
            rdbCem.TabIndex = 36;
            rdbCem.TabStop = true;
            rdbCem.Text = "100%";
            rdbCem.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdbQuarenta);
            groupBox1.Controls.Add(rdbCem);
            groupBox1.Controls.Add(rdbCinquenta);
            groupBox1.Font = new Font("Segoe UI", 12.5F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(36, 24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(217, 188);
            groupBox1.TabIndex = 37;
            groupBox1.TabStop = false;
            groupBox1.Text = "Selecione a % paga";
            // 
            // TelaPagamentoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(285, 296);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "TelaPagamentoForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tela Pagamento";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private RadioButton rdbQuarenta;
        private RadioButton rdbCinquenta;
        private RadioButton rdbCem;
        private GroupBox groupBox1;
    }
}