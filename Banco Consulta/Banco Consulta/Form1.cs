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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            CriarConta nConta = new CriarConta();
            nConta.Show();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            Consultar consu = new Consultar();
            consu.Show();
        }

        private void btnDeposito_Click(object sender, EventArgs e)
        {
            Deposito dep = new Deposito();
            dep.Show();
        }

        private void btnSaque_Click(object sender, EventArgs e)
        {
            Sacar sac = new Sacar();
            sac.Show();
        }

        private void btnTransferencia_Click(object sender, EventArgs e)
        {
            Transferencia tran = new Transferencia();
            tran.Show();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            Deletar del = new Deletar();
            del.Show();
        }
    }
}
