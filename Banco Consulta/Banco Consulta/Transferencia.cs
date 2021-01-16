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
    public partial class Transferencia : Form
    {
        Conta x;
        Conta y;

        public Transferencia()
        {
            InitializeComponent();
        }

        private void Transferencia_Load(object sender, EventArgs e)
        {
            lblNome1.Text = "";
            lblNome2.Text = "";
            lblSaldo1.Text = "";
            lblSaldo2.Text = "";
        }

        private void btnC1_Click(object sender, EventArgs e)
        {
            if (txtConta1.Text.Length == 4)
            {
                btnC1.Visible = false;
                btnC1.Enabled = false;

                txtConta1.ReadOnly = true;
                x = BancoDeDados.GetConta(Convert.ToInt32(txtConta1.Text));
                lblNome1.Text = "Nome: " + x.NovaPessoa.Nome;
                lblSaldo1.Text = "Saldo: " + Convert.ToString(x.Saldo);
            }
            else
            {
                MessageBox.Show("Informe uma conta válida.");
            }

           

        }

        private void btnC2_Click(object sender, EventArgs e)
        {
            if (txtConta2.Text.Length == 4)
            {
                btnC2.Visible = false;
                btnC2.Enabled = false;

                txtConta2.ReadOnly = true;
                y = BancoDeDados.GetConta(Convert.ToInt32(txtConta2.Text));
                lblNome2.Text = "Nome: " + y.NovaPessoa.Nome;
                lblSaldo2.Text = "Saldo: " + Convert.ToString(y.Saldo);
               
            }
            else
            {
                MessageBox.Show("Informe uma conta válida.");
            }

            
        }

        private void btnTransf_Click(object sender, EventArgs e)
        {
            if (lblNome1.Text == "" || lblNome2.Text == "" || lblNome1.Text == "Nome: Invalida" || lblNome2.Text == "Nome: Invalida")
            {
                MessageBox.Show("Informe todas as contas, e verifique se são válidas.");
            }
            else
            {
                int i;
                i = Convert.ToInt32(txtValor.Text);

                if (x.Saldo - i >= 0)
                {
                    x.Saldo -= i;
                    y.Saldo += i;
                    MessageBox.Show("Transferencia concluida.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Você não possui o valor que deseja transferir.");
                }
            }
           
        }

        private void txtConta1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtConta2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
    }
}
