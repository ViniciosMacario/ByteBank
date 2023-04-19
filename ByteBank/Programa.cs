using ByteBank.Contas;
using ByteBank.Titular;


//O método construtor é invocado quando damos um new no objeto. No "Program.cs" ao dar um new ContaCorrente() estamos invocando o método construtor que vai construir na memória dos computadores um objeto do tipo conta corrente.
ContaCorrente conta5 = new ContaCorrente(283, "1234-X");
Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

ContaCorrente conta6 = new ContaCorrente(284, "9874-Z");
Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

ContaCorrente conta7 = new ContaCorrente(285, "1111-Z");
Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

