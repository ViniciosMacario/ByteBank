using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class ContaCorrente
    {
        public int numero_agencia;
        public string conta;
        public string titular;
        public double saldo;


        //Criando um método para adicionar novos valores no saldo final.
        public void Depositar(double valor)
        {
            this.saldo += valor;
        }
        public void Sacar(double valor)
        {
            //Verificando se o usuário possui saldo suficiente para fazer o saque
            if(saldo - valor <= 0)
            {
                Console.WriteLine("Saldo insuficiente!");
            }
            this.saldo -= valor;
            Console.WriteLine("Saque efetuado com Sucesso!");
        }

        public void Transferir(double valor, ContaCorrente destino)
        {
            if(this.saldo - valor <= 0)
            {
                Console.WriteLine("Saldo insuficiente!");
            }
            else
            {
                this.Sacar(valor);
                Console.WriteLine($"Transferência de R$ {valor} feita com Sucesso!");

                destino.Depositar(valor);
            }
        }
    }
}


