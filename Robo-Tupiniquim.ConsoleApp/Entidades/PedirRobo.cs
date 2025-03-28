using Robo_Tupiniquim.ConsoleApp.Utilitários;

namespace Robo_Tupiniquim.ConsoleApp.Entidades;

class PedirRobo
{
    public static string nomeRobo1;
    public static string nomeRobo2;
    public static int robo1x;
    public static int robo1y;
    public static int robo2x;
    public static int robo2y;
    public static char robo1direcao;
    public static char robo2direcao;
    public static string robo1comandos;
    public static string robo2comandos;

    public static void PedirDadosRobo1()
    {
        EscrevaExploracao.PedirNomeRobo1();
        nomeRobo1 = Console.ReadLine();

        EscrevaExploracao.PedirPosicaoRobo1(nomeRobo1);
        string[] posicaoInicial = Console.ReadLine().Split(' ');
        robo1x = int.Parse(posicaoInicial[0]);
        robo1y = int.Parse(posicaoInicial[1]);
        robo1direcao = char.Parse(posicaoInicial[2].ToUpper());

        EscrevaExploracao.PosicaoInicialRobo(nomeRobo1,robo1x, robo1y, robo1direcao);

        Console.Write("-> Digite os comandos (E=esquerda, D=direita, M=mover) de forma sequencial: ");
        robo1comandos = Console.ReadLine().ToUpper();
    }

    public static void PedirDadosRobo2()
    {
        EscrevaExploracao.PedirNomeRobo2();
        nomeRobo2 = Console.ReadLine();

        EscrevaExploracao.PedirPosicaoRobo2(nomeRobo2);
        string[] posicaoInicial = Console.ReadLine().Split(' ');
        robo2x = int.Parse(posicaoInicial[0]);
        robo2y = int.Parse(posicaoInicial[1]);
        robo2direcao = char.Parse(posicaoInicial[2].ToUpper());

        EscrevaExploracao.PosicaoInicialRobo(nomeRobo2, robo2x, robo2y, robo2direcao);

        Console.Write("-> Digite os comandos (E=esquerda, D=direita, M=mover) de forma sequencial: ");
        robo2comandos = Console.ReadLine().ToUpper();

    }

    
}
