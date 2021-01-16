using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Banco_Consulta
{
    public partial class Consultar : Form
    {
        Conta x;

        public Consultar()
        {
            InitializeComponent();
        }

        private void Consultar_Load(object sender, EventArgs e)
        {
            btnSair.Enabled = false;
            btnSair.Visible = false;
            lblCep.Text = "";
            lblNConta.Text = "";
            lblNome.Text = "";
            lblRG.Text = "";
            lblSaldo.Text = "";
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (txtNumero.Text.Length == 4 )
            {
                x = BancoDeDados.GetConta(Convert.ToInt32(txtNumero.Text));

                btnSair.Enabled = true;
                btnSair.Visible = true;
                lblInforme.Text = "";
                txtNumero.Visible = false;
                txtNumero.Enabled = false;
                btnConfirmar.Enabled = false;
                btnConfirmar.Visible = false;

                lblNome.Text = "Nome: " + x.NovaPessoa.Nome;
                lblRG.Text = "RG: " + Convert.ToString(x.NovaPessoa.Rg)[0] + Convert.ToString(x.NovaPessoa.Rg)[1] + "." + Convert.ToString(x.NovaPessoa.Rg)[2] + Convert.ToString(x.NovaPessoa.Rg)[3] + Convert.ToString(x.NovaPessoa.Rg)[4] + "." + Convert.ToString(x.NovaPessoa.Rg)[5] + Convert.ToString(x.NovaPessoa.Rg)[6] + Convert.ToString(x.NovaPessoa.Rg)[7] + "-" + Convert.ToString(x.NovaPessoa.Rg)[8];
                lblCep.Text = "CEP: " + Convert.ToString(x.NovaPessoa.Cep)[0] + Convert.ToString(x.NovaPessoa.Cep)[1] + Convert.ToString(x.NovaPessoa.Cep)[2] + Convert.ToString(x.NovaPessoa.Cep)[3] + Convert.ToString(x.NovaPessoa.Cep)[4] + "-" + Convert.ToString(x.NovaPessoa.Cep)[5] + Convert.ToString(x.NovaPessoa.Cep)[6] + Convert.ToString(x.NovaPessoa.Cep)[7] ;
                lblNConta.Text = "Número da conta: " + Convert.ToString(x.NumeroConta);
                lblSaldo.Text = "Saldo: " + Convert.ToString(x.Saldo);
            }
            else
            {
                MessageBox.Show("Informe um número válido.");
            }
           

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar !=(char)8)
            {
                e.Handled = true;
            }
        }
    }
}
