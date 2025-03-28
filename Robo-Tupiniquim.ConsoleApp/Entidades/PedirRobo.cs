using Robo_Tupiniquim.ConsoleApp.Entidades.Utilitários;

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
        Console.Clear();
        Console.WriteLine("\x1b[3J");
        Console.WriteLine("-------------------------------------------------------------------------------");
        Console.WriteLine("Comandante, chegou o momento de nomear seu fiel companheiro.");
        Console.WriteLine("Escolha um nome digno, que ressoe nas estrelas e nas vastas terras de Marte.");
        Console.WriteLine("-------------------------------------------------------------------------------");
        Console.Write("Digite o nome do 1° robô: ");

        nomeRobo1 = Console.ReadLine();

        Console.WriteLine($"Agora vamos informar sobre o {nomeRobo1} ");
        Console.WriteLine();
        Console.Write($"-> Digite a posição inicial do {nomeRobo1} (x y direção): ");
        string[] posicaoInicial = Console.ReadLine().Split(' ');
        robo1x = int.Parse(posicaoInicial[0]);
        robo1y = int.Parse(posicaoInicial[1]);
        robo1direcao = char.Parse(posicaoInicial[2].ToUpper());

        EscrevaSobreaMissao.PosicaoInicialRobo(nomeRobo1,robo1x, robo1y, robo1direcao);

        Console.Write("-> Digite os comandos (E=esquerda, D=direita, M=mover) de forma sequencial: ");
        robo1comandos = Console.ReadLine().ToUpper();
    }

    public static void PedirDadosRobo2()
    {
        Console.Clear();
        Console.WriteLine("\x1b[3J");
        Console.WriteLine("-------------------------------------------------------------------------------");
        Console.WriteLine("Seu 2° robô também está pronto e precisamos de um nome!");
        Console.WriteLine("Dê um nome justo do Planeta Vermelho, algo que o acompanhará nesta jornada!");
        Console.WriteLine("-------------------------------------------------------------------------------");
        Console.Write("Digite o nome do 2° robô: ");
        nomeRobo2 = Console.ReadLine();

        Console.WriteLine("------------------------------------------------------------------");
        Console.WriteLine($"Agora vamos informar sobre o {nomeRobo2} ");
        Console.WriteLine();
        Console.Write($"-> Digite a posição inicial do {nomeRobo2} (x y direção): ");
        string[] posicaoInicial = Console.ReadLine().Split(' ');
        robo2x = int.Parse(posicaoInicial[0]);
        robo2y = int.Parse(posicaoInicial[1]);
        robo2direcao = char.Parse(posicaoInicial[2].ToUpper());

        EscrevaSobreaMissao.PosicaoInicialRobo(nomeRobo2, robo2x, robo2y, robo2direcao);

        Console.Write("-> Digite os comandos (E=esquerda, D=direita, M=mover) de forma sequencial: ");
        robo2comandos = Console.ReadLine().ToUpper();

    }

    
}
