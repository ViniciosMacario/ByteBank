//Impotando class
using ByteBank;


//"ContaCorrente" é a tipagem da Class
    //New é o operador que nos permite criar um novo objeto e chamar a class.
ContaCorrente contaDoAndre = new ContaCorrente();

//Criando um objeto "user"
    contaDoAndre.titular = "Vinicios";
    contaDoAndre.saldo = 20000;
    contaDoAndre.conta = "1010-x";
    contaDoAndre.numero_agencia = 10;

//Chamando o método Depositar
//contaDoUsuario.Depositar(10000);
//Console.WriteLine($"Saldo atual : R$ {contaDoUsuario.saldo}");

//Chamando o método Sacar
//contaDoUsuario.Sacar(5000);
//Console.WriteLine($"Saldo atual : R$ {contaDoUsuario.saldo}");

ContaCorrente contaDaIsabela = new ContaCorrente();
  contaDaIsabela.titular = "Isabela Carvalho Demarchi";
  contaDaIsabela.saldo = 15;
  contaDaIsabela.conta = "1025-x";
  contaDaIsabela.numero_agencia = 101011;


//Chamando o método Transferir
contaDoAndre.Transferir(15000, contaDaIsabela);
Console.WriteLine($"Saldo atual : R$ {contaDoAndre.saldo}");

Console.WriteLine($"Saldo atual da {contaDaIsabela.titular} : R$ {contaDaIsabela.saldo}");