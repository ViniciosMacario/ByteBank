
// Namespace é a maneira que o .NET utiliza para organizar suas bibliotecas e ajuda na composição do nome de uma classe. Para utilizar uma classe de determinado namespace, temos duas maneiras básicas: usar a diretiva using ou o nome completo qualificado.
using ByteBank.Titular;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Contas
{
    public class ContaCorrente
    {
        //Com isso estamos criando uma referência. Esse campo vai receber, na verdade, uma referência para um objeto do tipo Cliente.
        public User titular;
        public string conta;
        public int numero_agencia;
        // definindo um valor padrão igual a 100
        private double saldo = 100;

        //Criando um método para adicionar novos valores no saldo final.
        public void Depositar(double valor)
        {
            saldo += valor;
        }
        public void Sacar(double valor)
        {
            //Verificando se o usuário possui saldo suficiente para fazer o saque
            if (saldo - valor <= 0)
            {
                Console.WriteLine("Saldo insuficiente!");
            }
            saldo -= valor;
            Console.WriteLine("Saque efetuado com Sucesso!");
        }
        public void Transferir(double valor, ContaCorrente destino)
        {
            if (saldo - valor <= 0)
            {
                Console.WriteLine("Saldo insuficiente!");
            }
            else
            {
                Sacar(valor);
                Console.WriteLine($"Transferência de R$ {valor} feita com Sucesso!");

                destino.Depositar(valor);
            }
        }
        public void DadosDoUsuario()
        {
            Console.WriteLine("Títular: " + titular);
            Console.WriteLine("Número da agência: " + numero_agencia);
            Console.WriteLine("Número da conta: " + conta);
            Console.WriteLine("Saldo atual: " + saldo);

        }
        public void DefinirSaldo(double valor)
        {
            if (valor < 0) return;
            else this.saldo = valor;
        }
        //Criamos uma função pública responsável por acessar o saldo privado e retonar seu valor.
        public double ObterSaldo()
        {
           return this.saldo;
        }
    }
    //encapsulamento 
    // Regex
    //
}


