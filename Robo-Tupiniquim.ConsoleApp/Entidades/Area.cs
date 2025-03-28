namespace Robo_Tupiniquim.ConsoleApp.Entidades;

class Area
{
    public static int LimiteX;
    public static int LimiteY;
    public static void PedirArea()
    {
        Console.WriteLine("          Estabeleça o tamanho da area que irá explorar");
        Console.WriteLine("-------------------------------------------------------------------");
        Console.Write("-> Digite o tamanho da área (largura X altura, ex: 5 5): ");
        string[] limites = Console.ReadLine().Split(' ');
        LimiteX = int.Parse(limites[0]);
        LimiteY = int.Parse(limites[1]);

        Console.WriteLine();
        Console.WriteLine($"-> Área de exploração definida: {LimiteX}x{LimiteY} km");
        Console.WriteLine("----------------------------------------------------------");
        Console.Write("-> Pressione qualquer tecla para continuar a missão:");
        Console.ReadKey();
    } 
}
