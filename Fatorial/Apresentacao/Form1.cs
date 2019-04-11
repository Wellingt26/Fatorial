using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fatorial
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Modelo.Controle controle = new Modelo.Controle(txbNumero.Text);
            if (Modelo.Estaticos.mensagem.Equals(""))
            {
                lblResposta.Text = controle.numero;
            }
            else
            {
                MessageBox.Show(Modelo.Estaticos.mensagem);
            }
        }
    }
}
