using Robo_Tupiniquim.ConsoleApp.Utilitários;
namespace Robo_Tupiniquim.ConsoleApp.Entidades;

class HistoricodeExploracao
{
    public static string[] historicoExploracao = new string[50];
    public static int missoes;

    public static void MostrarHistorico()
    {
        Console.Clear();
        Console.WriteLine("\x1b[3J");
        Colorir.EscreverEmAzul("-------------------------------------------------------------------");
        Colorir.EscreverEmAzul("                     Histórico de Missões");
        Colorir.EscreverEmAzul("-------------------------------------------------------------------");

        if (historicoExploracao[0] == null)
        {
            Colorir.EscreverEmVermelho("-------------------------------------------------------------------");
            Colorir.EscreverEmVermelho("                (X) Não há missões registradas.");
            Colorir.EscreverEmVermelho("-------------------------------------------------------------------");
        }

        else
        {
            Colorir.EscreverEmAzul("-------------------------------------------------------------------");
            for (int i = 0; i < missoes; i++)
            {

                Colorir.EscreverEmAmareloEscuroLinha($"{i + 1}° -");
                Colorir.EscreverEmVerde(historicoExploracao[i]);            
            }
            Colorir.EscreverEmAzul("-------------------------------------------------------------------");
        }
        Colorir.EscreverEmAmareloEscuroLinha("-> Pressione qualquer tecla para voltar ao menu:");
        Console.ReadKey();
    }

    public static void AdicionarnoHistorico(string mensagem)
    {
        if (missoes < historicoExploracao.Length)
            historicoExploracao[missoes++] = mensagem;
    
        else
            Colorir.EscreverEmVermelho("Histórico cheio.");
    }
}
