namespace Robo_Tupiniquim.ConsoleApp.Entidades.Utilitários;

class Validadores
{
    public static string opcaoContinuar;
    public static void SimouNaoValido()
    {
        opcaoContinuar = Console.ReadLine()!.ToUpper();
        while (string.IsNullOrWhiteSpace(opcaoContinuar) || opcaoContinuar.ToUpper() != "S" && opcaoContinuar.ToUpper() != "N")
        {
            Console.Write("(X) Opção inválida! Digite novamente S ou N: ");
            opcaoContinuar = Console.ReadLine()!;
        }
    }
}
