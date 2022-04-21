using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Banco_GFB
{
    public class Conta
    {
        private string nome{get; set;}
        private long numeroConta{get; set;}
        private Agencias agencias{get; set;}
        private TipoConta tipoConta{get; set;}
        private double saldo{get; set;}
        private double credito{get; set;}

        public Conta(string nome, long numeroConta, Agencias agencias,
            TipoConta tipoConta, double saldo, double credito){

            this.nome = nome;
            this.numeroConta = numeroConta;
            this.agencias = agencias;
            this.tipoConta = tipoConta;
            this.saldo = saldo;
            this.credito = credito;    
        }
        
    }

   
}