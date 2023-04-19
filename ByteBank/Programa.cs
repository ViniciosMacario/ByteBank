using ByteBank.Contas;
using ByteBank.Titular;

ContaCorrente conta3= new();
conta3.Conta = "1011-H";
conta3.SetSaldo(250);

Console.WriteLine(conta3.GetSaldo());
Console.WriteLine(conta3.Conta);