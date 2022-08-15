using _07___ByteBank;

Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

ContaCorrente conta = new ContaCorrente(867, 86712540);
Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

Console.WriteLine(conta.Agencia);
Console.WriteLine(conta.Numero);

ContaCorrente contaDaGabriela = new ContaCorrente(867, 86745820);
Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

Console.ReadKey();
