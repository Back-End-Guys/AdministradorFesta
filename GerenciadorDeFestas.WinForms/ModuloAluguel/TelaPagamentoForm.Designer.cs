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
            txtId = new TextBox();
            label2 = new Label();
            btnGravar = new Button();
            btnCancelar = new Button();
            rdbQuarenta = new RadioButton();
            rdbCinquenta = new RadioButton();
            rdbCem = new RadioButton();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Location = new Point(66, 36);
            txtId.Margin = new Padding(3, 4, 3, 4);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(31, 27);
            txtId.TabIndex = 10;
            txtId.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 40);
            label2.Name = "label2";
            label2.Size = new Size(25, 20);
            label2.TabIndex = 9;
            label2.Text = "Id:";
            // 
            // btnGravar
            // 
            btnGravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(91, 211);
            btnGravar.Margin = new Padding(3, 4, 3, 4);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(101, 55);
            btnGravar.TabIndex = 8;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(199, 211);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(101, 55);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // rdbQuarenta
            // 
            rdbQuarenta.AutoSize = true;
            rdbQuarenta.Location = new Point(50, 41);
            rdbQuarenta.Name = "rdbQuarenta";
            rdbQuarenta.Size = new Size(58, 24);
            rdbQuarenta.TabIndex = 12;
            rdbQuarenta.TabStop = true;
            rdbQuarenta.Text = "40%";
            rdbQuarenta.UseVisualStyleBackColor = true;
            // 
            // rdbCinquenta
            // 
            rdbCinquenta.AutoSize = true;
            rdbCinquenta.Location = new Point(50, 71);
            rdbCinquenta.Name = "rdbCinquenta";
            rdbCinquenta.Size = new Size(58, 24);
            rdbCinquenta.TabIndex = 13;
            rdbCinquenta.TabStop = true;
            rdbCinquenta.Text = "50%";
            rdbCinquenta.UseVisualStyleBackColor = true;
            // 
            // rdbCem
            // 
            rdbCem.AutoSize = true;
            rdbCem.Location = new Point(50, 101);
            rdbCem.Name = "rdbCem";
            rdbCem.Size = new Size(66, 24);
            rdbCem.TabIndex = 14;
            rdbCem.TabStop = true;
            rdbCem.Text = "100%";
            rdbCem.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdbQuarenta);
            groupBox1.Controls.Add(rdbCem);
            groupBox1.Controls.Add(rdbCinquenta);
            groupBox1.Location = new Point(137, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(161, 154);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Porcentagem paga";
            // 
            // TelaPagamentoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(331, 288);
            Controls.Add(groupBox1);
            Controls.Add(txtId);
            Controls.Add(label2);
            Controls.Add(btnGravar);
            Controls.Add(btnCancelar);
            Margin = new Padding(3, 4, 3, 4);
            Name = "TelaPagamentoForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TelaPagamentoForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtId;
        private Label label2;
        private Button btnGravar;
        private Button btnCancelar;
        private RadioButton rdbQuarenta;
        private RadioButton rdbCinquenta;
        private RadioButton rdbCem;
        private GroupBox groupBox1;
    }
}