using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.formularios.Produto;
using System.Windows.Forms;

namespace WindowsFormsApp1.formularios.Inicial
{
    public partial class fmnTelaPrincipal : Form
    {
        public fmnTelaPrincipal()
        {
            InitializeComponent();
        }

        private void fmnTelaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            var tela = new fmnListaProdutos();
            tela.ShowDialog();
        }
    }
}
