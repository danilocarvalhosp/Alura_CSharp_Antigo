using _05___ByteBank;

Cliente gabriela = new Cliente();

gabriela.nome = "Gabriela";
gabriela.profissão = "Desenvolvedora C#";
gabriela.cpf = "434.562.878-20";

ContaCorrente conta = new ContaCorrente();
conta.titular = gabriela;
conta.saldo = 500;
conta.agencia = 563;
conta.numero = 5634527;

conta.titular.nome = "Gabriela Costa";

Console.WriteLine(gabriela.nome);
Console.WriteLine(conta.titular.nome);

Console.ReadKey();
