namespace GerenciadorDeFestas.WinForms.ModuloAluguel
{
    partial class TelaAluguelForm
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
            label1 = new Label();
            label3 = new Label();
            cbCliente = new ComboBox();
            cbTema = new ComboBox();
            groupBox1 = new GroupBox();
            dtHorarioFinal = new DateTimePicker();
            dtHorarioInicio = new DateTimePicker();
            dtData = new DateTimePicker();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            Localização = new GroupBox();
            txtCep = new MaskedTextBox();
            txtNumero = new TextBox();
            txtRua = new TextBox();
            label14 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            txtValorPago = new TextBox();
            label10 = new Label();
            label11 = new Label();
            txtValorTotal = new TextBox();
            label12 = new Label();
            txtValorPendente = new TextBox();
            groupBox3 = new GroupBox();
            cbPorcentagens = new ComboBox();
            label13 = new Label();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            Localização.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtId.Location = new Point(99, 48);
            txtId.Margin = new Padding(3, 4, 3, 4);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(155, 32);
            txtId.TabIndex = 10;
            txtId.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(54, 52);
            label2.Name = "label2";
            label2.Size = new Size(39, 25);
            label2.TabIndex = 9;
            label2.Text = "ID :";
            // 
            // btnGravar
            // 
            btnGravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnGravar.Location = new Point(405, 474);
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
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.Location = new Point(512, 474);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(101, 55);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(13, 109);
            label1.Name = "label1";
            label1.Size = new Size(80, 25);
            label1.TabIndex = 11;
            label1.Text = "Cliente :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(28, 167);
            label3.Name = "label3";
            label3.Size = new Size(65, 25);
            label3.TabIndex = 12;
            label3.Text = "Tema :";
            // 
            // cbCliente
            // 
            cbCliente.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            cbCliente.FormattingEnabled = true;
            cbCliente.Location = new Point(99, 105);
            cbCliente.Margin = new Padding(3, 4, 3, 4);
            cbCliente.Name = "cbCliente";
            cbCliente.Size = new Size(155, 33);
            cbCliente.TabIndex = 13;
            cbCliente.SelectedValueChanged += cbCliente_SelectedValueChanged;
            // 
            // cbTema
            // 
            cbTema.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            cbTema.FormattingEnabled = true;
            cbTema.Location = new Point(99, 163);
            cbTema.Margin = new Padding(3, 4, 3, 4);
            cbTema.Name = "cbTema";
            cbTema.Size = new Size(155, 33);
            cbTema.TabIndex = 14;
            cbTema.SelectedValueChanged += cbTema_SelectedValueChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtHorarioFinal);
            groupBox1.Controls.Add(dtHorarioInicio);
            groupBox1.Controls.Add(dtData);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(23, 242);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(288, 219);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Data e Hora";
            // 
            // dtHorarioFinal
            // 
            dtHorarioFinal.CustomFormat = "HH:mm";
            dtHorarioFinal.Format = DateTimePickerFormat.Custom;
            dtHorarioFinal.Location = new Point(99, 165);
            dtHorarioFinal.Margin = new Padding(3, 4, 3, 4);
            dtHorarioFinal.Name = "dtHorarioFinal";
            dtHorarioFinal.ShowUpDown = true;
            dtHorarioFinal.Size = new Size(155, 32);
            dtHorarioFinal.TabIndex = 10;
            dtHorarioFinal.Value = new DateTime(2023, 6, 13, 18, 0, 0, 0);
            // 
            // dtHorarioInicio
            // 
            dtHorarioInicio.CustomFormat = "HH:mm";
            dtHorarioInicio.Format = DateTimePickerFormat.Custom;
            dtHorarioInicio.Location = new Point(99, 108);
            dtHorarioInicio.Margin = new Padding(3, 4, 3, 4);
            dtHorarioInicio.Name = "dtHorarioInicio";
            dtHorarioInicio.ShowUpDown = true;
            dtHorarioInicio.Size = new Size(155, 32);
            dtHorarioInicio.TabIndex = 8;
            dtHorarioInicio.Value = new DateTime(2023, 6, 13, 13, 0, 0, 0);
            // 
            // dtData
            // 
            dtData.Format = DateTimePickerFormat.Short;
            dtData.Location = new Point(99, 51);
            dtData.Margin = new Padding(3, 4, 3, 4);
            dtData.Name = "dtData";
            dtData.Size = new Size(155, 32);
            dtData.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(42, 169);
            label6.Name = "label6";
            label6.Size = new Size(51, 25);
            label6.TabIndex = 2;
            label6.Text = "Fim :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 112);
            label5.Name = "label5";
            label5.Size = new Size(67, 25);
            label5.TabIndex = 1;
            label5.Text = "Início :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 55);
            label4.Name = "label4";
            label4.Size = new Size(60, 25);
            label4.TabIndex = 0;
            label4.Text = "Data :";
            // 
            // Localização
            // 
            Localização.Controls.Add(txtCep);
            Localização.Controls.Add(txtNumero);
            Localização.Controls.Add(txtRua);
            Localização.Controls.Add(label14);
            Localização.Controls.Add(label9);
            Localização.Controls.Add(label8);
            Localização.Controls.Add(label7);
            Localização.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Localização.Location = new Point(339, 242);
            Localização.Margin = new Padding(3, 4, 3, 4);
            Localização.Name = "Localização";
            Localização.Padding = new Padding(3, 4, 3, 4);
            Localização.Size = new Size(274, 219);
            Localização.TabIndex = 16;
            Localização.TabStop = false;
            Localização.Text = "Localização";
            // 
            // txtCep
            // 
            txtCep.Location = new Point(116, 51);
            txtCep.Mask = "00000-000";
            txtCep.Name = "txtCep";
            txtCep.Size = new Size(131, 32);
            txtCep.TabIndex = 6;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(116, 165);
            txtNumero.Margin = new Padding(3, 4, 3, 4);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(131, 32);
            txtNumero.TabIndex = 5;
            // 
            // txtRua
            // 
            txtRua.Location = new Point(116, 108);
            txtRua.Margin = new Padding(3, 4, 3, 4);
            txtRua.Name = "txtRua";
            txtRua.Size = new Size(131, 32);
            txtRua.TabIndex = 4;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(20, 169);
            label14.Name = "label14";
            label14.Size = new Size(90, 25);
            label14.TabIndex = 2;
            label14.Text = "Número :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(20, 165);
            label9.Name = "label9";
            label9.Size = new Size(90, 25);
            label9.TabIndex = 2;
            label9.Text = "Número :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(57, 112);
            label8.Name = "label8";
            label8.Size = new Size(53, 25);
            label8.TabIndex = 1;
            label8.Text = "Rua :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(56, 55);
            label7.Name = "label7";
            label7.Size = new Size(54, 25);
            label7.TabIndex = 0;
            label7.Text = "CEP :";
            // 
            // txtValorPago
            // 
            txtValorPago.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtValorPago.Location = new Point(115, 132);
            txtValorPago.Margin = new Padding(3, 4, 3, 4);
            txtValorPago.Name = "txtValorPago";
            txtValorPago.ReadOnly = true;
            txtValorPago.Size = new Size(132, 32);
            txtValorPago.TabIndex = 18;
            txtValorPago.Text = "R$ ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(46, 135);
            label10.Name = "label10";
            label10.Size = new Size(63, 25);
            label10.TabIndex = 18;
            label10.Text = "Pago :";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(48, 49);
            label11.Name = "label11";
            label11.Size = new Size(61, 25);
            label11.TabIndex = 19;
            label11.Text = "Total :";
            // 
            // txtValorTotal
            // 
            txtValorTotal.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtValorTotal.Location = new Point(115, 45);
            txtValorTotal.Margin = new Padding(3, 4, 3, 4);
            txtValorTotal.Name = "txtValorTotal";
            txtValorTotal.ReadOnly = true;
            txtValorTotal.Size = new Size(132, 32);
            txtValorTotal.TabIndex = 20;
            txtValorTotal.Text = "R$ ";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(10, 178);
            label12.Name = "label12";
            label12.Size = new Size(100, 25);
            label12.TabIndex = 21;
            label12.Text = "Pendente :";
            // 
            // txtValorPendente
            // 
            txtValorPendente.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtValorPendente.Location = new Point(115, 175);
            txtValorPendente.Margin = new Padding(3, 4, 3, 4);
            txtValorPendente.Name = "txtValorPendente";
            txtValorPendente.ReadOnly = true;
            txtValorPendente.Size = new Size(132, 32);
            txtValorPendente.TabIndex = 22;
            txtValorPendente.Text = "R$ ";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(cbPorcentagens);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(txtValorTotal);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(txtValorPago);
            groupBox3.Controls.Add(txtValorPendente);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label11);
            groupBox3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(339, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(274, 223);
            groupBox3.TabIndex = 18;
            groupBox3.TabStop = false;
            groupBox3.Text = "Valores";
            // 
            // cbPorcentagens
            // 
            cbPorcentagens.Enabled = false;
            cbPorcentagens.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            cbPorcentagens.FormattingEnabled = true;
            cbPorcentagens.Items.AddRange(new object[] { "40%", "45%", "50%", "100%" });
            cbPorcentagens.Location = new Point(115, 88);
            cbPorcentagens.Margin = new Padding(3, 4, 3, 4);
            cbPorcentagens.Name = "cbPorcentagens";
            cbPorcentagens.Size = new Size(132, 33);
            cbPorcentagens.TabIndex = 19;
            cbPorcentagens.SelectedValueChanged += cbPorcentagens_SelectedValueChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(26, 92);
            label13.Name = "label13";
            label13.Size = new Size(83, 25);
            label13.TabIndex = 23;
            label13.Text = "% Paga :";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtId);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(cbTema);
            groupBox2.Controls.Add(cbCliente);
            groupBox2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(23, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(288, 223);
            groupBox2.TabIndex = 24;
            groupBox2.TabStop = false;
            groupBox2.Text = "Informações";
            // 
            // TelaAluguelForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(636, 542);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(Localização);
            Controls.Add(groupBox1);
            Controls.Add(btnGravar);
            Controls.Add(btnCancelar);
            Margin = new Padding(3, 4, 3, 4);
            Name = "TelaAluguelForm";
            ShowIcon = false;
            Text = "Tela Aluguel";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            Localização.ResumeLayout(false);
            Localização.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtId;
        private Label label2;
        private Button btnGravar;
        private Button btnCancelar;
        private Label label1;
        private Label label3;
        private ComboBox cbCliente;
        private ComboBox cbTema;
        private GroupBox groupBox1;
        private DateTimePicker dtHorarioFinal;
        private DateTimePicker dtHorarioInicio;
        private DateTimePicker dtData;
        private Label label6;
        private Label label5;
        private Label label4;
        private GroupBox Localização;
        private TextBox txtNumero;
        private TextBox txtRua;
        private Label label9;
        private Label label8;
        private Label label7;
        private MaskedTextBox txtCep;
        private Label label10;
        private TextBox txtValorPago;
        private Label label11;
        private TextBox txtValorTotal;
        private Label label12;
        private TextBox txtValorPendente;
        private GroupBox groupBox3;
        private ComboBox cbPorcentagens;
        private Label label13;
        private GroupBox groupBox2;
        private Label label14;
    }
}