﻿using ByteBank2;
using ByteBank2.Funcionarios;

GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

Funcionario carlos = new Funcionario();

carlos.Nome = "Carlos";
carlos.CPF = "546.879.157-20";
carlos.Salario = 2000;
gerenciador.Registrar(carlos);

Diretor roberta = new Diretor();
roberta.Nome = "Roberta";
roberta.CPF = "454.658.148-30";
roberta.Salario = 5000;
gerenciador.Registrar(roberta);

Console.WriteLine(carlos.Nome);
Console.WriteLine(carlos.GetBonificacao());

Console.WriteLine(roberta.Nome);
Console.WriteLine(roberta.GetBonificacao());

Console.WriteLine($"Total de bonificações: {gerenciador.GetTotalBonificacao()}");
