namespace Robo_Tupiniquim.ConsoleApp.Entidades;

class Area
{
    public static int LimiteX;
    public static int LimiteY;
    public static void Area_()
    {
        Console.Write("Digite o tamanho do mapa (x y): ");
        string[] limites = Console.ReadLine().Split(' ');
        LimiteX = int.Parse(limites[0]);
        LimiteY = int.Parse(limites[1]);
    } 
}
