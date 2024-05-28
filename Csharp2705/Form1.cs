using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp2705
{
    public partial class Exemplo : Form
    {
        public Exemplo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtSalvarExemplo.Text = "texto alterado";
            btnApagarExemplo.Visible = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(txtSalvarExemplo.Text == "")
            {
                MessageBox.Show("Nada para limpar");
            }
            else
            {
                txtSalvarExemplo.Text = null;
                btnApagarExemplo.Visible = false;
            }
        }

        private void Exemplo_Load(object sender, EventArgs e)
        {
            btnApagarExemplo.Visible = false;
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.ShowDialog();
        }
    }
}
