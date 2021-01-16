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
    public partial class CriarConta : Form
    {
        public CriarConta()
        {
            InitializeComponent();
        }

        private bool Especiaal = false;
        
        private string nContaa;
        private int[] numeros = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        private Random random = new Random();

        private void txtDia_TextChanged(object sender, EventArgs e)
        {
           
        }

       

        private void CriarConta_Load(object sender, EventArgs e)
        {
            nmcAno.Maximum = DateTime.Now.Year;

            nContaa = nContaa + numeros[random.Next(0, 9)];
            nContaa = nContaa + numeros[random.Next(0, 9)];
            nContaa = nContaa + numeros[random.Next(0, 9)];
            nContaa = nContaa + numeros[random.Next(0, 9)];

            lblNumeroDaCoonta.Text = Convert.ToString(nContaa);
            
        }

        private void txtRG_TextChanged(object sender, EventArgs e)
        {
            if (txtRG.Text.Length < 9 || txtRG.Text.Length > 9)
            {
                lblAlertaRG.Text = "!";
                lblAlertaRG.BackColor = Color.PaleVioletRed;
            }
            if (txtRG.Text.Length == 9)
            {
                lblAlertaRG.Text = "";
                lblAlertaRG.BackColor = Color.Empty;
            }
        }

        private void txtAlerta_TextChanged(object sender, EventArgs e)
        {
            if (txtAlerta.Text.Length < 8 || txtAlerta.Text.Length > 8)
            {
                lblCepAlerta.Text = "!";
                lblCepAlerta.BackColor = Color.PaleVioletRed;
            }
            if (txtAlerta.Text.Length == 8)
            {
                lblCepAlerta.Text = "";
                lblCepAlerta.BackColor = Color.Empty;
            }
        }

        private void Criar_Click(object sender, EventArgs e)
        {
            
            
            if (chkEspecial.Checked == true)
            {
                Especiaal = true;
            }


            if(txtRG.Text.Length == 9 && txtAlerta.Text.Length == 8){

            if (txtNome.Text != "" && txtRG.Text != "" && txtAlerta.Text != "" && txtIdAdE.Text != "" && chkEspecial.Checked == false)
            {
                BancoDeDados.AddPessoa(new Pessoa(txtNome.Text, Convert.ToInt32(txtIdAdE.Text), Int32.Parse(txtRG.Text), Int32.Parse(txtAlerta.Text), Convert.ToInt32(nContaa)));

                BancoDeDados.AddConta(new Conta(Especiaal, Convert.ToInt32(nContaa), 0, BancoDeDados.GetPessoa(Convert.ToInt32(nContaa))));

                MessageBox.Show(BancoDeDados.GetNome(Convert.ToInt32(nContaa)), BancoDeDados.GetInfo(Convert.ToInt32(nContaa)));

                this.Close();
            }

            else if (txtNome.Text != "" && txtRG.Text != "" && txtAlerta.Text != "" && txtIdAdE.Text != "" && chkEspecial.Checked == true)
            {
                BancoDeDados.AddPessoa(new Pessoa(txtNome.Text, Convert.ToInt32(txtIdAdE.Text), Int32.Parse(txtRG.Text), Int32.Parse(txtAlerta.Text), Convert.ToInt32(nContaa)));

                BancoDeDados.AddConta(new Conta(Especiaal, Convert.ToInt32(nContaa), 500, BancoDeDados.GetPessoa(Convert.ToInt32(nContaa))));

                MessageBox.Show(BancoDeDados.GetNome(Convert.ToInt32(nContaa)), BancoDeDados.GetInfo(Convert.ToInt32(nContaa)));

                this.Close();
            }
            else
            {
                MessageBox.Show("Preencha todos os dados");
            }

            }
            else
            {
                MessageBox.Show("Confirme que todos os dados estão preenchidos corretamente.");
            }
            
	
	;





            



        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)8 &&  !char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
               
            } 
        }

        private void txtIdAdE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtRG_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtAlerta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

      
        

        
    }
}
