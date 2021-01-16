using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Banco_Consulta
{
    public static class BancoDeDados
    {

        private static Conta Padrao = new Conta(false, 0000, 0, new Pessoa("Invalida", 00, 999999999, 99999999, 0000));

        private static int indexPraRemocao;
        private static List<Pessoa> Pessoas = new List<Pessoa>();
        private static List<Conta> Contas = new List<Conta>();
       
        
      

        public static void AddPessoa(Pessoa x)
        {
            Pessoas.Add(x);
        }

        public static string GetInfo(int NuConta) 
        {
            foreach (Conta c in Contas)
            {
                if (c.NumeroConta == NuConta)
                {
                    return Convert.ToString(c.NumeroConta) + Convert.ToString(c.Saldo) + c.NovaPessoa.Cep + c.NovaPessoa.Rg + c.NovaPessoa.Idade;
                    
                }
            }
            return "";
        }

        public static Pessoa GetPessoa(int NConta)
        {
            foreach (Pessoa x in Pessoas)
            {
                if (x.NPessoas == NConta)
                {
                    return x;
                }
            }
            return Pessoas[0];
        }






        public static void AddConta(Conta x) 
        {
            Contas.Add(x);
        }

        public static string GetNome(int NConta)
        {
            foreach (Conta h in Contas)
            {
                if (h.NumeroConta == NConta)
                {
                    return h.NovaPessoa.Nome;
                }
            }
            return "";
        }


        public static Conta GetConta(int NConta)
        {
            foreach (Conta c in Contas)
	        {
                if (c.NumeroConta == NConta)
	           {
                    return c;
		 
	           }
		 
	        }
            return Padrao;
            
        }

        public static void RemoveConta(int NConta) 
        {
            

            foreach (Conta c in Contas)
            {
                if (c.NumeroConta == NConta)
                {
                    indexPraRemocao = Contas.IndexOf(c);
                }

            }

            Contas.RemoveAt(indexPraRemocao);


        }
       
    }
}
