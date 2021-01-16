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
    public partial class Deposito : Form
    {
        Conta x;

        public Deposito()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (txtNCONTA.Text.Length == 4)
            {
                x = BancoDeDados.GetConta(Convert.ToInt32(txtNCONTA.Text));

                txtNCONTA.ReadOnly = true;
                lblNome.Text = x.NovaPessoa.Nome;
                lblNNome.Text = x.NovaPessoa.Nome;
                lblSaldo.Text = Convert.ToString(x.Saldo);
                txtVlrDeposito.Visible = false;
                txtVlrDeposito.Enabled = false;
                btnConfirmar.Visible = false;
                btnConfirmar.Enabled = false;
                btnDepositar.Visible = true;
                btnDepositar.Enabled = true;
                txtVlrDeposito.Visible = true;
                txtVlrDeposito.Enabled = true;
                label2.Text = "Valor a ser depositado";
            }
            else
            {
                MessageBox.Show("Informe uma conta válida.");
            }
           
            
        }

        private void Deposito_Load(object sender, EventArgs e)
        {
            btnDepositar.Visible = false;
            btnDepositar.Enabled = false;
            label2.Text = "";
            txtVlrDeposito.Visible = false;
            txtVlrDeposito.Enabled = false;
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            if (txtNCONTA.Text.Length == 4 && txtVlrDeposito.Text != "" && lblNome.Text != "Invalida")
            {
                btnDepositar.Enabled = false;
                x.Saldo += Convert.ToInt32(txtVlrDeposito.Text);
                lblNSaldo.Text = Convert.ToString(x.Saldo);
           
            }
            else
            {
                MessageBox.Show("Informe um valor ou uma conta válida.");
            }
            }

        private void txtNCONTA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtVlrDeposito_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
    }
}
