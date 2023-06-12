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
            txtCliente = new ComboBox();
            txtTema = new ComboBox();
            groupBox1 = new GroupBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtData = new DateTimePicker();
            txtHorarioInicio = new DateTimePicker();
            txtHorarioFinal = new DateTimePicker();
            Localização = new GroupBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            txtCep = new TextBox();
            txtRua = new TextBox();
            txtNumero = new TextBox();
            groupBox1.SuspendLayout();
            Localização.SuspendLayout();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Location = new Point(552, 34);
            txtId.Name = "txtId";
            txtId.Size = new Size(28, 23);
            txtId.TabIndex = 10;
            txtId.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(512, 37);
            label2.Name = "label2";
            label2.Size = new Size(20, 15);
            label2.TabIndex = 9;
            label2.Text = "Id:";
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(398, 384);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(88, 41);
            btnGravar.TabIndex = 8;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(492, 384);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(88, 41);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 28);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 11;
            label1.Text = "Cliente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 74);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 12;
            label3.Text = "Tema";
            // 
            // txtCliente
            // 
            txtCliente.FormattingEnabled = true;
            txtCliente.Location = new Point(76, 25);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(136, 23);
            txtCliente.TabIndex = 13;
            // 
            // txtTema
            // 
            txtTema.FormattingEnabled = true;
            txtTema.Location = new Point(76, 66);
            txtTema.Name = "txtTema";
            txtTema.Size = new Size(136, 23);
            txtTema.TabIndex = 14;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtHorarioFinal);
            groupBox1.Controls.Add(txtHorarioInicio);
            groupBox1.Controls.Add(txtData);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(40, 148);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(270, 179);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Data e Hora";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 33);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 0;
            label4.Text = "Data:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 79);
            label5.Name = "label5";
            label5.Size = new Size(68, 15);
            label5.TabIndex = 1;
            label5.Text = "Hora início:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 125);
            label6.Name = "label6";
            label6.Size = new Size(62, 15);
            label6.TabIndex = 2;
            label6.Text = "Hora final:";
            // 
            // txtData
            // 
            txtData.Format = DateTimePickerFormat.Short;
            txtData.Location = new Point(80, 27);
            txtData.Name = "txtData";
            txtData.Size = new Size(124, 23);
            txtData.TabIndex = 6;
            // 
            // txtHorarioInicio
            // 
            txtHorarioInicio.CustomFormat = "HH:mm";
            txtHorarioInicio.Format = DateTimePickerFormat.Custom;
            txtHorarioInicio.Location = new Point(80, 73);
            txtHorarioInicio.Name = "txtHorarioInicio";
            txtHorarioInicio.ShowUpDown = true;
            txtHorarioInicio.Size = new Size(124, 23);
            txtHorarioInicio.TabIndex = 8;
            // 
            // txtHorarioFinal
            // 
            txtHorarioFinal.CustomFormat = "HH:mm";
            txtHorarioFinal.Format = DateTimePickerFormat.Custom;
            txtHorarioFinal.Location = new Point(80, 119);
            txtHorarioFinal.Name = "txtHorarioFinal";
            txtHorarioFinal.ShowUpDown = true;
            txtHorarioFinal.Size = new Size(124, 23);
            txtHorarioFinal.TabIndex = 10;
            // 
            // Localização
            // 
            Localização.Controls.Add(txtNumero);
            Localização.Controls.Add(txtRua);
            Localização.Controls.Add(txtCep);
            Localização.Controls.Add(label9);
            Localização.Controls.Add(label8);
            Localização.Controls.Add(label7);
            Localização.Location = new Point(328, 148);
            Localização.Name = "Localização";
            Localização.Size = new Size(252, 179);
            Localização.TabIndex = 16;
            Localização.TabStop = false;
            Localização.Text = "Localização";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 33);
            label7.Name = "label7";
            label7.Size = new Size(31, 15);
            label7.TabIndex = 0;
            label7.Text = "Cep:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 73);
            label8.Name = "label8";
            label8.Size = new Size(30, 15);
            label8.TabIndex = 1;
            label8.Text = "Rua:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 119);
            label9.Name = "label9";
            label9.Size = new Size(54, 15);
            label9.TabIndex = 2;
            label9.Text = "Número:";
            // 
            // txtCep
            // 
            txtCep.Location = new Point(76, 30);
            txtCep.Name = "txtCep";
            txtCep.Size = new Size(115, 23);
            txtCep.TabIndex = 3;
            // 
            // txtRua
            // 
            txtRua.Location = new Point(76, 78);
            txtRua.Name = "txtRua";
            txtRua.Size = new Size(115, 23);
            txtRua.TabIndex = 4;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(76, 117);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(115, 23);
            txtNumero.TabIndex = 5;
            // 
            // TelaAluguelForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(614, 437);
            Controls.Add(Localização);
            Controls.Add(groupBox1);
            Controls.Add(txtTema);
            Controls.Add(txtCliente);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(txtId);
            Controls.Add(label2);
            Controls.Add(btnGravar);
            Controls.Add(btnCancelar);
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
        private ComboBox txtCliente;
        private ComboBox txtTema;
        private GroupBox groupBox1;
        private DateTimePicker txtHorarioFinal;
        private DateTimePicker txtHorarioInicio;
        private DateTimePicker txtData;
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