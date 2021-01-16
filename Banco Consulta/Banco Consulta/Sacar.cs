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
    public partial class Sacar : Form
    {
        Conta x;

        public Sacar()
        {
            InitializeComponent();
        }

        private void Sacar_Load(object sender, EventArgs e)
        {
            txtValorASerRetirado.Visible = false;
            txtValorASerRetirado.Enabled = false;
            btnSacar.Enabled = false;
            btnSacar.Visible = false;
            pictureBox2.Visible = false;
            lblNome.Text = "";
            lblSaldo.Text = "";
            lblValorAhSacar.Text = "";
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (txtNConta.Text.Length == 4)
            {
                x = BancoDeDados.GetConta(Convert.ToInt32(txtNConta.Text));
                label1.Text = "";
                btnConfirmar.Visible = false;
                btnConfirmar.Enabled = false;
                txtNConta.Visible = false;
                txtNConta.Enabled = false;
                btnSacar.Enabled = true;
                btnSacar.Visible = true;
                txtValorASerRetirado.Visible = true;
                txtValorASerRetirado.Enabled = true;
                lblValorAhSacar.Text = "Valor a ser sacado";

                lblNome.Text = "Nome: " + x.NovaPessoa.Nome;
                lblSaldo.Text = "Saldo: " + Convert.ToString(x.Saldo);
            }
            else
            {
                MessageBox.Show("Informe uma conta válida.");
            }

           
            

        }

        private void btnSacar_Click(object sender, EventArgs e)
        {

            if (lblNome.Text == "Nome: Invalida")
            {
                MessageBox.Show("Essa conta não é válida.");
            }

            else
            {
                int i = 0;

                i = Convert.ToInt32(txtValorASerRetirado.Text);

                if (x.Saldo - i >= 0)
                {
                    x.Saldo -= i;
                    MessageBox.Show("Saque concluido");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Você não possui o valor que deseja sacar.");
                }
            }
            
        }

        private void txtNConta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 )
            {
                e.Handled = true;
            }
        }

        private void txtValorASerRetirado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

    }
}
