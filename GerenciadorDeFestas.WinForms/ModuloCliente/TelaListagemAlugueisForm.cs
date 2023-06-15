using GerenciadorDeFestas.Dominio.ModuloCliente;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorDeFestas.WinForms.ModuloCliente
{
    public partial class TelaListagemAlugueisForm : Form
    {
        public TelaListagemAlugueisForm()
        {
            InitializeComponent();

        }

        public void SetarNome(Cliente clienteSelecionado)
        {
            lblNome.Text = clienteSelecionado.nome;
        }
    }
}
