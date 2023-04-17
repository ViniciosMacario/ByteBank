using ByteBank;

//precisamos definir o tipo do objeto no caso é conta corrente
//new, que é o operador que nos permite criar um novo objeto
ContaCorrente contaDoUsuario = new ContaCorrente();
contaDoUsuario.titular = "Vinicios";
contaDoUsuario.numero_agencia = 10;
contaDoUsuario.saldo = 2000;
contaDoUsuario.conta = "1010x";

Console.WriteLine($"Saldo da Conta do {contaDoUsuario.titular} = R$ {contaDoUsuario.saldo}");
contaDoUsuario.Depositar(150);
Console.WriteLine(contaDoUsuario.saldo);

contaDoUsuario.Sacar(50);
Console.WriteLine(contaDoUsuario.saldo);