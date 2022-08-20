using ByteBank;
using ByteBank.Modelos;

internal class Program
{
    private static void Main(string [] args)
    {
        DateTime dataFimPagamento = new DateTime(2022, 09, 21);
        DateTime dataCorrente = DateTime.Now;

        TimeSpan diferenca = dataFimPagamento - dataCorrente;
        //Console.WriteLine(dataFimPagamento);
        ///Console.WriteLine(dataCorrente);

        string mensagem = "Vencimento em " + GetIntervaloDeTempoLegivel(diferenca);

        Console.WriteLine(mensagem);

        static string GetIntervaloDeTempoLegivel(TimeSpan timespan)
        {
            if (timespan.Days > 30)
            {
                int qtdeMeses = timespan.Days / 30;
                if (qtdeMeses == 1)
                {
                    return "1 mês";
                }
                return qtdeMeses + " meses";
            }
            else if (timespan.Days > 7){
                int qtdeSemanas = timespan.Days / 7;
            }  

            return timespan.Days + " dias.";
        }
    }
}


