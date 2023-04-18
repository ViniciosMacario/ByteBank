
// Namespace é a maneira que o .NET utiliza para organizar suas bibliotecas e ajuda na composição do nome de uma classe. Para utilizar uma classe de determinado namespace, temos duas maneiras básicas: usar a diretiva using ou o nome completo qualificado.
using ByteBank.Titular;


namespace ByteBank.Contas
{
    public class ContaCorrente
    {
        //Com isso estamos criando uma referência. Esse campo vai receber, na verdade, uma referência para um objeto do tipo Cliente.
        private User titular;
        private string conta;
        private int numero_agencia;
        
        private double saldo = 100; // definindo um valor padrão igual a 100




        //Funções que a Class ContaCorrente possui.
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
        public void SetSaldo(double valor)
        {
            if (valor < 0) return;
            else this.saldo = valor;
        }
        public double GetSaldo()
        {
           return this.saldo;
        } //Então essa é a recomendação para vocês: definir um campo como privado e acessá-lo por meio de métodos públicos.
    }
    // Criamos os métodos DefinirSaldo() e ObterSaldo(), na classe ContaCorrente, que encapsulam o campo saldo, que agora é privado e não fica mais publicamente exposto. Assim, a manipulação de saldo pode ser feita por meio destes dois métodos. Contudo existe uma convenção muito utilizada para nomear métodos que manipulam campos. Seguindo convenções, substituiremos por sinônimos em inglês, set para "definir" e get para "obter".

    //Vamos aplicar esse conceito no nosso código, alterando o DefinirSaldo() para SetSaldo() e o ObterSaldo() será alterado para GetSaldo().
    //Quando estamos desenvolvendo, não só em C#, é muito comum nos depararmos com nomes de métodos que utilizam o prefixo get e set.
}


