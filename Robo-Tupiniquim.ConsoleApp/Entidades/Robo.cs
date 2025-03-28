namespace Robo_Tupiniquim.ConsoleApp.Entidades;

class Robo
{
    public static void Robo01()
    {
        Console.Write("Digite a posição inicial do 1° Robô (x y direção): ");
        string[] posicaoInicial = Console.ReadLine().Split(' ');
        int robo1x = int.Parse(posicaoInicial[0]);
        int robo1y = int.Parse(posicaoInicial[1]);
        char robo1direcao = char.Parse(posicaoInicial[2].ToUpper());

        Console.Write("Digite os comandos para o robô (E=esquerda, D=direita, M=mover): ");
        string robo1comandos = Console.ReadLine().ToUpper();

        MovimentosRobo.ComandosRobo(robo1comandos, robo1direcao, robo1x, robo1y);
    }
    public static void Robo02()
    {
        Console.Write("Digite a posição inicial do 2 Robô (x y direção): ");
        string[] posicaoInicial = Console.ReadLine().Split(' ');
        int robo2x = int.Parse(posicaoInicial[0]);
        int robo2y = int.Parse(posicaoInicial[1]);
        char robo2direcao = char.Parse(posicaoInicial[2].ToUpper());

        Console.Write("Digite os comandos para o robô (E=esquerda, D=direita, M=mover): ");
        string robo2comandos = Console.ReadLine().ToUpper();

        MovimentosRobo.ComandosRobo(robo2comandos, robo2direcao, robo2x, robo2y);
    }
    
}
