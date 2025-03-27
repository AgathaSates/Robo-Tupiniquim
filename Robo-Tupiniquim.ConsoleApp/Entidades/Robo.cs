namespace Robo_Tupiniquim.ConsoleApp.Entidades;

class Robo
{
    public static int x;
    public static int y;
    public static char direcao;
    public static void Robo_()
    {
        Console.Write("Digite a posição inicial do robô (x y direção): ");
        string[] posicaoInicial = Console.ReadLine().Split(' ');
        x = int.Parse(posicaoInicial[0]);
        y = int.Parse(posicaoInicial[1]);
        direcao = char.Parse(posicaoInicial[2].ToUpper());

        Console.Write("Digite os comandos para o robô (E=esquerda, D=direita, M=mover): ");
        string comandos = Console.ReadLine().ToUpper();

        MovimentosRobo.ComandosRobo(comandos);
    }
    
}
