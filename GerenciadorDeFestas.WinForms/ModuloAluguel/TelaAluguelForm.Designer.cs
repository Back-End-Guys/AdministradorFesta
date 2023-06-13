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
            txtNumero = new TextBox();
            txtRua = new TextBox();
            txtCep = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            groupBox1.SuspendLayout();
            Localização.SuspendLayout();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Location = new Point(126, 33);
            txtId.Margin = new Padding(3, 4, 3, 4);
            txtId.Name = "txtId";
            txtId.Size = new Size(31, 27);
            txtId.TabIndex = 10;
            txtId.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(80, 37);
            label2.Name = "label2";
            label2.Size = new Size(25, 20);
            label2.TabIndex = 9;
            label2.Text = "Id:";
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(444, 426);
            btnGravar.Margin = new Padding(3, 4, 3, 4);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(101, 55);
            btnGravar.TabIndex = 8;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(551, 426);
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
            label1.Location = new Point(58, 80);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 11;
            label1.Text = "Cliente :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(386, 80);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 12;
            label3.Text = "Tema :";
            // 
            // cbCliente
            // 
            cbCliente.FormattingEnabled = true;
            cbCliente.Location = new Point(126, 77);
            cbCliente.Margin = new Padding(3, 4, 3, 4);
            cbCliente.Name = "cbCliente";
            cbCliente.Size = new Size(155, 28);
            cbCliente.TabIndex = 13;
            // 
            // cbTema
            // 
            cbTema.FormattingEnabled = true;
            cbTema.Location = new Point(444, 77);
            cbTema.Margin = new Padding(3, 4, 3, 4);
            cbTema.Name = "cbTema";
            cbTema.Size = new Size(155, 28);
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
            groupBox1.Location = new Point(35, 144);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(309, 239);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Data e Hora";
            // 
            // dtHorarioFinal
            // 
            dtHorarioFinal.CustomFormat = "HH:mm";
            dtHorarioFinal.Format = DateTimePickerFormat.Custom;
            dtHorarioFinal.Location = new Point(120, 163);
            dtHorarioFinal.Margin = new Padding(3, 4, 3, 4);
            dtHorarioFinal.Name = "dtHorarioFinal";
            dtHorarioFinal.ShowUpDown = true;
            dtHorarioFinal.Size = new Size(141, 27);
            dtHorarioFinal.TabIndex = 10;
            // 
            // dtHorarioInicio
            // 
            dtHorarioInicio.CustomFormat = "HH:mm";
            dtHorarioInicio.Format = DateTimePickerFormat.Custom;
            dtHorarioInicio.Location = new Point(120, 101);
            dtHorarioInicio.Margin = new Padding(3, 4, 3, 4);
            dtHorarioInicio.Name = "dtHorarioInicio";
            dtHorarioInicio.ShowUpDown = true;
            dtHorarioInicio.Size = new Size(141, 27);
            dtHorarioInicio.TabIndex = 8;
            // 
            // dtData
            // 
            dtData.Format = DateTimePickerFormat.Short;
            dtData.Location = new Point(120, 44);
            dtData.Margin = new Padding(3, 4, 3, 4);
            dtData.Name = "dtData";
            dtData.Size = new Size(141, 27);
            dtData.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 170);
            label6.Name = "label6";
            label6.Size = new Size(78, 20);
            label6.TabIndex = 2;
            label6.Text = "Hora final:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 107);
            label5.Name = "label5";
            label5.Size = new Size(85, 20);
            label5.TabIndex = 1;
            label5.Text = "Hora início:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(61, 49);
            label4.Name = "label4";
            label4.Size = new Size(44, 20);
            label4.TabIndex = 0;
            label4.Text = "Data:";
            // 
            // Localização
            // 
            Localização.Controls.Add(txtNumero);
            Localização.Controls.Add(txtRua);
            Localização.Controls.Add(txtCep);
            Localização.Controls.Add(label9);
            Localização.Controls.Add(label8);
            Localização.Controls.Add(label7);
            Localização.Location = new Point(364, 144);
            Localização.Margin = new Padding(3, 4, 3, 4);
            Localização.Name = "Localização";
            Localização.Padding = new Padding(3, 4, 3, 4);
            Localização.Size = new Size(288, 239);
            Localização.TabIndex = 16;
            Localização.TabStop = false;
            Localização.Text = "Localização";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(120, 162);
            txtNumero.Margin = new Padding(3, 4, 3, 4);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(131, 27);
            txtNumero.TabIndex = 5;
            // 
            // txtRua
            // 
            txtRua.Location = new Point(120, 100);
            txtRua.Margin = new Padding(3, 4, 3, 4);
            txtRua.Name = "txtRua";
            txtRua.Size = new Size(131, 27);
            txtRua.TabIndex = 4;
            // 
            // txtCep
            // 
            txtCep.Location = new Point(120, 46);
            txtCep.Margin = new Padding(3, 4, 3, 4);
            txtCep.Name = "txtCep";
            txtCep.Size = new Size(131, 27);
            txtCep.TabIndex = 3;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(32, 170);
            label9.Name = "label9";
            label9.Size = new Size(66, 20);
            label9.TabIndex = 2;
            label9.Text = "Número:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(60, 110);
            label8.Name = "label8";
            label8.Size = new Size(37, 20);
            label8.TabIndex = 1;
            label8.Text = "Rua:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(60, 53);
            label7.Name = "label7";
            label7.Size = new Size(38, 20);
            label7.TabIndex = 0;
            label7.Text = "Cep:";
            // 
            // TelaAluguelForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(686, 506);
            Controls.Add(Localização);
            Controls.Add(groupBox1);
            Controls.Add(cbTema);
            Controls.Add(cbCliente);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(txtId);
            Controls.Add(label2);
            Controls.Add(btnGravar);
            Controls.Add(btnCancelar);
            Margin = new Padding(3, 4, 3, 4);
            Name = "TelaAluguelForm";
            Text = "TelaAluguelForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            Localização.ResumeLayout(false);
            Localização.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private TextBox txtCep;
        private Label label9;
        private Label label8;
        private Label label7;
    }
}