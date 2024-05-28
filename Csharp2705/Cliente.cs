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
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void logar_Click(object sender, EventArgs e)
        {
            if(txtUsuario.Text.Length == 0 || txtSenha.Text.Length == 0)
            {
                MessageBox.Show("Você nã odigitou o usuario ou senha");
            }
            else 
            {
                MessageBox.Show("Entrando no sistema, aguarde...");
            }
        }
    }
}
