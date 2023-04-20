using ByteBank.Contas;

namespace SistemaBancario
{
    class Programa
    {
        static void Main()
        {
            //Estamos criando nossas variáveis para armarzenar o valor digitado pelo usário
            string Nome;
            int Idade;
            string Cpf;

            Console.WriteLine(" Bem Vindo ao ByteBank");
            Console.WriteLine(" Vamos criar uma conta, por gentileza, os seguintes dados são necessários:");

            Console.Write(" - Name : ");
            Nome = Console.ReadLine();

            Console.Write(" - Age  : ");
            Idade = int.Parse(Console.ReadLine());

            Console.Write(" - CPF  : ");
            Cpf = Console.ReadLine();

            new CreateAccount(
                Nome: Nome,
                Idade: Idade,
                Cpf: Cpf
            );

        }

    }
}