using ByteBank;
using ByteBank.Modelos;

internal class Program
{
    private static void Main(string [] args)
    {
        ContaCorrente conta = new ContaCorrente(847, 489754);

        conta.Sacar();

        // AutenticacaoHelper teste;

        Console.WriteLine(conta.Numero);
        Console.ReadKey();

    }
}


