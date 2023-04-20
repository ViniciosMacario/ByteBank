using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Contas
{
    internal class CreateAccount
    {
        string? Nome;
        int? Idade;
        string? Cpf;

         public CreateAccount(string Nome, string Cpf, int Idade)
        {
            if(Nome.Length > 0 && Cpf.Length == 11 && Idade >= 18)
            {
                Console.WriteLine("<----- Conta criada com Sucesso! -----> ");
            }
            else
            {
                Console.WriteLine("Não foi possivel a Conta!");
            }




        }

    }
}
