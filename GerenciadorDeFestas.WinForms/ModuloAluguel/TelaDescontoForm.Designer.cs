﻿namespace GerenciadorDeFestas.WinForms.ModuloAluguel
{
    partial class TelaDescontoForm
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
            txtCliente = new TextBox();
            txtId = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txtAlugueis = new TextBox();
            label1 = new Label();
            txtDescontoPorAluguel = new TextBox();
            label4 = new Label();
            txtLimite = new TextBox();
            label5 = new Label();
            txtDescontoPadrão = new TextBox();
            label6 = new Label();
            txtDescontoFinal = new TextBox();
            label7 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtCliente
            // 
            txtCliente.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtCliente.Location = new Point(246, 70);
            txtCliente.Name = "txtCliente";
            txtCliente.ReadOnly = true;
            txtCliente.Size = new Size(176, 32);
            txtCliente.TabIndex = 17;
            // 
            // txtId
            // 
            txtId.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtId.Location = new Point(246, 25);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(176, 32);
            txtId.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(154, 74);
            label3.Name = "label3";
            label3.Size = new Size(80, 25);
            label3.TabIndex = 15;
            label3.Text = "Cliente :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(195, 29);
            label2.Name = "label2";
            label2.Size = new Size(39, 25);
            label2.TabIndex = 14;
            label2.Text = "ID :";
            // 
            // txtAlugueis
            // 
            txtAlugueis.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtAlugueis.Location = new Point(246, 115);
            txtAlugueis.Name = "txtAlugueis";
            txtAlugueis.ReadOnly = true;
            txtAlugueis.Size = new Size(176, 32);
            txtAlugueis.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 119);
            label1.Name = "label1";
            label1.Size = new Size(222, 25);
            label1.TabIndex = 18;
            label1.Text = "Quantidade de aluguéis :";
            // 
            // txtDescontoPorAluguel
            // 
            txtDescontoPorAluguel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescontoPorAluguel.Location = new Point(246, 160);
            txtDescontoPorAluguel.Name = "txtDescontoPorAluguel";
            txtDescontoPorAluguel.ReadOnly = true;
            txtDescontoPorAluguel.Size = new Size(176, 32);
            txtDescontoPorAluguel.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(32, 164);
            label4.Name = "label4";
            label4.Size = new Size(202, 25);
            label4.TabIndex = 20;
            label4.Text = "Desconto por aluguel :";
            // 
            // txtLimite
            // 
            txtLimite.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtLimite.Location = new Point(246, 250);
            txtLimite.Name = "txtLimite";
            txtLimite.ReadOnly = true;
            txtLimite.Size = new Size(176, 32);
            txtLimite.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(33, 254);
            label5.Name = "label5";
            label5.Size = new Size(201, 25);
            label5.TabIndex = 22;
            label5.Text = "Atingiu limite de 15%?";
            // 
            // txtDescontoPadrão
            // 
            txtDescontoPadrão.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescontoPadrão.Location = new Point(246, 205);
            txtDescontoPadrão.Name = "txtDescontoPadrão";
            txtDescontoPadrão.ReadOnly = true;
            txtDescontoPadrão.Size = new Size(176, 32);
            txtDescontoPadrão.TabIndex = 25;
            txtDescontoPadrão.Text = "1%";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(69, 209);
            label6.Name = "label6";
            label6.Size = new Size(165, 25);
            label6.TabIndex = 24;
            label6.Text = "Desconto padrão :";
            // 
            // txtDescontoFinal
            // 
            txtDescontoFinal.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescontoFinal.Location = new Point(246, 295);
            txtDescontoFinal.Name = "txtDescontoFinal";
            txtDescontoFinal.ReadOnly = true;
            txtDescontoFinal.Size = new Size(176, 32);
            txtDescontoFinal.TabIndex = 27;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(100, 299);
            label7.Name = "label7";
            label7.Size = new Size(134, 25);
            label7.TabIndex = 26;
            label7.Text = "Deconto final :";
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(246, 355);
            button1.Name = "button1";
            button1.Size = new Size(176, 44);
            button1.TabIndex = 28;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            // 
            // TelaDescontoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(479, 420);
            Controls.Add(button1);
            Controls.Add(txtDescontoFinal);
            Controls.Add(label7);
            Controls.Add(txtDescontoPadrão);
            Controls.Add(label6);
            Controls.Add(txtLimite);
            Controls.Add(label5);
            Controls.Add(txtDescontoPorAluguel);
            Controls.Add(label4);
            Controls.Add(txtAlugueis);
            Controls.Add(label1);
            Controls.Add(txtCliente);
            Controls.Add(txtId);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "TelaDescontoForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Aplicar desconto ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCliente;
        private TextBox txtId;
        private Label label3;
        private Label label2;
        private TextBox txtAlugueis;
        private Label label1;
        private TextBox txtDescontoPorAluguel;
        private Label label4;
        private TextBox txtLimite;
        private Label label5;
        private TextBox txtDescontoPadrão;
        private Label label6;
        private TextBox txtDescontoFinal;
        private Label label7;
        private Button button1;
    }
}