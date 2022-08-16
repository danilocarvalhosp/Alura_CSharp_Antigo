using ByteBank2;
using ByteBank2.Funcionarios;

GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

Funcionario carlos = new Funcionario(2000, "546.879.157-20");

carlos.Nome = "Carlos";
gerenciador.Registrar(carlos);

carlos.AumentarSalario();

Console.WriteLine("Novo salário do carlos " + carlos.Salario);

Console.WriteLine(Funcionario.TotalDeFuncionarios);

Diretor roberta = new Diretor("454.658.148-30");
roberta.Nome = "Roberta";

Console.WriteLine(Funcionario.TotalDeFuncionarios);

roberta.AumentarSalario();
Console.WriteLine("Novo salário de roberta " + roberta.Salario);

Funcionario robertaTeste = roberta;

Console.WriteLine($"Bonificação de uma referência de Diretor: {roberta.GetBonificacao()}");
Console.WriteLine($"Bonificação de uma referência de Funcionário: {robertaTeste.GetBonificacao()}");

gerenciador.Registrar(roberta);

Console.WriteLine(carlos.Nome);
Console.WriteLine(carlos.GetBonificacao());

Console.WriteLine(roberta.Nome);
Console.WriteLine(roberta.GetBonificacao());

Console.WriteLine($"Total de bonificações: {gerenciador.GetTotalBonificacao()}");
