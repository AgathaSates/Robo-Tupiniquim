namespace Robo_Tupiniquim.ConsoleApp.Entidades.Utilitários;

class EscrevaInteracao
{
    public static bool Explorarnovamente()
    {
        Thread.Sleep(1000);
        Console.WriteLine("Deseja explorar uma nova área? (S/N): ");

        Validadores.SimouNaoValido();

        if (Validadores.opcaoContinuar == "N")
            return false;

        else
            return true;
    }
}
