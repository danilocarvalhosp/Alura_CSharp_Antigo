﻿using ByteBank2;
using ByteBank2.Funcionarios;


internal class Program
{
    static void Main(string [] args)
    {
        CalcularBonificacao();

        Console.ReadKey();
    }

    public static void CalcularBonificacao()
    {
        GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

        Funcionario pedro = new Designer("833.222.048-39");
        pedro.Nome = "Pedro";

        Funcionario roberta = new Diretor("159.753.398-04");
        pedro.Nome = "Roberta";

        Auxiliar igor = new Auxiliar("981.198.778-53");
        igor.Nome = "Igor";

        GerenteDeContas camila = new GerenteDeContas("326.985.628-89");
        camila.Nome = "Camila";

        Desenvolvedor guilherme = new Desenvolvedor("456.175.468-20");
        guilherme.Nome = "Guilherme";

        gerenciadorBonificacao.Registrar(pedro);
        gerenciadorBonificacao.Registrar(roberta);
        gerenciadorBonificacao.Registrar(igor);
        gerenciadorBonificacao.Registrar(camila);
        gerenciadorBonificacao.Registrar(guilherme);

        Console.WriteLine($"Total de bonificações do mês: {gerenciadorBonificacao.GetTotalBonificacao()}");
    }

}