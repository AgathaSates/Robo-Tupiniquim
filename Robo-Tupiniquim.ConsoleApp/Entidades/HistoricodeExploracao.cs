namespace Robo_Tupiniquim.ConsoleApp.Entidades;

class HistoricodeExploracao
{
    public static string[] historicoExploracao = new string[50];
    public static int missoes;

    public static void MostrarHistorico()
    {
        Console.Clear();
        Console.WriteLine("\x1b[3J");
        Console.WriteLine("-------------------------------------------------------------------");
        Console.WriteLine("                     Histórico de Missões");
        Console.WriteLine("-------------------------------------------------------------------");

        if (historicoExploracao[0] == null)
        {
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("                (X) Não há missões registradas.");
            Console.WriteLine("-------------------------------------------------------------------");
        }

        else
        {
            Console.WriteLine("-------------------------------------------------------------------");
            for (int i = 0; i < missoes; i++)
            {

                Console.Write($"{i + 1}° -");
                Console.WriteLine(historicoExploracao[i]);            
            }
            Console.WriteLine("-------------------------------------------------------------------");
        }
        Console.Write("-> Pressione qualquer tecla para voltar ao menu:");
        Console.ReadKey();
    }

    public static void AdicionarnoHistorico(string mensagem)
    {
        if (missoes < historicoExploracao.Length)
        {
            historicoExploracao[missoes++] = mensagem;
        }
        else
        {
            Console.WriteLine("Histórico cheio.");
        }
    }

}
