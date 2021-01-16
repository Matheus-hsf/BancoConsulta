using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Banco_Consulta
{
    public class Conta
    {
        private bool especial;
        private int numero;
        private int saldo;
        private Pessoa pessoa;


        public Conta(bool Especial, int Numero,int Saldo, Pessoa Pessoass)
        {
            especial = Especial;
            numero = Numero;
            saldo = Saldo;
            pessoa = Pessoass;
        }


        public bool Especial 
        {
            get { return especial; }
            set { this.especial = value; }
        }

        public int NumeroConta 
        {
            get { return numero;}
            set { this.numero = value;}
        }

        public int Saldo 
        {
            get { return saldo; }
            set { this.saldo = value; }
        }

        public Pessoa NovaPessoa 
        {
            get { return pessoa; }
            set { this.pessoa = value; }
        }

    }
}
