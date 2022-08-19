using ByteBank2;
using ByteBank2.Funcionarios;
using ByteBank2.Sistema;

internal class Program
{
    static void Main(string [] args)
    {
        // CalcularBonificacao();

        UsarSistema();

        Console.ReadKey();
    }

    public static void UsarSistema()
    {
        SistemaInterno sistemaInterno = new SistemaInterno();
        Diretor roberta = new Diretor("159.753.398-04");
        roberta.Nome = "Roberta";
        roberta.Senha = "123";

        sistemaInterno.Logar(roberta, "123");
        sistemaInterno.Logar(roberta, "abc");

        GerenteDeContas camila = new GerenteDeContas("326.985.628-89");
        camila.Nome = "Camila";
        camila.Senha = "abc";

        ParceiroComercial parceiro = new ParceiroComercial();
        parceiro.Senha = "123456";
        sistemaInterno.Logar(parceiro, "123456");
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