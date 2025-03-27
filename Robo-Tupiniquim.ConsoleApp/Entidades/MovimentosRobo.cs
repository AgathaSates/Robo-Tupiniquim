namespace Robo_Tupiniquim.ConsoleApp.Entidades;

class MovimentosRobo
{
    public static void ComandosRobo(string comandos)
    {
        foreach (char comando in comandos)
        {
            switch (comando)
            {
                case 'M': Avançar(); break;

                case 'E': Robo.direcao = VirarParaEsquerda(); break;

                case 'D': Robo.direcao = VirarParaDireita(); break;

            }
        }
        Console.WriteLine($"{Robo.x} {Robo.y} {Robo.direcao}");
    }

    public static void Avançar()
    {
        switch (Robo.direcao)
        {
            case 'N': Robo.y++; break;

            case 'S': Robo.y--; break;

            case 'L': Robo.x++; break;

            case 'O': Robo.x--; break;

        }

        if (Robo.x < 0 || Robo.x > Area.LimiteX || Robo.y < 0 || Robo.y > Area.LimiteY)
        {
            Console.WriteLine("O Robô saiu dos limites do mapa.");
        }
    }

    public static char VirarParaEsquerda()
    {
        switch (Robo.direcao)
        {
            case 'N': return 'O';

            case 'L': return 'N';

            case 'S': return 'L';

            case 'O': return 'S';

            default: return Robo.direcao;
        }
    }

    public static char VirarParaDireita()
    {
        switch (Robo.direcao)
        {
            case 'N': return 'L';

            case 'L': return 'S';

            case 'S': return 'O';

            case 'O': return 'N';

            default: return Robo.direcao;
        }
    }
}
