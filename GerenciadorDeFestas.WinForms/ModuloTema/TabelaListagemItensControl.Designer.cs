namespace GerenciadorDeFestas.WinForms.ModuloTema
{
    partial class TabelaListagemItensControl
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
            lista = new ListBox();
            SuspendLayout();
            // 
            // lista
            // 
            lista.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lista.BorderStyle = BorderStyle.None;
            lista.FormattingEnabled = true;
            lista.ItemHeight = 20;
            lista.Location = new Point(0, 0);
            lista.Name = "lista";
            lista.SelectionMode = SelectionMode.None;
            lista.Size = new Size(706, 420);
            lista.TabIndex = 0;
            // 
            // TabelaListagemItensControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lista);
            Name = "TabelaListagemItensControl";
            Size = new Size(706, 427);
            ResumeLayout(false);
        }

        #endregion

        private ListBox lista;
    }
}
