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
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            Localização.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtId.Location = new Point(87, 36);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(136, 27);
            txtId.TabIndex = 10;
            txtId.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(47, 39);
            label2.Name = "label2";
            label2.Size = new Size(31, 20);
            label2.TabIndex = 9;
            label2.Text = "ID :";
            // 
            // btnGravar
            // 
            btnGravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnGravar.Location = new Point(342, 302);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(88, 41);
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
            btnCancelar.Location = new Point(436, 302);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(88, 41);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(11, 82);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 11;
            label1.Text = "Cliente :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(24, 125);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 12;
            label3.Text = "Tema :";
            // 
            // cbCliente
            // 
            cbCliente.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            cbCliente.FormattingEnabled = true;
            cbCliente.Location = new Point(87, 79);
            cbCliente.Name = "cbCliente";
            cbCliente.Size = new Size(136, 28);
            cbCliente.TabIndex = 13;
            //cbCliente.SelectedValueChanged += cbCliente_SelectedValueChanged;
            // 
            // cbTema
            // 
            cbTema.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            cbTema.FormattingEnabled = true;
            cbTema.Location = new Point(87, 122);
            cbTema.Name = "cbTema";
            cbTema.Size = new Size(136, 28);
            cbTema.TabIndex = 14;
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
            groupBox1.Location = new Point(20, 181);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(252, 164);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Data e Hora";
            // 
            // dtHorarioFinal
            // 
            dtHorarioFinal.CustomFormat = "HH:mm";
            dtHorarioFinal.Format = DateTimePickerFormat.Custom;
            dtHorarioFinal.Location = new Point(87, 124);
            dtHorarioFinal.Name = "dtHorarioFinal";
            dtHorarioFinal.ShowUpDown = true;
            dtHorarioFinal.Size = new Size(136, 27);
            dtHorarioFinal.TabIndex = 10;
            dtHorarioFinal.Value = new DateTime(2023, 6, 13, 18, 0, 0, 0);
            // 
            // dtHorarioInicio
            // 
            dtHorarioInicio.CustomFormat = "HH:mm";
            dtHorarioInicio.Format = DateTimePickerFormat.Custom;
            dtHorarioInicio.Location = new Point(87, 81);
            dtHorarioInicio.Name = "dtHorarioInicio";
            dtHorarioInicio.ShowUpDown = true;
            dtHorarioInicio.Size = new Size(136, 27);
            dtHorarioInicio.TabIndex = 8;
            dtHorarioInicio.Value = new DateTime(2023, 6, 13, 13, 0, 0, 0);
            // 
            // dtData
            // 
            dtData.Format = DateTimePickerFormat.Short;
            dtData.Location = new Point(87, 38);
            dtData.Name = "dtData";
            dtData.Size = new Size(136, 27);
            dtData.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(37, 127);
            label6.Name = "label6";
            label6.Size = new Size(40, 20);
            label6.TabIndex = 2;
            label6.Text = "Fim :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 84);
            label5.Name = "label5";
            label5.Size = new Size(52, 20);
            label5.TabIndex = 1;
            label5.Text = "Início :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 41);
            label4.Name = "label4";
            label4.Size = new Size(48, 20);
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
            Localização.Location = new Point(293, 12);
            Localização.Name = "Localização";
            Localização.Size = new Size(240, 164);
            Localização.TabIndex = 16;
            Localização.TabStop = false;
            Localização.Text = "Localização";
            // 
            // txtCep
            // 
            txtCep.Location = new Point(102, 38);
            txtCep.Margin = new Padding(3, 2, 3, 2);
            txtCep.Mask = "00000-000";
            txtCep.Name = "txtCep";
            txtCep.Size = new Size(115, 27);
            txtCep.TabIndex = 6;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(102, 124);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(115, 27);
            txtNumero.TabIndex = 5;
            // 
            // txtRua
            // 
            txtRua.Location = new Point(102, 81);
            txtRua.Name = "txtRua";
            txtRua.Size = new Size(115, 27);
            txtRua.TabIndex = 4;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(18, 127);
            label14.Name = "label14";
            label14.Size = new Size(70, 20);
            label14.TabIndex = 2;
            label14.Text = "Número :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(18, 124);
            label9.Name = "label9";
            label9.Size = new Size(70, 20);
            label9.TabIndex = 2;
            label9.Text = "Número :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(50, 84);
            label8.Name = "label8";
            label8.Size = new Size(41, 20);
            label8.TabIndex = 1;
            label8.Text = "Rua :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(49, 41);
            label7.Name = "label7";
            label7.Size = new Size(41, 20);
            label7.TabIndex = 0;
            label7.Text = "CEP :";
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
            groupBox2.Location = new Point(20, 9);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(252, 167);
            groupBox2.TabIndex = 24;
            groupBox2.TabStop = false;
            groupBox2.Text = "Informações";
            // 
            // TelaAluguelForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(545, 366);
            Controls.Add(groupBox2);
            Controls.Add(Localização);
            Controls.Add(groupBox1);
            Controls.Add(btnGravar);
            Controls.Add(btnCancelar);
            Name = "TelaAluguelForm";
            ShowIcon = false;
            Text = "Tela Aluguel";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            Localização.ResumeLayout(false);
            Localização.PerformLayout();
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
        private GroupBox groupBox2;
        private Label label14;
    }
}