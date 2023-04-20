
using ByteBank.Titular; // Namespace é a maneira que o .NET utiliza para organizar suas bibliotecas e ajuda na composição do nome de uma classe. Para utilizar uma classe de determinado namespace, temos duas maneiras básicas: usar a diretiva using ou o nome completo qualificado.
using System.Runtime.ConstrainedExecution;

namespace ByteBank.Contas
{
    public class ContaCorrente
    {
        private double saldo = 100; // definindo um valor padrão igual a 100

        // Essa sintaxa é o que chamamos de Propriedade autoImplementada.
            //Campos da class ContaCorrente
        public string Conta { get; set; } // Por baixo dos panos, o assessor get irá retornar o conteúdo de um campo de uma classe.
        public string Titular { get; set; }
        public int numeroDaAgencia;
        public int NumeroAgencia
        {
            get { return this.numeroDaAgencia; }
            private set { if (value > 0) this.numeroDaAgencia = value;} 
        }
        //Quando uma propriedade é estática ela passa a ser da classe e não mais dos objetos criados da parte dela.

        //o membro estático é uma propriedade relacionada à classe e não ao objeto. Os objetos conseguem acessar essa propriedade porque faz parte do contexto da classe, por isso o construtor conseguiu fazer o incremento dela.

        //Membros estáticos, no momento da execução do programa, são carregados diretamente para a memória, por isso devem ser usados com bastante cautela para não ocuparmos a memória do computador com informações desnecessárias para a resolução do problema.
        public static int TotalDeContasCriadas { get; private set; }
        //Método construtor principal da página
        public ContaCorrente(int numeroDaAgencia, string numeroDaConta)
        {
            NumeroAgencia = numeroDaAgencia;
            Conta = numeroDaConta;
            TotalDeContasCriadas += 1;
        }


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
            Console.WriteLine("Títular: " + Titular);
            //Console.WriteLine("Número da agência: " + numero_agencia);
            //Console.WriteLine("Número da conta: " + conta);
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

/* 0
 
 Métodos construtores são chamados quando criamos um objeto usando o operador new. Por meio deles, podemos informar os valores dos campos no momento da criação do objeto;
Construtores explícitos são definidos por quem desenvolve e construtores implícitos são criados pelo próprio .NET quando não definimos explicitamente;
A palavra reservada static é utilizada para definir um campo ou propriedade como membro de uma classe. Assim conseguimos compartilhar informações com todos os objetos de uma classe.
 */