using _06___ByteBank;

ContaCorrente conta = new ContaCorrente();
Cliente cliente = new Cliente();

cliente.nome = "Guilherme";
cliente.cpf = "485.995.869-78";
cliente.profissão = "Desenvolvedor";

conta.Saldo = -10;
conta.Titular = cliente;

Console.WriteLine(conta.Titular.nome);
Console.WriteLine(conta.Saldo);

Console.ReadKey();

