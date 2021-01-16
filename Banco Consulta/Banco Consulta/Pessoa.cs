using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Banco_Consulta
{
    public class Pessoa
    {
        private int[] numeros = {0, 1, 2, 3 , 4, 5, 6, 7, 8, 9};
        private string nome;
        private int idade;
        private string dataDeNascimento;
        private int dia;
        private int mes;
        private int ano;
        private int rg;
        private int cep;
        private int nPessoa;

        public Pessoa(string Nome, int Idade, int RG, int CEP, int NPessoa) 
        {
            nome = Nome;
            idade = Idade;
            rg = RG;
            cep = CEP;
            nPessoa = NPessoa;
        }


        public int NPessoas 
        {
            get { return this.nPessoa; }
            set { this.nPessoa = value; }
        }


        public string Nome 
        {
            get { return this.nome; }
            set { this.nome = value;}
        }

        public int Idade
        {
            get { return this.idade; }
            set { this.idade = value; }
        }

        public string DataNascimento
        {
            get { return dataDeNascimento ; }
            set { this.dataDeNascimento = dia + "/" + mes + "/" + ano;}
        }

        public int DiaNasc
        {
            get { return this.dia; }
            set { this.dia = value; }
        }

        public int MesNasc
        {
            get { return this.mes; }
            set { this.mes = value; }
        }

        public int AnoNasc
        {
            get { return this.ano; }
            set { this.ano = value; }
        }

        public int Rg
        {
            get { return this.rg; }
            set {
                int x = 0;

                for (int i = 0; i < numeros.Length; i++)
                {
                    if (value.ToString()[x] == numeros[i] )
                    {
                        if(x <= 9)
                        {
                        rg = rg + Convert.ToInt32(value.ToString()[x]);
                        x++;
                        }
                        else
                        {
                            break;
                        }

                    }
                                        
                }
                 
            }
        }

        public int Cep
        {
            get { return this.cep; }
            set
            {
                int x = 0;

                for (int i = 0; i < numeros.Length; i++)
                {
                    if (value.ToString()[x] == numeros[i])
                    {
                        if (x <= 8)
                        {
                            cep = cep + Convert.ToInt32(value.ToString()[x]);
                            x++;
                        }
                        else
                        {
                            break;
                        }

                    }

                }

            }

        }



    }
}
