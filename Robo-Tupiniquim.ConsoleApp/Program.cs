namespace Robo_Tupiniquim.ConsoleApp;

internal class Program
{
    static int x = 0;
    static int y = 0;
    static char direcao;
    static int largura;
    static int altura;

    static void Main(string[] args)
    {
        Console.WriteLine("Robo Tupiniquim");
        Console.WriteLine("Digite as informações do mapa e do robô.");

        Console.Write("Digite o tamanho do mapa (x y): ");
        string[] limites = Console.ReadLine().Split(' ');
        largura = int.Parse(limites[0]);
        altura = int.Parse(limites[1]);

        Console.Write("Digite a posição inicial do robô (x y direção): ");
        string[] posicaoInicial = Console.ReadLine().Split(' ');
        x = int.Parse(posicaoInicial[0]);
        y = int.Parse(posicaoInicial[1]);
        direcao = char.Parse(posicaoInicial[2].ToUpper());

        Console.Write("Digite os comandos para o robô (E=esquerda, D=direita, M=mover): ");
        string comandos = Console.ReadLine().ToUpper();

        ComandosRobo(comandos);

        static void ComandosRobo(string comandos) 
        {
            foreach (char comando in comandos)
            {
                switch (comando)
                {
                    case 'M': Avançar(); break;

                    case 'E': direcao = VirarParaEsquerda(); break;

                    case 'D': direcao = VirarParaDireita(); break;

                }
            }
            Console.WriteLine($"{x} {y} {direcao}");
        } 

        static void Avançar()
        {
            switch (direcao)
            {
                case 'N': y++; break;

                case 'S': y--; break;

                case 'L': x++; break;

                case 'O': x--; break;

            }

            if (x < 0 || x > largura || y < 0 || y > altura)
            {
                Console.WriteLine("O Robô saiu dos limites do mapa.");
            }           
        }

        static char VirarParaEsquerda()
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

        static char VirarParaDireita()
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
}
