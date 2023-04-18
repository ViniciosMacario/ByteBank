//Impotando class
using ByteBank;


//"ContaCorrente" é a tipagem da Class
//New é o operador que nos permite criar um novo objeto e chamar a class.
//ContaCorrente contaDoAndre = new ContaCorrente();

//Criando um objeto "user"
//contaDoAndre.titular = "Vinicios";
//contaDoAndre.saldo = 20000;
//contaDoAndre.conta = "1010-x";
//contaDoAndre.numero_agencia = 10;

//Chamando o método Depositar
//contaDoUsuario.Depositar(10000);
//Console.WriteLine($"Saldo atual : R$ {contaDoUsuario.saldo}");

//Chamando o método Sacar
//contaDoUsuario.Sacar(5000);
//Console.WriteLine($"Saldo atual : R$ {contaDoUsuario.saldo}");

//ContaCorrente contaDaIsabela = new ContaCorrente();
//  contaDaIsabela.titular = "Isabela Carvalho Demarchi";
//  contaDaIsabela.saldo = 15;
//  contaDaIsabela.conta = "1025-x";
//  contaDaIsabela.numero_agencia = 101011;


//Chamando o método Transferir
//contaDoAndre.Transferir(15000, contaDaIsabela);
//Console.WriteLine($"Saldo atual : R$ {contaDoAndre.saldo}");

//Console.WriteLine($"Saldo atual da {contaDaIsabela.titular} : R$ {contaDaIsabela.saldo}");

// Definindo valor padrão no C# diretamente na class
//ContaCorrente contaCorrentePedro = new ContaCorrente();
//// O valor padrão para tipos numéricos é 0, valor padrão para string é nulo e para o booleano o valor padrão é false.
//    contaCorrentePedro.titular = "Pedro Silva";
//    Console.WriteLine(contaCorrentePedro.titular); //
//    Console.WriteLine(contaCorrentePedro.conta); // 0
//    Console.WriteLine(contaCorrentePedro.saldo); // 0
//    Console.WriteLine(contaCorrentePedro.numero_agencia); //

////tipagem por valor 
//double valor = 300;
//double valor2 = valor;

////Então, o valor2 aponta para o mesmo espaço de memória que tem o conteúdo de 300? Não, não é isso. Aqui estamos trabalhando com tipagem por valor, e quando atribuímos valor para valor2 é criada uma cópia do conteúdo da variável valor para o conteúdo de valor2

//Console.WriteLine(valor == valor2);
//Console.WriteLine(valor);
//Console.WriteLine(valor2);

// Tipagem por referência.
//Ao fazer o new ContaCorrente() estamos criando um novo objeto na memória do computador.
//para podermos utilizar esse objeto, acessar seus campos, invocar seus métodos e comportamentos, precisamos de uma referência. Para isso criamos uma variável do tipo da classe ContaCorrente que armazena uma referência para o nosso objeto, como na construção:
//ContaCorrente conta = new ContaCorrente();

//ojb1
//  endereço na memória: 2001:DB8:AD:F:0:0:0:1
ContaCorrente contaDaIsabela = new ContaCorrente();
contaDaIsabela.titular = "Isabela Carvalho Demarchi";
contaDaIsabela.saldo = 15;
contaDaIsabela.conta = "1025-x";
contaDaIsabela.numero_agencia = 101011;

//obj2
//endereço na memória: 2001:DD9:AD:F:0:0:0:8

ContaCorrente contaDaIsabelai2 = new ContaCorrente();
contaDaIsabelai2.titular = "Isabela Carvalho Demarchi";
contaDaIsabelai2.saldo = 15;
contaDaIsabelai2.conta = "1025-x";
contaDaIsabelai2.numero_agencia = 101011;


//Por que quando comparamos dois objetos que têm os mesmos valores nos campos retornar false?
Console.WriteLine(contaDaIsabela == contaDaIsabelai2);

/* 
uando dou um new no objeto, estou criando um novo objeto na memória do computador. E esse objeto tem um endereçamento único, então a conta1, por exemplo, o endereço começa com 2001 mas termina com 0:1 e o da conta2 também começa com 2001 mas termina com 0:8.
Então, são dois endereçamentos diferentes. Quando faço aquela comparação entre a contaDoAndre e a contaDoAndre2, estou comparando o endereçamento de memória. O endereçamento é diferente, por isso retorna false.
Ou seja, quando comparamos dois objetos estamos comparando os endereçamentos de memória deles, não só os valores de seus campos.*/

contaDaIsabela = contaDaIsabelai2;
Console.WriteLine(contaDaIsabela == contaDaIsabelai2);

/* 
Agora deu true, está apontando para o mesmo endereço de memória.
Esse é o funcionamento do tipo por valor e do tipo por referência. Com tipagem por valor trabalhamos com tipos primitivos (int, double, float, char e struct); com tipagem por referência trabalhamos com estruturas mais complexas, com objetos, com classes.
 */

contaDaIsabela.DadosDoUsuario();