using ByteBank;
using ByteBank.Modelos;
using Humanizer;

internal class Program
{
    private static void Main(string [] args)
    {
        DateTime dataFimPagamento = new DateTime(2023, 08, 21);
        DateTime dataCorrente = DateTime.Now;

        TimeSpan diferenca = TimeSpan.FromMinutes(60); //dataFimPagamento - dataCorrente;
        //Console.WriteLine(dataFimPagamento);
        ///Console.WriteLine(dataCorrente);

        string mensagem = "Vencimento em " + TimeSpanHumanizeExtensions.Humanize(diferenca);

        Console.WriteLine(mensagem);
    }
}


