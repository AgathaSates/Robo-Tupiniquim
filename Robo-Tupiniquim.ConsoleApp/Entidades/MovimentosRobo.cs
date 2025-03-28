namespace Robo_Tupiniquim.ConsoleApp.Entidades;

class MovimentosRobo
{ 
    public static void ComandosRobo(string comandos, char direcao, int x, int y)
    {
        foreach (char comando in comandos)
        {
            switch (comando)
            {
                case 'M': Avançar(direcao, ref x, ref y); break;

                case 'E': direcao = VirarParaEsquerda(direcao); break;

                case 'D': direcao = VirarParaDireita(direcao); break;

            }
        }
        Console.WriteLine($"A posição final é: {x} {y} {direcao}");
    }

    public static void Avançar(char direcao, ref int x, ref int y)
    {
        switch (direcao)
        {
            case 'N': y++; break;

            case 'S': y--; break;

            case 'L': x++; break;

            case 'O': x--; break;

        }

        if (x < 0 || x > Area.LimiteX || y < 0 || y > Area.LimiteY)
        {
            Console.WriteLine("O Robô saiu dos limites do mapa.");
        }
    }

    public static char VirarParaEsquerda(char direcao)
    {
        switch (direcao)
        {
            case 'N': return 'O';

            case 'L': return 'N';

            case 'S': return 'L';

            case 'O': return 'S';

            default: return direcao;
        }
    }

    public static char VirarParaDireita(char direcao)
    {
        switch (direcao)
        {
            case 'N': return 'L';

            case 'L': return 'S';

            case 'S': return 'O';

            case 'O': return 'N';

            default: return direcao;
        }
    }
}
