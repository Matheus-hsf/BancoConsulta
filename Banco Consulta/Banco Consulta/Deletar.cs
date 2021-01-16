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
    public partial class Deletar : Form
    {

        Conta x;

        public Deletar()
        {
            InitializeComponent();
        }

        private void Deletar_Load(object sender, EventArgs e)
        {
            lblNome.Text = "";
            lblRG.Text = "";
            lblCep.Text = "";
            lblSaldo.Text = "";
            btnDeletar.Enabled = false;
            btnDeletar.Visible = false;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != "" && textBox1.Text.Length == 4 )
            {
                x = BancoDeDados.GetConta(Convert.ToInt32(textBox1.Text)); 
                

                button1.Enabled = false;
                button1.Visible = false;

                lblNome.Text = "Nome: " + x.NovaPessoa.Nome;
                lblRG.Text = "RG: " + Convert.ToString(x.NovaPessoa.Rg)[0] + Convert.ToString(x.NovaPessoa.Rg)[1] + "." + Convert.ToString(x.NovaPessoa.Rg)[2] + Convert.ToString(x.NovaPessoa.Rg)[3] + Convert.ToString(x.NovaPessoa.Rg)[4] + "." + Convert.ToString(x.NovaPessoa.Rg)[5] + Convert.ToString(x.NovaPessoa.Rg)[6] + Convert.ToString(x.NovaPessoa.Rg)[7] + "-" + Convert.ToString(x.NovaPessoa.Rg)[8];
                lblCep.Text = "CEP: " + Convert.ToString(x.NovaPessoa.Cep)[0] + Convert.ToString(x.NovaPessoa.Cep)[1] + Convert.ToString(x.NovaPessoa.Cep)[2] + Convert.ToString(x.NovaPessoa.Cep)[3] + Convert.ToString(x.NovaPessoa.Cep)[4] + "-" + Convert.ToString(x.NovaPessoa.Cep)[5] + Convert.ToString(x.NovaPessoa.Cep)[6] + Convert.ToString(x.NovaPessoa.Cep)[7];
                lblSaldo.Text = "Saldo: " + Convert.ToString(x.Saldo);
                textBox1.ReadOnly = true;

                btnDeletar.Enabled = true;
                btnDeletar.Visible = true;
            }
            else 
            {
                MessageBox.Show("Informe o número da sua conta.");
            }

        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (lblNome.Text == "Nome: Invalida")
            {
                MessageBox.Show("Conta inexistente.");
            }
            else
            {
                BancoDeDados.RemoveConta(x.NumeroConta);
                this.Close();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
    }
}
