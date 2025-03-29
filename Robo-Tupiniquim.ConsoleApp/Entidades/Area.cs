using Robo_Tupiniquim.ConsoleApp.Utilitários;

namespace Robo_Tupiniquim.ConsoleApp.Entidades;

class Area
{
    public static int LimiteX;
    public static int LimiteY;
    public static void PedirArea()
    {
        Thread.Sleep(800);
        Colorir.EscreverEmRosa("          Estabeleça o tamanho da area que irá explorar");
        Colorir.EscreverEmAzul("-------------------------------------------------------------------");
        Colorir.EscreverEmAmareloEscuroLinha("-> Digite o tamanho da área (largura X altura, ex:5 5): ");
        string[] limites = Validadores.EhUmaAreaValdia().Split(' ');
        LimiteX = int.Parse(limites[0]);
        LimiteY = int.Parse(limites[1]);

        Console.WriteLine();
        Colorir.EscreverEmRosa($"-> Área de exploração definida: {LimiteX}x{LimiteY}");
        Colorir.EscreverEmAzul("-------------------------------------------------------------------");
        Colorir.EscreverEmAmareloEscuroLinha("-> Pressione qualquer tecla para continuar");
        Console.ReadKey();
    } 
}
