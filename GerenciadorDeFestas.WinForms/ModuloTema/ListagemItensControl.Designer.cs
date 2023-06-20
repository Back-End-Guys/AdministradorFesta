namespace GerenciadorDeFestas.WinForms.ModuloTema
{
    partial class ListagemItensControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lista = new ListView();
            SuspendLayout();
            // 
            // lista
            // 
            lista.Dock = DockStyle.Fill;
            lista.Location = new Point(0, 0);
            lista.Name = "lista";
            lista.Size = new Size(706, 427);
            lista.TabIndex = 0;
            lista.UseCompatibleStateImageBehavior = false;
            // 
            // ListagemItensControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lista);
            Name = "ListagemItensControl";
            Size = new Size(706, 427);
            ResumeLayout(false);
        }

        #endregion

        private ListView lista;
    }
}
